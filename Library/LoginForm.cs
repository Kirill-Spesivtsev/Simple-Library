using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        private readonly libraryEntities _db;

        public LoginForm()
        {
            InitializeComponent();
            _db = new libraryEntities();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            try 
            {
                var username = tbLogin.Text.Trim();
                var password = tbPassword.Text.Trim();
                var user = _db.users.FirstOrDefault(q => q.username == username && q.password == password);
                if (user == null)
                {
                    MessageBox.Show("Недействительные учетные данные");
                }
                else
                {
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так. Повторите ввод");
            }
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

