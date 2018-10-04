using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace блокнот
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
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
        }

        private void Блокнот_TextChanged(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = " Текстовый файл|*.txt";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(Path.GetFullPath(ofd.FileName));
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый файл|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
                textBox1.Clear();
            }

        }
        char[] str = new char[5000];

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText.CopyTo(0, str, textBox1.TextLength, 0);
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string str1 = str.ToString();
            textBox1.Paste(str.ToString());

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void размерФайлаToolStripMenuItem_Click(object sender, EventArgs e)

        {


            string path = @"C:hta.txt";
            StreamWriter sw = new StreamWriter("C:hta.txt");
            sw.WriteLine(textBox1.Text);
            FileInfo fileInf = new FileInfo(path);



            MessageBox.Show(fileInf.Length.ToString(), "Размер файла в байтах", MessageBoxButtons.OK);
        }

        private void колвоСимволовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.TextLength.ToString(), "Количество символов", MessageBoxButtons.OK);
        }

        private void колвоАвторскихСтраницToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pages = textBox1.TextLength / 1800 + 1;
            MessageBox.Show(pages.ToString(), "Количество авторских страниц", MessageBoxButtons.OK);
        }

        private void колвоГластныхБуквToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gl = "AaEeOoUuYyIiАаОоУуЕеЫыЯяИиЁёЭэЕе";
            int c = textBox1.Text.Count(p => gl.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(c.ToString(), "Количество гласных букв", MessageBoxButtons.OK);
        }

        private void колвоСогласныхБуквToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sogl = "бБвВгГдДйЙжЖзЗкКлЛмМнНпПрРсСтТфФцЦчЧшШщЩ" +
                "bBcCdDfFgGhHjJkKlLmMnpPqQrRsStTvVwWxXyYZz";
            int c = textBox1.Text.Count(p => sogl.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(c.ToString(), "Количество согласных букв", MessageBoxButtons.OK);
        }

        private void колвоЦиферToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numb = "0123456789";
            int k = textBox1.Text.Count(p => numb.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(k.ToString(), "Количество цифер", MessageBoxButtons.OK);
        }

        private void колвоСпециальныхСимволовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sym = "~:;'*-+=+-_&#@%^";
            int s = textBox1.Text.Count(p => sym.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(s.ToString(), "Количество специальных символов", MessageBoxButtons.OK);
        }

        private void колвоЗнаковПунктуацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pun = ".,:;!?";
            int pu = textBox1.Text.Count(p => pun.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(pu.ToString(), "Количество специальных символов", MessageBoxButtons.OK);

        }

        private void колвоКиррилическихСимволовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sogl = "бБвВгдДйЙжЖзЗкКлЛмМнНпПрРсСтфФцЦчЧшШщЩ,АаОоУуЕеЫыЯяИиЁёЭэЕеІіьЬЇїъЪ";
            int c = textBox1.Text.Count(p => sogl.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(c.ToString(), "Количество специальных символов", MessageBoxButtons.OK);
        }

        private void колвоЛаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sogl = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYZzAaEeOoUuYyIi";
            int c = textBox1.Text.Count(p => sogl.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(c.ToString(), "Количество специальных символов", MessageBoxButtons.OK);
        }

        private void удалениеВсехНезначущихПробеловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Regex.Replace(textBox1.Text, "[ ]+", " ");
            string str1 = Regex.Replace(str, "\t", " ");
            string str2 = Regex.Replace(str1, "\n\n", "\t");
            string str3 = Regex.Replace(str2, "\n", " ");
            Form2 newForm = new Form2(str3);
            newForm.Show(this);


        }

        private void колвоПустыхСтрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string arr = textBox1.Text;
            char[] str = arr.ToCharArray();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "\r\n")
                    count += 1;
            }
            MessageBox.Show(count.ToString(), "Количество пустых строк", MessageBoxButtons.OK);
        }

        private void доподнительныеВозможностиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void проверкаНаличаяАдрессаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int g = 0;
            string pattern = @"([А-Я][а-я]+[\-\s]?){3,}, ул\. [А-Я][а-я]+, д\. [0-9]+, кв\. [0-9]+, г\. [А-Я][а-я]+, [0-9]{5}";
            //foreach (Match match in Regex.Matches(s, pattern, RegexOptions.IgnoreCase)) ;
           // Regex re = new Regex(pattern);
            //string match = Convert.ToString(re.Match(textBox1.Text));


            //string pattern = @"[А-Я][а-я]+\s+[А-Я][а-я]";
            Regex flnames = new Regex(pattern);

            string match = Convert.ToString(flnames.Match(textBox1.Text));



            /*MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    // MessageBox.Show("Текст содержит служебные слова", "Количество специальных символов", MessageBoxButtons.OK);
                    g++;
            }*/


            if (match != "")
                MessageBox.Show("Текст содержит почтовые индексы " + match, "Наличие почтовых индексов", MessageBoxButtons.OK);
            else { MessageBox.Show("Текст не содержит почтовых индексов", "Наличие почтовых индексов", MessageBoxButtons.OK); }


        }

        private void пороверкаНаНаличаеКлючевыхСловСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] str = { "if", "case", "for", "else", "break" , "char" };
            int g = 0;
            string k = "";
            for (int i = 0; i < str.Length; i++)
            {
                Regex regex = new Regex(str[i]);
                MatchCollection matches = regex.Matches(s);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        k += match;
                        g++;
                }

            }
            if (g > 0)
                MessageBox.Show("Текст содержит служебные слова" + k + ";", "Количество специальных символов", MessageBoxButtons.OK);
            else MessageBox.Show("Текст не содержит служебные слова", "Количество специальных символов", MessageBoxButtons.OK);





        }

        private void проверкаНаличияИнтернетадресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] str = { "edu.ua", "net.ua", "com.ua", "in.ua" };
            int g = 0;
            for (int i = 0; i < str.Length; i++)
            {
               


                Regex re = new Regex(str[i]);
                string match = Convert.ToString(re.Match(textBox1.Text));
                if (re.IsMatch(textBox1.Text))
                    MessageBox.Show("Текст содержит интернет адреса " +match, "Количество специальных символов", MessageBoxButtons.OK);
            }
            


            
        }

        private void полнаяСтатистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"C:hta.txt";
            StreamWriter sw = new StreamWriter("C:hta.txt");
            sw.WriteLine(textBox1.Text);
            FileInfo fileInf = new FileInfo(path);
            string gl = "AaEeOoUuYyIiАаОоУуЕеЫыЯяИиЁёЭэЕе";
            int c = textBox1.Text.Count(p => gl.IndexOf(Char.ToLower(p)) >= 0);
            string sogl = "бБвВгГдДйЙжЖзЗкКлЛмМнНпПрРсСтТфФцЦчЧшШщЩ" +
               "bBcCdDfFgGhHjJkKlLmMnpPqQrRsStTvVwWxXyYZz";
            int d = textBox1.Text.Count(p => sogl.IndexOf(Char.ToLower(p)) >= 0);
            string numb = "0123456789";
            int k = textBox1.Text.Count(p => numb.IndexOf(Char.ToLower(p)) >= 0);
            string sym = "~:;'*-+=+-_&#@%^";
            int s = textBox1.Text.Count(p => sym.IndexOf(Char.ToLower(p)) >= 0);
            string pun = ".,:;!?";
            int pu = textBox1.Text.Count(p => pun.IndexOf(Char.ToLower(p)) >= 0);
            MessageBox.Show(("Размер файла : " + fileInf.Length).ToString() + " байт\n" +
                "Количество символов : " + textBox1.TextLength.ToString() + "\n" + "Количество авторских страниц : " +
                (textBox1.TextLength / 1800 + 1).ToString() + "\n" + "Количество гласных букв : " + c.ToString() + "\n"
                + "Количество согласных букв : " + d.ToString() + "\n" + "Количество цифер : " + k.ToString() + "\n"
                + "Количество специальных символов : " + s.ToString() + "\n" + "Количество специальных символов : " + pu.ToString()
                , "Статистика", MessageBoxButtons.OK);
        }

        private void колвоАбзацевToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string arr = textBox1.Text;
            char[] str = arr.ToCharArray();
            int count = 0;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (str[i] == '\t')
                    count += 1;
            }
            MessageBox.Show(count.ToString(), "Количество абзацев", MessageBoxButtons.OK);

        }

        private void поискаПервогоВхожденияДвухСловимяИФамилияToolStripMenuItem_Click(object sender, EventArgs e)
        {
         


            string pattern = @"[А-Я][а-я]+\s+[А-Я][а-я]{8}";
            Regex flnames = new Regex(pattern);

            string match = Convert.ToString(flnames.Match(textBox1.Text));

            if (match != "")
            MessageBox.Show(match, "Наличие имен и фамилий", MessageBoxButtons.OK);
            else
                MessageBox.Show("Файл не содержит имен", "Наличие имен и фамилий", MessageBoxButtons.OK);

        }

        private void поискаПервогоВхождениеФамилииСИнициаламиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"[A-ZА-Я][A-Za-zА-Яа-я]* [A-ZА-Я].[A-ZА-Я].*";
            Regex flnames = new Regex(pattern);

            string match = Convert.ToString(flnames.Match(textBox1.Text));
            if (match != "")
                MessageBox.Show(match, "Наличие ФИО", MessageBoxButtons.OK);
           else
                MessageBox.Show("Файл не содержит ФИО", "Наличие ФИО", MessageBoxButtons.OK);

        }

        private void поискВсехЭлектронныхАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"[\s]+[a-zA-Z1-9\-\._]+@[a-z1-9]+(.[a-z1-9]+){1,}";
            
            Regex rgx = new Regex(pattern);
            string sentence = Convert.ToString(rgx.Match(textBox1.Text));
            
            MessageBox.Show("Текст содержит адреса электронной почты " + sentence, "Наличие адреса электронной почты", MessageBoxButtons.OK);
            
        }

        private void целочисленныеКонстантыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"(“|’|‘)[0-9]+(“|’|‘)";
            Regex rgx = new Regex(pattern);
            string sentence = textBox1.Text;
            string temp = "";
            foreach (Match match in rgx.Matches(sentence))
            {
                temp += match;
            }
            MessageBox.Show("Текст содержит целочисленные константы "+temp, "Наличие констант", MessageBoxButtons.OK);
            
        }

        private void вещественныеКонстантыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"(“|’|‘)[0-9]+(.|,)[0-9]+(“|’|‘)";
           
            Regex rgx = new Regex(pattern);
            string sentence = textBox1.Text;
            string temp = "";
            foreach (Match match in rgx.Matches(sentence))
            {
                temp += match;
            }
            MessageBox.Show("Текст содержит вещественные константы" + temp, "Наличие констант", MessageBoxButtons.OK);

        }

        private void комплексныеКонстантыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"(“|’|‘)[0-9]+(\+|\-)[0-9]+([i|I]|\*([i|I]))(“|’|‘)"; ;
            Regex rgx = new Regex(pattern);
            string sentence = textBox1.Text;
            string temp = "";
            foreach (Match match in rgx.Matches(sentence))
            {
                temp += match;
            }

                MessageBox.Show("Текст  содержит комплексные констант" + temp, "Наличие констант", MessageBoxButtons.OK);

        }
    }
}
