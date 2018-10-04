using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace блокнот
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый файл|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public Form2(string text)
        {

            InitializeComponent();
            textBox1.Text = text;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                DialogResult rez = MessageBox.Show("Окно содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes)
                {



                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = "Безымянняй";
                    sfd.Filter = "Текстовый файл|*.txt";


                    //sfd.ShowDialog();
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, textBox1.Text);
                        textBox1.Clear();
                    }

                }
                if (rez == DialogResult.No)
                {
                    textBox1.Clear();
                }
            }
            this.Close();
        }
    }
}
