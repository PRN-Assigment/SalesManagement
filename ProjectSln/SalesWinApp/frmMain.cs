using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SalesWinApp;
using BusinessObject.BusinessObject;
namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        TblMember loginMember = null;
        public frmMain(TblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelHoten.Text = "Tài khoản :" + loginMember.Email;
        }

        private void QLSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginMember.Email != "admin@fstore.com")
                {
                    throw new Exception("Bạn không có quyền admin");
                }
                Form frmproduct = new frmProduct(loginMember);
                frmproduct.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        private void QLTVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (loginMember.Email != "admin@fstore.com")
                {
                    throw new Exception("Bạn không có quyền admin");
                }
                Form frmproduct = new frmProduct(loginMember);
                frmproduct.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }
        private void QLHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmorder = new frmOrder(loginMember);
            frmorder.ShowDialog();
        }
    }
}
