using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRapPhim.Classes;

namespace QLRapPhim
{
    public partial class frmRegis : Form
    {
        DataProcess dataProcess = new DataProcess();
        public frmRegis()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "" || (rdoNam.Checked == false && rdoNu.Checked == false && rdoKhac.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đẩy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string gender;
                string type = "Staff";
                if (rdoNu.Checked == true) gender = "Nữ";
                else if (rdoNam.Checked == true) gender = "Nam";
                else gender = "Khác";
                if(txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string querry = "insert into tblAccount (Name,Gender,BirthDay,UserName,Password,Type_Account) values (N'"+ txtName.Text + "',N'" + gender + "','" + dtpBirthday.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','" + type + "')";
                    dataProcess.ChangeDatabase(querry);
                    if(MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }    
                }    
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Rạp phim Skope", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
