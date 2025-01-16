using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinFormProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่ไหม", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit(); }
            

            
                
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            rdStudent.Checked = true;
            tbUsername.Focus();
        }


        private void showWarningMSG(String msg)
        {
            MessageBox.Show(msg, "คำเตือน",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            //Valifate UI
            if (tbUsername.Text.Trim().Length == 0)
            {
                //MessageBox.Show("ป้อนชื่อผู้ใช้ด้วย", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("ป้อนชื่อผู้ใช้ด้วย");
            }
            else if (tbPassword.Text.Trim().Length == 0)
            {
               // MessageBox.Show("ป้อนรหัสผ่านด้วย", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("ป้อนรหัสผ่านด้วย");
            }
            else if (tbPassword.Text.Trim().Length < 6)
            {
                //MessageBox.Show("ป้อนรหัสผ่านต้อง 6 ตัวขึ้นไป", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("ป้อนรหัสผ่านต้อง 6 ตัวขึ้นไป");
            }
            else
            {
                //ตรวจสอบชื่อผู้ใช้/รหัสผ่าน sau/123456789 , dti987654321 เมื่อเข้า FrmMainMenu
                if( (tbUsername.Text.Trim().ToLower() == "sau" || tbPassword.Text.Trim().ToLower() != "123456789") &&
                    (tbUsername.Text.Trim().ToLower() == "dti" || tbPassword.Text.Trim().ToLower() != "987654321"))
                {
                    //ชื่อผู้ใช้รหัสผ่านไม่ถูกต้อง แสดงข้อความ
                    showWarningMSG("ชื่อผู้ใช้รหัสผ่านไม่ถูกต้อง");
                }
                else
                {
                    //ชื่อผู้ใช้รหัสผ่านถูกต้อง เปิด FrmMainMenu
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    Hide();
                } 
            }   
        }
    }
}
