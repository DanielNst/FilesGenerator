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

namespace Generator_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 0;
            string filename = "";
            char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '#', '№', '!', '$', ';', '*', '<', '>', '~', '&', '?', ':', '#', '$', '#', '$', '%', '%', '%', '@', '@', '@', '@', '@', '╙', '╚', '╛', '╜', '╝', '╞', '╟', '╠' ,'╡' ,'╢', '╣', '╙', '╚', '╛', '╜', '╝', '╞', '╟', '╠', '╡', '╢', '╣', '╙', '╚', '╛', '╜', '╝', '╞', '╟', '╠', '╡', '╢', '╣', '╙', '╚', '╛', '╜', '╝', '╞', '╟', '╠', '╡', '╢', '╣', '╣' };
            try
            {
                size = int.Parse(maskedTextBox1.Text);
            }
            catch (System.FormatException)
            {
                textBox3.Visible = true;
                textBox3.Text = "Программе нужно знать название и размер файла :)";
            }
            try
            {
                filename = maskedTextBox2.Text;
            }
            catch (System.FormatException)
            {
                textBox3.Visible = true;
                textBox3.Text = "Программе нужно знать название и размер файла :)";
            }
            StreamWriter file = new StreamWriter(filename);
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            int rand_symbol = 0;
            int format = 545000;
            if (checkBox1.Checked == true)
            {
                format = 545;
            }
            for (int i = 0; i < format * size; i++)
            {
                //Получить случайное число
                rand_symbol = rnd.Next(0,104);
                file.Write(symbols[rand_symbol]);
                if (i % 150 == 0 && i > 10)
                {
                    file.Write("\n");
                }
            }
            file.Close();
            textBox3.Visible = true;
            textBox3.Text = "Файл успешно сгенерирован и в той же папке, где и программа";
        }
    }
}


