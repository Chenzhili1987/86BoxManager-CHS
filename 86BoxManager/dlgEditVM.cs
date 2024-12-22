/*
MIT License

Copyright (c) 2018-2022 David Simunič

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.IO;
using System.Windows.Forms;

namespace _86boxManager
{
    public partial class dlgEditVM : Form
    {
        private frmMain main = (frmMain)Application.OpenForms["frmMain"]; //Instance of frmMain
        private VM vm = null; //VM to be edited
        private string originalName; //Original name of the VM

        public dlgEditVM()
        {
            InitializeComponent();
        }

        private void dlgEditVM_Load(object sender, EventArgs e)
        {
            VMLoadData();
        }

        //Load the data for selected VM
        private void VMLoadData()
        {
            vm = (VM)main.lstVMs.FocusedItem.Tag;
            originalName = vm.Name;
            txtName.Text = vm.Name;
            txtDesc.Text = vm.Desc;
            lblPath1.Text = vm.Path;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Check if a VM with this name already exists
            if (!originalName.Equals(txtName.Text) && main.VMCheckIfExists(txtName.Text))
            {
                MessageBox.Show("具有此名称的虚拟机已存在。请选择其他名称。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("您指定的名称中有无效字符,您不能使用以下字符: \\ / : * ? \" < > |", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                main.VMEdit(txtName.Text, txtDesc.Text);
                Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Check for empty strings etc.
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                btnApply.Enabled = false;
            }
            else
            {
                btnApply.Enabled = true;
                lblPath1.Text = main.cfgpath + txtName.Text;
                tipLblPath1.SetToolTip(lblPath1, main.cfgpath + txtName.Text);
            }
        }
    }
}
