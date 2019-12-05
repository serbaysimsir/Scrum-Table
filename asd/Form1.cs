using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

 namespace asd
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string dosya_yolu = @"D:\metinStories.txt";
            
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                listboxStories.Items.Add(yazi);
                comboBox1.Items.Add(yazi);
                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();

            comboBox1.SelectedIndex = 0;

            string dosya_yolu2 = @"D:\metinNotStarted.txt";

            FileStream fs2 = new FileStream(dosya_yolu2, FileMode.Open, FileAccess.Read);
            StreamReader sw2 = new StreamReader(fs2);
            string yazi2 = sw2.ReadLine();
            while (yazi2 != null)
            {
                listboxNotStarted.Items.Add(yazi2);
                yazi2 = sw2.ReadLine();
            }
            sw2.Close();
            fs2.Close();

            string dosya_yolu3 = @"D:\metinInProgress.txt";

            FileStream fs3 = new FileStream(dosya_yolu3, FileMode.Open, FileAccess.Read);
            StreamReader sw3 = new StreamReader(fs3);
            string yazi3 = sw3.ReadLine();
            while (yazi3 != null)
            {
                listBoxInProgress.Items.Add(yazi3);
                yazi3 = sw3.ReadLine();
            }
            sw3.Close();
            fs3.Close();

            string dosya_yolu4 = @"D:\metinDone.txt";

            FileStream fs4 = new FileStream(dosya_yolu4, FileMode.Open, FileAccess.Read);
            StreamReader sw4 = new StreamReader(fs4);
            string yazi4 = sw4.ReadLine();
            while (yazi4 != null)
            {
                listBoxDone.Items.Add(yazi4);
                yazi4 = sw4.ReadLine();
            }
            sw4.Close();
            fs4.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stories = "Stories Adı: " + textBox3.Text.ToString() + " - Stories Bilgisi: " + textBox1.Text.ToString();
            if(textBox1.Text.ToString() != "" && textBox3.Text.ToString() != "")
            {
                if (stories != null)
                {
                    listboxStories.Items.Add(stories);
                    comboBox1.Items.Add(stories);
                   
                }
            }
        }
        
        private void listboxNotStarted_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)

            {

                e.Effect = DragDropEffects.Move;
                listboxNotStarted.Items.Remove(listboxNotStarted.SelectedItem);
            }
        }

        private void listboxNotStarted_DragDrop(object sender, DragEventArgs e)
        {
            listboxNotStarted.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
          
        }
        private void listboxNotStarted_MouseDown(object sender, MouseEventArgs e)
        {
            Point n = new Point(e.X, e.Y);

            int i = listboxNotStarted.IndexFromPoint(n);

            if (e.Button == MouseButtons.Left && i != -1)

            {
                listboxNotStarted.DoDragDrop(listboxNotStarted.Items[i], DragDropEffects.All);
            }
        }

        private void listBoxInProgress_DragDrop(object sender, DragEventArgs e)
        {

            listBoxInProgress.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
        }

        private void listBoxInProgress_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)

            {

                e.Effect = DragDropEffects.Move;
                listBoxInProgress.Items.Remove(listBoxInProgress.SelectedItem);
            }
        }

        private void listBoxInProgress_MouseDown(object sender, MouseEventArgs e)
        {
            Point n = new Point(e.X, e.Y);

            int i = listBoxInProgress.IndexFromPoint(n);

            if (e.Button == MouseButtons.Left && i != -1)

            {
                listBoxInProgress.DoDragDrop(listBoxInProgress.Items[i], DragDropEffects.All);
            }
        }

        private void listBoxDone_DragDrop(object sender, DragEventArgs e)
        {
            listBoxDone.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
        }

        private void listBoxDone_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)

            {

                e.Effect = DragDropEffects.Move;
                listBoxDone.Items.Remove(listBoxDone.SelectedItem);
            }
        }

        private void listBoxDone_MouseDown(object sender, MouseEventArgs e)
        {
            Point n = new Point(e.X, e.Y);

            int i = listBoxDone.IndexFromPoint(n);

            if (e.Button == MouseButtons.Left && i != -1)

            {
                listBoxDone.DoDragDrop(listBoxDone.Items[i], DragDropEffects.All);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime tarih = textEdit1.DateTime;
            String task = "Stories: " + comboBox1.Text.ToString() + " - Ad Soyad : " + textBox2.Text.ToString() + " - Tarih : " + tarih.ToShortDateString();
            if(textBox2.Text.ToString()!="" && textEdit1.Text.ToString() != "")
            {
                if (task != null && tarih.ToShortDateString() != "01.01.0001")
                {
                    listboxNotStarted.Items.Add(task);
                 
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listboxStories.Items.Count != 0)
            {
                string dosya_yolu = @"D:\metinStories.txt";
                FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; listboxStories.Items.Count > i; i++)
                {
                    sw.WriteLine(listboxStories.Items[i]);
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }

            if (listboxNotStarted.Items.Count != 0)
            {
                string dosya_yolu2 = @"D:\metinNotStarted.txt";
                FileStream fs2 = new FileStream(dosya_yolu2, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw2 = new StreamWriter(fs2);

                for (int i = 0; listboxNotStarted.Items.Count > i; i++)
                {
                    sw2.WriteLine(listboxNotStarted.Items[i]);
                }
                sw2.Flush();
                sw2.Close();
                fs2.Close();
            }
            else
            {
                TextWriter tw = new StreamWriter(@"D:\metinNotStarted.txt");
                tw.Write("");
                tw.Close();
            }

            if (listBoxInProgress.Items.Count != 0)
            {
                string dosya_yolu3 = @"D:\metinInProgress.txt";
                FileStream fs3 = new FileStream(dosya_yolu3, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw3 = new StreamWriter(fs3);

                for (int i = 0; listBoxInProgress.Items.Count > i; i++)
                {
                    sw3.WriteLine(listBoxInProgress.Items[i]);
                }
                sw3.Flush();
                sw3.Close();
                fs3.Close();
            }
            else
            {
                TextWriter tw2 = new StreamWriter(@"D:\metinInProgress.txt");
                tw2.Write("");
                tw2.Close();
            }
            if (listBoxDone.Items.Count != 0)
            {
                string dosya_yolu4 = @"D:\metinDone.txt";
                FileStream fs4 = new FileStream(dosya_yolu4, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw4 = new StreamWriter(fs4);

                for (int i = 0; listBoxDone.Items.Count > i; i++)
                {
                    sw4.WriteLine(listBoxDone.Items[i]);
                }
                sw4.Flush();
                sw4.Close();
                fs4.Close();
            }
            else
            {
                TextWriter tw3 = new StreamWriter(@"D:\metinDone.txt");
                tw3.Write("");
                tw3.Close();
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
