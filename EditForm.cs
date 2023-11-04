using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Net.Http;
using WinMultiwindow.Core;

namespace WinMultiwindow
{
    public partial class EditForm : Form
    {
        public Good? good { get; set; } = null;

        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(Good good)
        {
            InitializeComponent();
            this.good = good;
            textBox1.Text = good.Name;
            textBox2.Text = good.Description;
            textBox3.Text = good.Price;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (good == null)
            {
                good = new Good();
            }

            good.Name = textBox1.Text;
            good.Description = textBox2.Text;
            good.Price = textBox3.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
        