using HomeLandCost._02.DataAccess.Concrete;
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

namespace HomeLandCost
{
    public partial class Login : Form
    {
        private UserModelDb UserModelDb=new UserModelDb();
        private MainPage MainPage;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                MainPage = new MainPage();
                this.Hide();
                MainPage.Show();

            }
            else
            {
                MessageBox.Show("Password is wrong");
            }
        }
        private bool CheckLogin () {
            var data = UserModelDb.GetById(x => x.UserName == User.Text);
            if (data == null)
            {
                return false;
            }
            if (!VerifyPasswordHash(Password.Text, data.PasswordHash, data.PasswordSalt))
            {
                return false;
            }
            return true;
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
