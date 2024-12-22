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
    public partial class dlgAddVM : Form
    {
        private frmMain main = (frmMain)Application.OpenForms["frmMain"]; //Instance of frmMain
        private bool existingVM = false; //Is this importing an existing VM or not

        public dlgAddVM()
        {
            InitializeComponent();
        }

        //Check if VM with this name already exists, and send the data to the main form for processing if it doesn't
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (main.VMCheckIfExists(txtName.Text))
            {
                MessageBox.Show("具有此名称的虚拟机已存在,请选择其他名称的虚拟机。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }
            if (existingVM && string.IsNullOrWhiteSpace(txtImportPath.Text))
            {
                MessageBox.Show("如果要导入虚拟机文件，必须指定路径。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            if (existingVM)
            {
                main.VMImport(txtName.Text, txtDescription.Text, txtImportPath.Text, cbxOpenCFG.Checked, cbxStartVM.Checked);
            }
            else
            {
                //TrimEnd() needed to trim the trailing spaces, because they can cause problems with the VM folder in Windows...
                // 获取虚拟机目录路径，假设 main.cfgpath 是虚拟机目录的上级目录，这里进行拼接
                string VMDirectoryPath = Path.Combine(main.cfgpath, txtName.Text.TrimEnd());
                Directory.CreateDirectory(VMDirectoryPath);
                // 在虚拟机目录下创建指定文件名的文件
                string filePath = Path.Combine(VMDirectoryPath, "86box.cfg");
                File.WriteAllText(filePath, "[General]\r\nvid_renderer = qt_software\r\nemu_build_num = 6130\r\nlanguage = zh-CN\r\nopen_dir_usr_path = 1\r\n\r\n[Machine]\r\nmachine = ibmpc\r\ncpu_family = 8088\r\ncpu_speed = 4772728\r\ncpu_multi = 1\r\ncpu_use_dynarec = 0\r\nfpu_softfloat = 0\r\ntime_sync = local\r\nmem_size = 64\r\n\r\n[Video]\r\ngfxcard = cga\r\n\r\n[Input devices]\r\nmouse_type = none\r\n\r\n[Sound]\r\nfm_driver = nuked\r\n\r\n[Network]\r\nnet_01_link = 0\r\nnet_02_link = 0\r\nnet_03_link = 0\r\nnet_04_link = 0\r\n\r\n[Storage controllers]\r\nfdc = none\r\nhdc = none\r\ncassette_enabled = 1\r\ncassette_mode = load\r\n");
                main.VMAdd(txtName.Text.TrimEnd(), txtDescription.Text, cbxOpenCFG.Checked, cbxStartVM.Checked);
            }
            Close();
        }

        private void dlgAddVM_Load(object sender, EventArgs e)
        {
            lblPath1.Text = main.cfgpath;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                btnAdd.Enabled = false;
                tipTxtName.Active = false;
            }
            else
            {
                if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    btnAdd.Enabled = false;
                    lblPath1.Text = "路径无效";
                    tipTxtName.Active = true;
                    tipTxtName.Show("名称中不能使用以下字符： \\ / : * ? \" < > |", txtName, 20000);
                }
                else
                {
                    btnAdd.Enabled = true;
                    lblPath1.Text = main.cfgpath + txtName.Text;
                    tipLblPath1.SetToolTip(lblPath1, main.cfgpath + txtName.Text);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
                Title = "选择虚拟机(配置、 BIOS 设置(nvr)文件夹等)所在的文件夹"
            };

            if (dialog.Show(Handle))
            {
                txtImportPath.Text = dialog.FileName;
                txtName.Text = Path.GetFileName(dialog.FileName);
            }
        }
        private void cbxImport_CheckedChanged(object sender, EventArgs e)
        {
            existingVM = !existingVM;
            txtImportPath.Enabled = cbxImport.Checked;
            btnBrowse.Enabled = cbxImport.Checked;
        }
    }
}