using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRapPhim
{
    public partial class frmAdmin : Form
    {
        private Form currentChilForm;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void OpenChilForm(Form chilForm)
        {
            if(currentChilForm!=null)
            {
                currentChilForm.Close();
            }
            currentChilForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(chilForm);
            pnMain.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Rạp phim Skope", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            OpenChilForm(new frmFilm());
        }
    }
}
