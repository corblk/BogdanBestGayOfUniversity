using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogdanAndAlex_GuitarShop_
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Login = Convert.ToString(this.LoginBox.Text);
            string Password = Convert.ToString(PasswordBox.Text);
            string ConfirmPassword = Convert.ToString(ConfirmPasswordBox.Text);
            bool ConfirmIsSuccess = Password == ConfirmPassword;

            if (Login == "" | Password == "" | ConfirmPassword == "")
            {
                label4.Visible = true;
                label4.Text = "Введите данные";
            };

            if (ConfirmIsSuccess == false)
            {
                label4.Visible = true;
                label4.Text = "Пороли не совпадают!";
            };

            if (Login != "" & Password != "" & ConfirmPassword != "" & ConfirmIsSuccess == true)
            {
                this.Hide();
                Form1 confirm = new Form1();
                confirm.ShowDialog();
            };


        }
    }
}
