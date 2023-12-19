using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonAndTextBox
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void lb_user_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUser.Text;
            string password = txbPassword.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Do you want to Login?", "Login Confirm",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                lb_user.Text = "สวัสดีครับ: " + txbUser.Text;
                txbUser.Text = "";
                txbPassword.Text = "";
                string path = @"C:\Users\User\source\repos\ButtonAndTextBox\ButtonAndTextBox\log_info.txt";
                using (StreamWriter writer = new StreamWriter(path,true))
                {
                    writer.WriteLine(DateTime.Now + " Username: " + username + " Password: " + password);
                }
                MessageBox.Show("เราได้บันทึกการเข้าใช้งานของคุณแล้ว", "Save To Logger",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txbUser.Text = String.Empty;
            txbPassword.Text = string.Empty;
            lb_user.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resultbtn = MessageBox.Show("Are You Sure?", "Exit!!!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultbtn == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
