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
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(LoginForm login)
        {
            InitializeComponent();
            _loginForm = login;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Close();
        }
    }
}
