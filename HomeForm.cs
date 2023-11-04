using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinMultiwindow.Core;

namespace WinMultiwindow
{
    public partial class HomeForm : Form
    {
        LoginForm loginForm;
        GoodCollection goodCollection;
        EditForm editForm;
        public HomeForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            goodCollection = new GoodCollection();
        }

        private void ButtonCommand(object sender, EventArgs e)
        {
            Button? buttonControl = sender as Button;
            if (buttonControl?.Text == "Додати")
            {
                editForm = new EditForm();
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    if (editForm.good != null)
                    {
                        goodCollection.Add(editForm.good);
                        listBox1.Items.Add(editForm.good);
                    }
                }
            }
            else if (buttonControl?.Text == "Змінити")
            {
                Good good = listBox1.SelectedItem as Good;
                editForm = new EditForm(good);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    if (editForm.good != null)
                    {
                        goodCollection.Edit(listBox1.SelectedIndex, editForm.good);
                        listBox1.Items[listBox1.SelectedIndex] = editForm.good;
                    }
                }
            }
            else if (buttonControl?.Text == "Видалити")
            {
                Good good = listBox1.SelectedItem as Good;
                goodCollection.Remove(good);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
