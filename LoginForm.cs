namespace WinMultiwindow
{
    public partial class LoginForm : Form
    {
        string username = "";
        string password = "admin";
        public LoginForm()
        {
            InitializeComponent();
        }

        public void ErrorForm()
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "admin" && password == tbPassword.Text)
            {
                this.Visible = false;
                MessageBox.Show("³����, " + tbLogin.Text + "!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeForm homeForm = new HomeForm(this);
                var result = homeForm.ShowDialog();
                if (DialogResult.Cancel == result)
                {
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("������� �������� �����!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbLogin.Text == "Librari" && password == tbPassword.Text)
            {
                this.Visible = false;
                MessageBox.Show("³����, " + tbLogin.Text + "!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeForm homeForm = new HomeForm(this);
                var result = homeForm.ShowDialog();
                if (DialogResult.Cancel == result)
                {
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("������� �������� �����!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tbLogin.Text == "User" && password == tbPassword.Text)
            {
                this.Visible = false;
                MessageBox.Show("³����, " + tbLogin.Text + "!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeForm homeForm = new HomeForm(this);
                var result = homeForm.ShowDialog();
                if (DialogResult.Cancel == result)
                {
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("������� �������� �����!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("������� ���� ��� ������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}