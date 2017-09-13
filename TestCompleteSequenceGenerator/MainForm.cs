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

namespace TestCompleteSequenceGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProcessBtn.Enabled = false;
        }
        bool stringExist = false;
        bool incrementExist = false;
        bool pathExist = false;


        private void StringTb_TextChanged(object sender, EventArgs e)
        {
            if (StringTb.Text.Length > 5)
            {
                stringExist = true;
                enableProcess();
            }
            else
            {
                stringExist = false;
            }


        }



        private void PathTb_TextChanged(object sender, EventArgs e)
        {
            if (PathTb.Text.Length > 5)
            {
                pathExist = true;
                enableProcess();
            }
            else
            {
                pathExist = false;
            }
        }

        private void enableProcess()
        {
            if (stringExist is true && incrementExist is true && pathExist is true)
            {
                ProcessBtn.Enabled = true;
            }
            else
            {
                ProcessBtn.Enabled = false;
            }
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            string stringEdit = StringTb.Text;
            string[] Products = new string[(int)IcrementAmount.Value];
            for (int i = 1; i < (IcrementAmount.Value + 1); i++)
            {
                Products[(i - 1)] = stringEdit.Replace($"{Replacetb.Text}", $"{i}");
            }

            File.WriteAllLines(PathTb.Text, Products);
            MessageBox.Show("Job Done");
        }

        private void PathBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = ".txt (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                PathTb.Text = saveFile.FileName;
            }


        }

        private void IcrementAmount_ValueChanged_1(object sender, EventArgs e)
        {
            if (IcrementAmount.Value > 1)
            {
                incrementExist = true;
                enableProcess();
            }
            else
            {
                incrementExist = false;
            }
        }
    }
}
