using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Opener1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> filelocation = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Savelist.txt"))
            {
                filelocation = File.ReadAllLines("Savelist.txt").ToList();
            }
            for (int i = 0; i < filelocation.Count; i++)
            {
                string[] splitedname = filelocation[i].Split('\\');
                string filename = splitedname[splitedname.Length - 1];
                FileLocationList.Items.Add(filename);
            }
        }

        private void openfilebtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filelocation.Count; i++)
            {
                Process.Start(filelocation[i]);
            }
        }

        private void addfilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    string[] splitedname = ofd.FileNames[i].Split('\\');
                    string filename = splitedname[splitedname.Length - 1];
                    if (filelocation.Contains(ofd.FileNames[i]))
                    {
                        DialogResult msgbox = MessageBox.Show("Do you want to add this anyways?", $"{filename} already exists in the list.", MessageBoxButtons.YesNo);
                        if (msgbox == DialogResult.Yes)
                        {
                            FileLocationList.Items.Add(filename);
                            filelocation.Add(ofd.FileNames[i]);
                        }
                    }
                    else
                    {
                        FileLocationList.Items.Add(filename);
                        filelocation.Add(ofd.FileNames[i]);
                    }
                }
            }
        }

        private void removeallbtn_Click(object sender, EventArgs e)
        {
            filelocation.Clear();
            FileLocationList.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter tw = new StreamWriter("Savelist.txt");

            foreach (string s in filelocation)
            {
                tw.WriteLine(s);
            }
            tw.Close();
        }

        private void FileLocationList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(FileLocationList.SelectedIndex != -1)
            {
                filelocation.RemoveAt(FileLocationList.SelectedIndex);
                FileLocationList.Items.RemoveAt(FileLocationList.SelectedIndex);
            }
        }
    }
}
