using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox data;
        private ListBox results;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void textBox1_DragOver(object sender, DragEventArgs e)
        {

            string[] d = (string[])e.Data.GetData(DataFormats.FileDrop);
            byte[] hash;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(d[0]))
                {
                    hash = md5.ComputeHash(stream);

                }
            }
            this.Invoke(new Action(() =>
                {
                    textBox1.Text = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

                }));
        }
    }
}
