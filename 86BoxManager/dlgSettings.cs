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

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _86boxManager
{
    public partial class dlgSettings : Form
    {
        private bool settingsChanged = false; //Keeps track of unsaved changes

        public dlgSettings()
        {
            InitializeComponent();
        }

        private void dlgSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
            Get86BoxVersion();

            lblVersion1.Text = Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);

            #if DEBUG
                lblVersion1.Text += " (Debug)";
            #endif
        }

        private void dlgSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Unsaved changes, ask the user to confirm
            if (settingsChanged == true)
            {
                e.Cancel = true;
                DialogResult result = MessageBox.Show("是否要保存对设置所做的更改?", "未保存的更改", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveSettings();
                }
                if (result != DialogResult.Cancel)
                {
                    e.Cancel = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            bool success = SaveSettings();
            if (!success)
            {
                return;
            }
            settingsChanged = CheckForChanges();
            btnApply.Enabled = settingsChanged;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (settingsChanged)
            {
                SaveSettings();
            }
            Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEXEdir.Text) || string.IsNullOrWhiteSpace(txtCFGdir.Text))
            {
                btnApply.Enabled = false;
            }
            else
            {
                settingsChanged = CheckForChanges();
                btnApply.Enabled = settingsChanged;
            }
        }

        //Obtains the 86Box version from 86Box.exe
        private void Get86BoxVersion()
        {
            try
            {
                FileVersionInfo vi = FileVersionInfo.GetVersionInfo(txtEXEdir.Text + @"\86Box.exe");
                if (vi.FilePrivatePart >= 3541) //Officially supported builds
                {
                    lbl86BoxVer1.Text = vi.FileMajorPart.ToString() + "." + vi.FileMinorPart.ToString() + "." + vi.FileBuildPart.ToString() + "." + vi.FilePrivatePart.ToString() + " - 完全兼容";
                    lbl86BoxVer1.ForeColor = Color.ForestGreen;
                }
                else if (vi.FilePrivatePart >= 3333 && vi.FilePrivatePart < 3541) //Should mostly work...
                {
                    lbl86BoxVer1.Text = vi.FileMajorPart.ToString() + "." + vi.FileMinorPart.ToString() + "." + vi.FileBuildPart.ToString() + "." + vi.FilePrivatePart.ToString() + " - 部分兼容";
                    lbl86BoxVer1.ForeColor = Color.Orange;
                }
                else //Completely unsupported, since version info can't be obtained anyway
                {
                    lbl86BoxVer1.Text = "未知 - 可能不兼容";
                    lbl86BoxVer1.ForeColor = Color.Red;
                }
            }
            catch(FileNotFoundException)
            {
                lbl86BoxVer1.Text = "找不到 86Box.exe ";
                lbl86BoxVer1.ForeColor = Color.Gray;
            }
        }
        
        //TODO: Rewrite
        //Save the settings to the registry
        private bool SaveSettings()
        {
            if (cbxLogging.Checked && string.IsNullOrWhiteSpace(txtLogPath.Text))
            {
                DialogResult result = MessageBox.Show("使用空字符串或空白字符串作为日志路径将阻止 86Box 记录任何内容,您确定要使用此路径吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            if (!File.Exists(txtEXEdir.Text + "86Box.exe") && !File.Exists(txtEXEdir.Text + @"\86Box.exe"))
            {
                DialogResult result = MessageBox.Show("在您指定的目录中找不到 86Box.exe ,因此您将无法使用任何虚拟机。您确定要使用此路径吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            try
            {
                RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\86Box", true); //Try to open the key first (in read-write mode) to see if it already exists
                if (regkey == null) //Regkey doesn't exist yet, must be created first and then reopened
                {
                    Registry.CurrentUser.CreateSubKey(@"SOFTWARE\86Box");
                    regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\86Box", true);
                    regkey.CreateSubKey("Virtual Machines");
                }

                //Store the new values, close the key, changes are saved
                regkey.SetValue("EXEdir", txtEXEdir.Text, RegistryValueKind.String);
                regkey.SetValue("CFGdir", txtCFGdir.Text, RegistryValueKind.String);
                regkey.SetValue("MinimizeOnVMStart", cbxMinimize.Checked, RegistryValueKind.DWord);
                regkey.SetValue("ShowConsole", cbxShowConsole.Checked, RegistryValueKind.DWord);
                regkey.SetValue("MinimizeToTray", cbxMinimizeTray.Checked, RegistryValueKind.DWord);
                regkey.SetValue("CloseToTray", cbxCloseTray.Checked, RegistryValueKind.DWord);
                regkey.SetValue("EnableLogging", cbxLogging.Checked, RegistryValueKind.DWord);
                regkey.SetValue("LogPath", txtLogPath.Text, RegistryValueKind.String);
                regkey.SetValue("EnableGridLines", cbxGrid.Checked, RegistryValueKind.DWord);
                regkey.Close();

                settingsChanged = CheckForChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生了一个错误,请向开发者提供以下信息:\n" + ex.Message + "\n" + ex.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Get86BoxVersion(); //Get the new exe version in any case
            }
            return true;
        }

        //TODO: Rewrite
        //Read the settings from the registry
        private void LoadSettings()
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\86Box", false); //Open the key as read only

                //If the key doesn't exist yet, fallback to defaults
                if (regkey == null)
                {
                    MessageBox.Show("86Box Manager设置无法加载。如果您是第一次运行 86Box Manager , 这是正常的, 将加载默认设置。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //Create the key and reopen it for write access
                    Registry.CurrentUser.CreateSubKey(@"SOFTWARE\86Box");
                    regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\86Box", true);
                    regkey.CreateSubKey("Virtual Machines");

                    txtCFGdir.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\86Box VMs\";
                    txtEXEdir.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\86Box\";
                    cbxMinimize.Checked = false;
                    cbxShowConsole.Checked = true;
                    cbxMinimizeTray.Checked = false;
                    cbxCloseTray.Checked = false;
                    cbxLogging.Checked = false;
                    txtLogPath.Text = "";
                    cbxGrid.Checked = false;
                    btnBrowse3.Enabled = false;
                    txtLogPath.Enabled = false;

                    SaveSettings(); //This will write the default values to the registry
                }
                else
                {
                    txtEXEdir.Text = regkey.GetValue("EXEdir").ToString();
                    txtCFGdir.Text = regkey.GetValue("CFGdir").ToString();
                    txtLogPath.Text = regkey.GetValue("LogPath").ToString();
                    cbxMinimize.Checked = Convert.ToBoolean(regkey.GetValue("MinimizeOnVMStart"));
                    cbxShowConsole.Checked = Convert.ToBoolean(regkey.GetValue("ShowConsole"));
                    cbxMinimizeTray.Checked = Convert.ToBoolean(regkey.GetValue("MinimizeToTray"));
                    cbxCloseTray.Checked = Convert.ToBoolean(regkey.GetValue("CloseToTray"));
                    cbxLogging.Checked = Convert.ToBoolean(regkey.GetValue("EnableLogging"));
                    cbxGrid.Checked = Convert.ToBoolean(regkey.GetValue("EnableGridLines"));
                    txtLogPath.Enabled = cbxLogging.Checked;
                    btnBrowse3.Enabled = cbxLogging.Checked;
                }

                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("86Box Manager设置无法加载。如果您是第一次运行 86Box Manager , 这是正常的, 将加载默认设置。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCFGdir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\86Box VMs";
                txtEXEdir.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\86Box";
                cbxMinimize.Checked = false;
                cbxShowConsole.Checked = true;
                cbxMinimizeTray.Checked = false;
                cbxCloseTray.Checked = false;
                cbxLogging.Checked = false;
                txtLogPath.Text = "";
                cbxGrid.Checked = false;
                txtLogPath.Enabled = false;
                btnBrowse3.Enabled = false;
            }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
                Title = "选择 86Box 程序文件和 roms 文件夹所在的文件夹"
            };

            if (dialog.Show(Handle))
            {
                txtEXEdir.Text  = dialog.FileName;
                if (!txtEXEdir.Text.EndsWith(@"\")) //Just in case
                {
                    txtEXEdir.Text += @"\";
                }
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
                Title = "选择虚拟机(配置、 BIOS 设置(nvr)文件夹等)所在的文件夹"
            };

            if (dialog.Show(Handle))
            {
                txtCFGdir.Text = dialog.FileName;
                if (!txtCFGdir.Text.EndsWith(@"\")) //Just in case
                {
                    txtCFGdir.Text += @"\";
                }
            }
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("所有设置都将重置为默认值,您想继续吗?", "设置将被重置", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ResetSettings();
            }
        }

        //Resets the settings to their default values
        private void ResetSettings()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\86Box", true);
            if (regkey == null)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\86Box");
                regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\86Box", true);
                regkey.CreateSubKey("Virtual Machines");
            }
            regkey.Close();

            txtCFGdir.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\86Box VMs\";
            txtEXEdir.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\86Box\";
            cbxMinimize.Checked = false;
            cbxShowConsole.Checked = true;
            cbxMinimizeTray.Checked = false;
            cbxCloseTray.Checked = false;
            cbxLogging.Checked = false;
            txtLogPath.Text = "";
            cbxGrid.Checked = false;
            txtLogPath.Enabled = false;
            btnBrowse3.Enabled = false;

            settingsChanged = CheckForChanges();
        }

        //Checks if all controls match the currently saved settings to determine if any changes were made
        private bool CheckForChanges()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\86Box");

            try
            {
                btnApply.Enabled = (
                    txtEXEdir.Text != regkey.GetValue("EXEdir").ToString() ||
                    txtCFGdir.Text != regkey.GetValue("CFGdir").ToString() ||
                    txtLogPath.Text != regkey.GetValue("LogPath").ToString() ||
                    cbxMinimize.Checked != Convert.ToBoolean(regkey.GetValue("MinimizeOnVMStart")) ||
                    cbxShowConsole.Checked != Convert.ToBoolean(regkey.GetValue("ShowConsole")) ||
                    cbxMinimizeTray.Checked != Convert.ToBoolean(regkey.GetValue("MinimizeToTray")) ||
                    cbxCloseTray.Checked != Convert.ToBoolean(regkey.GetValue("CloseToTray")) || 
                    cbxLogging.Checked != Convert.ToBoolean(regkey.GetValue("EnableLogging")) ||
                    cbxGrid.Checked != Convert.ToBoolean(regkey.GetValue("EnableGridLines")));

                return btnApply.Enabled;
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误: " + ex.Message);
                return true; //For now let's just return true if anything goes wrong
            }
            finally
            {
                regkey.Close();
            }
        }

        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            settingsChanged = CheckForChanges();
        }

        private void cbxLogging_CheckedChanged(object sender, EventArgs e)
        {
            settingsChanged = CheckForChanges();
            txt_TextChanged(sender, e); //Needed so the Apply button doesn't get enabled on an empty logpath textbox. Too lazy to write a duplicated empty check...
            txtLogPath.Enabled = cbxLogging.Checked;
            btnBrowse3.Enabled = cbxLogging.Checked;
        }

        private void btnBrowse3_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.DefaultExt = "log";
            ofd.Title = "选择一个将保存 86Box 日志的文件";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            ofd.Filter = "日志文件 (*.log)|*.log";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtLogPath.Text = ofd.FileName;
            }

            ofd.Dispose();
        }

        private void lnkGithub1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkGithub1.LinkVisited = true;
            Process.Start("https://github.com/Chenzhili1987/86BoxManager-CHS");
        }

        private void lnkGithub2_LinkClicked(object sender, EventArgs e)
        {
            lnkGithub2.LinkVisited = true;
            Process.Start("https://github.com/86Box/86BoxManager");
        }
    }
}