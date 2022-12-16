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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Login = Convert.ToString(LoginBox.Text);
            string Password = Convert.ToString(PasswordBox.Text);

            if (Login == "" | Password == "")
            {
                label1.Visible = true;
                label1.Text = "Введите данные";
            };

            if (Login == "admin" | Password == "admin")
            {
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.ChangeButton.Visible = true;
                mainPage.SaveButton.Visible = true;
                mainPage.DeleteButton.Visible = true;
                mainPage.AddButton.Visible = true;
                mainPage.LableLogout.Text = Login;
                mainPage.ShowDialog();
            }
            else if (Login != "" & Password != "")
            {
                this.Hide();
                MainPage mainPageUser = new MainPage();
                mainPageUser.LableLogout.Text = Login;
                mainPageUser.ShowDialog();
            };

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string Login = Convert.ToString(LoginBox.Text);
            string Password = Convert.ToString(PasswordBox.Text);

            if (Login == "" | Password == "")
            {
                label1.Visible = true;
                label1.Text = "Введите данные";
            };

            if (Login == "admin" | Password == "admin")
            {
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.ChangeButton.Visible = true;
                mainPage.SaveButton.Visible = true;
                mainPage.DeleteButton.Visible = true;
                mainPage.AddButton.Visible = true;
                mainPage.LableLogout.Text = Login;
                mainPage.ShowDialog();
            }
            else if (Login != "" & Password != "")
            {
                this.Hide();
                MainPage mainPageUser = new MainPage();
                mainPageUser.LableLogout.Text = Login;
                mainPageUser.ShowDialog();
            };


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.ShowDialog();
        }
    }
}
