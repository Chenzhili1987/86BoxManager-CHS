using System;
using System.IO;
using System.Windows.Forms;

namespace _86boxManager
{
    public partial class dlgCloneVM : Form
    {
        private string oldPath; //Path of the VM to be cloned
        private frmMain main = (frmMain)Application.OpenForms["frmMain"]; //Instance of frmMain

        public dlgCloneVM()
        {
            InitializeComponent();
        }

        public dlgCloneVM(string oldPath)
        {
            InitializeComponent();
            this.oldPath = oldPath;
        }

        private void dlgCloneVM_Load(object sender, EventArgs e)
        {
            lblPath1.Text = main.cfgpath;
            lblOldVM.Text = "虚拟机 \"" + Path.GetFileName(oldPath) + "\" 将被克隆到:";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                btnClone.Enabled = false;
                tipTxtName.Active = false;
            }
            else
            {
                if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    btnClone.Enabled = false;
                    lblPath1.Text = "路径无效";
                    tipTxtName.Active = true;
                    tipTxtName.Show("名称中不能使用以下字符: \\ / : * ? \" < > |", txtName, 20000);
                }
                else
                {
                    btnClone.Enabled = true;
                    lblPath1.Text = main.cfgpath + txtName.Text;
                    tipLblPath1.SetToolTip(lblPath1, main.cfgpath + txtName.Text);
                }
            }
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (main.VMCheckIfExists(txtName.Text))
            {
                MessageBox.Show("具有此名称的虚拟机已存在,请选择其他名称。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("您指定的名称中有无效字符,您不能使用以下字符: \\ / : * ? \" < > |", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Just import stuff from the existing VM
            main.VMImport(txtName.Text, txtDescription.Text, oldPath, cbxOpenCFG.Checked, cbxStartVM.Checked);
            Close();
        }

        private void lblOldVM_Click(object sender, EventArgs e)
        {

        }
    }
}
