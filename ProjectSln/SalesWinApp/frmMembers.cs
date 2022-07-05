using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.BusinessObject;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        TblMember loginMember = null;
        private MemberRepository memberDAO = new MemberRepository();
        string function = null;
        public frmMember(TblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        public frmMember()
        {
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tài khoản :" + loginMember.Email;

            if (loginMember.Email == "admin@fstore.com")
            {

                loadMember();
                tool(false);
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;

            }
            else
            {
                loadLoginMember();

                tool(false);
                btnEdit.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
            }
        }

        public void loadLoginMember()
        {
            TblMember member = memberDAO.GetRowByID(loginMember.MemberId);
            txtMemberId.Text = member.MemberId.ToString();
            txtEmail.Text = member.Email;
            txtPassword.Text = member.Password;
            txtCompanyName.Text = member.CompanyName;
            txtCity.Text = member.City;
            txtCountry.Text = member.Country;

        }


        private void loadMemberLogin()
        {
            
            TblMember member = memberDAO.GetRowByID(loginMember.MemberId);
            dgvMember.DataSource = memberDAO.GetList(member);

        }
        private void loadMember()
        {
            dgvMember.DataSource = memberDAO.GetList();

        }

        private void tool(Boolean check)
        {
            txtMemberId.Enabled = check;
            txtPassword.Enabled = check;
            txtEmail.Enabled = check;
            txtCompanyName.Enabled = check;
            txtCity.Enabled = check;
            txtCountry.Enabled = check;
        }
        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex < 0 || rowindex >= dgvMember.Rows.Count)
                {
                    throw new Exception("Chưa chọn đúng thông tin");
                }
                txtMemberId.Text = dgvMember.Rows[rowindex].Cells["MemberId"].Value.ToString();
                txtPassword.Text = dgvMember.Rows[rowindex].Cells["Password"].Value.ToString();
                txtEmail.Text = dgvMember.Rows[rowindex].Cells["Email"].Value.ToString();
                txtCompanyName.Text = dgvMember.Rows[rowindex].Cells["CompanyName"].Value.ToString();
                txtCity.Text = dgvMember.Rows[rowindex].Cells["City"].Value.ToString();
                txtCountry.Text = dgvMember.Rows[rowindex].Cells["Country"].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void clear()
        {
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text= string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tool(true);
            clear();
            btnSave.Enabled = true;
            txtMemberId.Text = "Auto Generated";
            txtMemberId.ReadOnly = true;
            function = "Add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tool(true);
            btnSave.Enabled = true;
            txtMemberId.Enabled = false;
            txtEmail.Enabled = false;
            function = "Edit";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (loginMember.Email == "admin@fstore.com")
            {
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                try
                {
                    if (loginMember.Email == txtEmail.Text.Trim())
                    {
                        throw new Exception("Không thể Edit Admin.");
                    }
                    if (!emailRegex.IsMatch(txtEmail.Text.Trim()))
                    {
                        throw new Exception("Email phải khớp với mẫu example@example.com");
                    }
                    TblMember member = new TblMember();
                    try
                    {
                        member.MemberId = int.Parse(txtMemberId.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        member.MemberId = 0;
                    }

                    member.Password = txtPassword.Text.Trim();
                    member.Email = txtEmail.Text.Trim();
                    member.CompanyName = txtCompanyName.Text.Trim();
                    member.City = txtCity.Text.Trim();
                    member.Country = txtCountry.Text.Trim();

                    switch (function)
                    {
                        case "Add":
                            {
                                if (memberDAO.getRow(txtEmail.Text) != null)
                                {
                                    throw new Exception("Duplicate Email!");
                                }
                                memberDAO.Insert(member);
                                loadMember();
                                MessageBox.Show("Thêm thành công", "Thông báo");
                                break;
                            }
                        case "Edit":
                            {

                                memberDAO.Update(member);
                                loadMember();
                                MessageBox.Show("Sửa thành công", "Thông báo");
                                break;
                            }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }
            else
            {
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                try
                {
                    if (!emailRegex.IsMatch(txtEmail.Text.Trim()))
                    {
                        throw new Exception("Email phải khớp với mẫu example@example.com");
                    }
                    TblMember member = new TblMember();
                    try
                    {
                        member.MemberId = int.Parse(txtMemberId.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        member.MemberId = 0;
                    }

                    member.Password = txtPassword.Text.Trim();
                    member.Email = txtEmail.Text.Trim();
                    member.CompanyName = txtCompanyName.Text.Trim();
                    member.City = txtCity.Text.Trim();
                    member.Country = txtCountry.Text.Trim();

                    switch (function)
                    {
                        case "Add":
                            {
                                if (memberDAO.getRow(txtEmail.Text) != null)
                                {
                                    throw new Exception("Duplicate Email!");
                                }
                                memberDAO.Insert(member);

                                MessageBox.Show("Thêm thành công", "Thông báo");
                                break;
                            }
                        case "Edit":
                            {

                                memberDAO.Update(member);

                                MessageBox.Show("Sửa thành công", "Thông báo");
                                break;
                            }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (loginMember.Email != "admin@fstore.com")
                    {
                        throw new Exception("Bạn không có quyền admin");
                    }

                
                int memberId = int.Parse(txtMemberId.Text.Trim());

                TblMember member = memberDAO.GetRowByID(memberId);
                if (member.Email == loginMember.Email)
                {
                    throw new Exception("Không thể xóa Admin");
                }

                memberDAO.Delete(member);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvMember.DataSource = memberDAO.GetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }
    }
}
