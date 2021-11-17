using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        private readonly libraryDB _db;

        public LoginForm()
        {
            InitializeComponent();
            _db = new libraryDB();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            //try 
            //{
                SHA256 sha = SHA256.Create();

                var username = tbLogin.Text.Trim();
                var password = tbPassword.Text;

                byte[] passBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder passSB = new StringBuilder();
                foreach (byte i in passBytes) 
                {
                    passSB.Append(i.ToString("x2"));
                }
                var passHash = passSB.ToString();
                var user = _db.users.FirstOrDefault(q => q.username == username && q.password == passHash);
                if (user == null)
                {
                    MessageBox.Show("Недействительные учетные данные");
                }
                else
                {
                    var mainForm = new MainForm(this);
                    mainForm.Show();
                    Hide();
                }

            //}
            /*
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так. Повторите ввод");
            }*/
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

