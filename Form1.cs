using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_3
{
    public partial class Form1 : Form
    {
        string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddFavorite()
        {
            result = "您喜歡....\n";
            if (checkBox1.Checked) result += checkBox1.Text + "\n";
            if (checkBox2.Checked) result += checkBox2.Text + "\n";
            if (checkBox3.Checked) result += checkBox3.Text + "\n";
            if (checkBox4.Checked) result += checkBox4.Text + "\n";
            if (checkBox5.Checked) result += checkBox5.Text + "\n";
            if (checkBox6.Checked) result += checkBox6.Text + "\n";
            if (checkBox7.Checked) result += checkBox7.Text + "\n";
            if (checkBox8.Checked) result += checkBox8.Text + "\n";
            if (checkBox9.Checked) result += checkBox9.Text + "\n";
            if (checkBox10.Checked) result += checkBox10.Text + "\n";
            if (checkBox11.Checked) result += checkBox11.Text + "\n";
            if (checkBox12.Checked) result += checkBox12.Text + "\n";
            if (checkBox13.Checked) result += checkBox13.Text + "\n";
            if (checkBox14.Checked) result += checkBox14.Text + "\n";
            if (checkBox15.Checked) result += checkBox15.Text + "\n";
            if (checkBox16.Checked) result += checkBox16.Text + "\n";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AddFavorite();
            MessageBox.Show(result, "勾選列表", MessageBoxButtons.OK);
            result = "";
        }
    }
}
