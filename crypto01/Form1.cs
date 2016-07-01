using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace crypto01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            get_alphabet();
        }

        private Dictionary<string, string> alph_encode = new Dictionary<string, string>();
        private Dictionary<string, string> alph_decode = new Dictionary<string, string>();

        public void generate_alphabet()
        {
            string[] alph00 =
            {
                "000", "001", "002", "010", "011", "012", "020", "021", "022",
                "100", "101", "102", "110", "111", "112", "120", "121", "122",
                "200", "201", "202", "210", "211", "212", "220", "221", "222",
            };

            this.alph_encode.Clear();
            this.alph_decode.Clear();

            Dictionary<byte, string> alph01 = new Dictionary<byte, string>();

            byte[] x = new byte[27];
            for (byte i = 1; i <= 27; i++)
            {
                x[i - 1] = i;
                alph01.Add(i, alph00[i - 1]);
            }
            Random random = new Random(DateTime.Now.Millisecond);
            x = x.OrderBy(xxx => random.Next()).ToArray();

            for (byte i = 1; i <= 27; i++)
            {
                alph_encode.Add(alph01[i], alph01[x[i - 1]]);
            }

            alph_decode = alph_encode.ToDictionary(xxx => xxx.Value, xxx => xxx.Key);
            alph01.Clear();

            using (StreamWriter al = new StreamWriter(new FileStream("tech", FileMode.Create)))
            {
                foreach (var zzz in alph_encode)
                    al.WriteLine("{0} {1}", zzz.Key, zzz.Value);
                foreach (var zzz in alph_decode)
                    al.WriteLine("{0} {1}", zzz.Key, zzz.Value);
            }
        }
        private void get_alphabet()
        {
            using (StreamReader al = new StreamReader(new FileStream("tech", FileMode.Open)))
            {
                this.alph_encode.Clear();
                this.alph_decode.Clear();

                string[] temp;
                char[] sep = { ' ' };
                for (byte i = 0; i < 27; i++)
                {
                    temp = al.ReadLine().Split(sep);
                    alph_encode.Add(temp[0], temp[1]);
                }
                for (byte i = 0; i < 27; i++)
                {
                    temp = al.ReadLine().Split(sep);
                    alph_decode.Add(temp[0], temp[1]);
                }
            }
        }

        private bool check_text(byte[] buffer)
        {
            for (byte i = 0; i < buffer.Count(); i++)
            {
                if (buffer[i] < 48 || buffer[i] > 50)
                {
                    MessageBox.Show("Данные содержат элементы, отсутствующие в алфавите", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        
        private void encrypt_B_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text);
            
            if (check_text(buffer))
                return;

            byte cnt = (byte)buffer.Count();
            byte cnt_m = (byte)(cnt % 3); // количество элементов в последнем блоке
            textBox2.Text = Convert.ToString(cnt_m);
            
            for (byte i = 0; i < cnt; i += 3)
            {
                string blc = "";
                if (i + cnt_m == cnt)
                {
                    for (byte j = 0; j < cnt_m; j++)
                        blc += Convert.ToString((char)buffer[i + j]);
                    for (byte j = 0; j < 3 - cnt_m; j++)
                        blc = blc + Convert.ToString("0");
                }
                else
                    blc = Convert.ToString((char)buffer[i]) + Convert.ToString((char)buffer[i + 1]) + Convert.ToString((char)buffer[i + 2]);
                textBox2.Text += alph_encode[blc];
            }
        }

        private void decrypt_B_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text);

            if (check_text(buffer))
                return;

            byte cnt_m = (byte)(buffer[0] - 48);

            for (byte i = 1; i < buffer.Count(); i += 3)
            {
                string blc;
                blc = Convert.ToString((char)buffer[i]) + Convert.ToString((char)buffer[i + 1]) + Convert.ToString((char)buffer[i + 2]);
                textBox2.Text += alph_decode[blc];
            }
            if (cnt_m != 0)
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 3 + cnt_m, 3 - cnt_m);
        }

        private void more_options_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
