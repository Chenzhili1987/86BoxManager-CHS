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

namespace _86boxManager
{
    partial class dlgSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSettings));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxShowConsole = new System.Windows.Forms.CheckBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gbxBehaviour = new System.Windows.Forms.GroupBox();
            this.cbxMinimizeTray = new System.Windows.Forms.CheckBox();
            this.cbxCloseTray = new System.Windows.Forms.CheckBox();
            this.cbxMinimize = new System.Windows.Forms.CheckBox();
            this.CopyrightD = new System.Windows.Forms.GroupBox();
            this.lbl86BoxVer1 = new System.Windows.Forms.Label();
            this.lbl86BoxVer = new System.Windows.Forms.Label();
            this.lblCFGdir = new System.Windows.Forms.Label();
            this.txtCFGdir = new System.Windows.Forms.TextBox();
            this.txtEXEdir = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lblEXEdir = new System.Windows.Forms.Label();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.gbxLogging = new System.Windows.Forms.GroupBox();
            this.cbxLogging = new System.Windows.Forms.CheckBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.gbxMisc = new System.Windows.Forms.GroupBox();
            this.cbxGrid = new System.Windows.Forms.CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lnkGithub1 = new System.Windows.Forms.LinkLabel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblVersion1 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabDaviunic = new System.Windows.Forms.TabPage();
            this.MIT_License_Copyright = new System.Windows.Forms.TextBox();
            this.lnkGithub2 = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gbxBehaviour.SuspendLayout();
            this.CopyrightD.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.gbxLogging.SuspendLayout();
            this.gbxMisc.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.tabDaviunic.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Location = new System.Drawing.Point(949, 17);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(97, 46);
            this.btnApply.TabIndex = 17;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(846, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 46);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(743, 17);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 46);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxShowConsole
            // 
            this.cbxShowConsole.AutoSize = true;
            this.cbxShowConsole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxShowConsole.Location = new System.Drawing.Point(427, 35);
            this.cbxShowConsole.Margin = new System.Windows.Forms.Padding(2);
            this.cbxShowConsole.Name = "cbxShowConsole";
            this.cbxShowConsole.Size = new System.Drawing.Size(254, 33);
            this.cbxShowConsole.TabIndex = 13;
            this.cbxShowConsole.Text = "启用 86Box 控制台窗口";
            this.cbxShowConsole.UseVisualStyleBackColor = true;
            this.cbxShowConsole.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDefaults.Location = new System.Drawing.Point(17, 17);
            this.btnDefaults.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(97, 46);
            this.btnDefaults.TabIndex = 14;
            this.btnDefaults.Text = "默认设置";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Controls.Add(this.btnDefaults);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 426);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1063, 78);
            this.pnlBottom.TabIndex = 14;
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tabGeneral);
            this.tbcSettings.Controls.Add(this.tabAdvanced);
            this.tbcSettings.Controls.Add(this.tabAbout);
            this.tbcSettings.Controls.Add(this.tabDaviunic);
            this.tbcSettings.Location = new System.Drawing.Point(18, 18);
            this.tbcSettings.Margin = new System.Windows.Forms.Padding(5);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(1033, 395);
            this.tbcSettings.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.gbxBehaviour);
            this.tabGeneral.Controls.Add(this.CopyrightD);
            this.tabGeneral.Location = new System.Drawing.Point(4, 37);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(5);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(5);
            this.tabGeneral.Size = new System.Drawing.Size(1025, 354);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "常规";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // gbxBehaviour
            // 
            this.gbxBehaviour.Controls.Add(this.cbxMinimizeTray);
            this.gbxBehaviour.Controls.Add(this.cbxCloseTray);
            this.gbxBehaviour.Controls.Add(this.cbxMinimize);
            this.gbxBehaviour.Location = new System.Drawing.Point(10, 211);
            this.gbxBehaviour.Margin = new System.Windows.Forms.Padding(5);
            this.gbxBehaviour.Name = "gbxBehaviour";
            this.gbxBehaviour.Padding = new System.Windows.Forms.Padding(5);
            this.gbxBehaviour.Size = new System.Drawing.Size(1003, 130);
            this.gbxBehaviour.TabIndex = 6;
            this.gbxBehaviour.TabStop = false;
            this.gbxBehaviour.Text = "启动虚拟机时";
            // 
            // cbxMinimizeTray
            // 
            this.cbxMinimizeTray.AutoSize = true;
            this.cbxMinimizeTray.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMinimizeTray.Location = new System.Drawing.Point(13, 35);
            this.cbxMinimizeTray.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMinimizeTray.Name = "cbxMinimizeTray";
            this.cbxMinimizeTray.Size = new System.Drawing.Size(377, 33);
            this.cbxMinimizeTray.TabIndex = 5;
            this.cbxMinimizeTray.Text = "将 86Box Manager 最小化到系统托盘";
            this.cbxMinimizeTray.UseVisualStyleBackColor = true;
            this.cbxMinimizeTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxCloseTray
            // 
            this.cbxCloseTray.AutoSize = true;
            this.cbxCloseTray.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCloseTray.Location = new System.Drawing.Point(505, 35);
            this.cbxCloseTray.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCloseTray.Name = "cbxCloseTray";
            this.cbxCloseTray.Size = new System.Drawing.Size(317, 33);
            this.cbxCloseTray.TabIndex = 6;
            this.cbxCloseTray.Text = "隐藏 86Box Manager 托盘图标";
            this.cbxCloseTray.UseVisualStyleBackColor = true;
            this.cbxCloseTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxMinimize
            // 
            this.cbxMinimize.AutoSize = true;
            this.cbxMinimize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMinimize.Location = new System.Drawing.Point(13, 77);
            this.cbxMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMinimize.Name = "cbxMinimize";
            this.cbxMinimize.Size = new System.Drawing.Size(372, 33);
            this.cbxMinimize.TabIndex = 7;
            this.cbxMinimize.Text = "启动虚拟机时最小化 86Box Manager";
            this.cbxMinimize.UseVisualStyleBackColor = true;
            this.cbxMinimize.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // CopyrightD
            // 
            this.CopyrightD.Controls.Add(this.lbl86BoxVer1);
            this.CopyrightD.Controls.Add(this.lbl86BoxVer);
            this.CopyrightD.Controls.Add(this.lblCFGdir);
            this.CopyrightD.Controls.Add(this.txtCFGdir);
            this.CopyrightD.Controls.Add(this.txtEXEdir);
            this.CopyrightD.Controls.Add(this.btnBrowse2);
            this.CopyrightD.Controls.Add(this.lblEXEdir);
            this.CopyrightD.Controls.Add(this.btnBrowse1);
            this.CopyrightD.Location = new System.Drawing.Point(10, 10);
            this.CopyrightD.Margin = new System.Windows.Forms.Padding(5);
            this.CopyrightD.Name = "CopyrightD";
            this.CopyrightD.Padding = new System.Windows.Forms.Padding(5);
            this.CopyrightD.Size = new System.Drawing.Size(1003, 193);
            this.CopyrightD.TabIndex = 5;
            this.CopyrightD.TabStop = false;
            // 
            // lbl86BoxVer1
            // 
            this.lbl86BoxVer1.AutoSize = true;
            this.lbl86BoxVer1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl86BoxVer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl86BoxVer1.Location = new System.Drawing.Point(150, 89);
            this.lbl86BoxVer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl86BoxVer1.Name = "lbl86BoxVer1";
            this.lbl86BoxVer1.Size = new System.Drawing.Size(180, 28);
            this.lbl86BoxVer1.TabIndex = 6;
            this.lbl86BoxVer1.Text = "<状态显示在这里>";
            // 
            // lbl86BoxVer
            // 
            this.lbl86BoxVer.AutoSize = true;
            this.lbl86BoxVer.Location = new System.Drawing.Point(7, 89);
            this.lbl86BoxVer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl86BoxVer.Name = "lbl86BoxVer";
            this.lbl86BoxVer.Size = new System.Drawing.Size(115, 28);
            this.lbl86BoxVer.TabIndex = 5;
            this.lbl86BoxVer.Text = "86Box 版本:";
            // 
            // lblCFGdir
            // 
            this.lblCFGdir.AutoSize = true;
            this.lblCFGdir.Location = new System.Drawing.Point(7, 139);
            this.lblCFGdir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCFGdir.Name = "lblCFGdir";
            this.lblCFGdir.Size = new System.Drawing.Size(116, 28);
            this.lblCFGdir.TabIndex = 4;
            this.lblCFGdir.Text = "虚拟机路径:";
            // 
            // txtCFGdir
            // 
            this.txtCFGdir.Location = new System.Drawing.Point(139, 134);
            this.txtCFGdir.Margin = new System.Windows.Forms.Padding(2);
            this.txtCFGdir.Name = "txtCFGdir";
            this.txtCFGdir.Size = new System.Drawing.Size(743, 34);
            this.txtCFGdir.TabIndex = 3;
            this.txtCFGdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtEXEdir
            // 
            this.txtEXEdir.Location = new System.Drawing.Point(139, 35);
            this.txtEXEdir.Margin = new System.Windows.Forms.Padding(2);
            this.txtEXEdir.Name = "txtEXEdir";
            this.txtEXEdir.Size = new System.Drawing.Size(743, 34);
            this.txtEXEdir.TabIndex = 1;
            this.txtEXEdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse2.Location = new System.Drawing.Point(890, 131);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(106, 46);
            this.btnBrowse2.TabIndex = 4;
            this.btnBrowse2.Text = "浏览...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // lblEXEdir
            // 
            this.lblEXEdir.AutoSize = true;
            this.lblEXEdir.Location = new System.Drawing.Point(7, 38);
            this.lblEXEdir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEXEdir.Name = "lblEXEdir";
            this.lblEXEdir.Size = new System.Drawing.Size(115, 28);
            this.lblEXEdir.TabIndex = 3;
            this.lblEXEdir.Text = "86Box 路径:";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBrowse1.Location = new System.Drawing.Point(890, 30);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(106, 46);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "浏览...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.gbxLogging);
            this.tabAdvanced.Controls.Add(this.gbxMisc);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 37);
            this.tabAdvanced.Margin = new System.Windows.Forms.Padding(5);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(5);
            this.tabAdvanced.Size = new System.Drawing.Size(1025, 354);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "高级";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // gbxLogging
            // 
            this.gbxLogging.Controls.Add(this.cbxLogging);
            this.gbxLogging.Controls.Add(this.txtLogPath);
            this.gbxLogging.Controls.Add(this.btnBrowse3);
            this.gbxLogging.Location = new System.Drawing.Point(10, 10);
            this.gbxLogging.Margin = new System.Windows.Forms.Padding(5);
            this.gbxLogging.Name = "gbxLogging";
            this.gbxLogging.Padding = new System.Windows.Forms.Padding(5);
            this.gbxLogging.Size = new System.Drawing.Size(1003, 139);
            this.gbxLogging.TabIndex = 18;
            this.gbxLogging.TabStop = false;
            this.gbxLogging.Text = "日志";
            // 
            // cbxLogging
            // 
            this.cbxLogging.AutoSize = true;
            this.cbxLogging.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxLogging.Location = new System.Drawing.Point(13, 35);
            this.cbxLogging.Margin = new System.Windows.Forms.Padding(2);
            this.cbxLogging.Name = "cbxLogging";
            this.cbxLogging.Size = new System.Drawing.Size(319, 33);
            this.cbxLogging.TabIndex = 9;
            this.cbxLogging.Text = "启用保存为文件的 86box 日志:";
            this.cbxLogging.UseVisualStyleBackColor = true;
            this.cbxLogging.CheckedChanged += new System.EventHandler(this.cbxLogging_CheckedChanged);
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(13, 78);
            this.txtLogPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(868, 34);
            this.txtLogPath.TabIndex = 10;
            this.txtLogPath.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse3.Location = new System.Drawing.Point(890, 73);
            this.btnBrowse3.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(106, 46);
            this.btnBrowse3.TabIndex = 11;
            this.btnBrowse3.Text = "浏览...";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // gbxMisc
            // 
            this.gbxMisc.Controls.Add(this.cbxGrid);
            this.gbxMisc.Controls.Add(this.cbxShowConsole);
            this.gbxMisc.Location = new System.Drawing.Point(10, 157);
            this.gbxMisc.Margin = new System.Windows.Forms.Padding(5);
            this.gbxMisc.Name = "gbxMisc";
            this.gbxMisc.Padding = new System.Windows.Forms.Padding(5);
            this.gbxMisc.Size = new System.Drawing.Size(1003, 85);
            this.gbxMisc.TabIndex = 17;
            this.gbxMisc.TabStop = false;
            this.gbxMisc.Text = "其它";
            // 
            // cbxGrid
            // 
            this.cbxGrid.AutoSize = true;
            this.cbxGrid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxGrid.Location = new System.Drawing.Point(13, 35);
            this.cbxGrid.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGrid.Name = "cbxGrid";
            this.cbxGrid.Size = new System.Drawing.Size(330, 33);
            this.cbxGrid.TabIndex = 12;
            this.cbxGrid.Text = "在虚拟机显示列表中显示网格线";
            this.cbxGrid.UseVisualStyleBackColor = true;
            this.cbxGrid.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lnkGithub1);
            this.tabAbout.Controls.Add(this.imgLogo);
            this.tabAbout.Controls.Add(this.lblVersion1);
            this.tabAbout.Controls.Add(this.lblCopyright);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.lblDesc);
            this.tabAbout.Controls.Add(this.lblTitle);
            this.tabAbout.Location = new System.Drawing.Point(4, 37);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(5);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(5);
            this.tabAbout.Size = new System.Drawing.Size(1025, 354);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "关于";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lnkGithub1
            // 
            this.lnkGithub1.AutoSize = true;
            this.lnkGithub1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkGithub1.Location = new System.Drawing.Point(23, 257);
            this.lnkGithub1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkGithub1.Name = "lnkGithub1";
            this.lnkGithub1.Size = new System.Drawing.Size(493, 28);
            this.lnkGithub1.TabIndex = 12;
            this.lnkGithub1.TabStop = true;
            this.lnkGithub1.Text = "https://github.com/Chenzhili1987/86BoxManager-CHS";
            this.lnkGithub1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub1_LinkClicked);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(28, 23);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(58, 58);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 17;
            this.imgLogo.TabStop = false;
            // 
            // lblVersion1
            // 
            this.lblVersion1.AutoSize = true;
            this.lblVersion1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVersion1.Location = new System.Drawing.Point(77, 125);
            this.lblVersion1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVersion1.Name = "lblVersion1";
            this.lblVersion1.Size = new System.Drawing.Size(140, 28);
            this.lblVersion1.TabIndex = 16;
            this.lblVersion1.Text = "<版本在这里>";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCopyright.Location = new System.Drawing.Point(23, 167);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(492, 84);
            this.lblCopyright.TabIndex = 15;
            this.lblCopyright.Text = "Copyright © 2024 Chenzhili1987\r\n根据麻省理工学院许可证获得许可。请参阅许可证文件\r\n许可证信息和作者列表。";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVersion.Location = new System.Drawing.Point(23, 125);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(56, 28);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "版本:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDesc.Location = new System.Drawing.Point(23, 83);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(196, 28);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = " 86Box 的配置管理器";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(95, 29);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 41);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "86Box Manager";
            // 
            // tabDaviunic
            // 
            this.tabDaviunic.Controls.Add(this.MIT_License_Copyright);
            this.tabDaviunic.Controls.Add(this.lnkGithub2);
            this.tabDaviunic.Location = new System.Drawing.Point(4, 37);
            this.tabDaviunic.Name = "tabDaviunic";
            this.tabDaviunic.Size = new System.Drawing.Size(1025, 354);
            this.tabDaviunic.TabIndex = 3;
            this.tabDaviunic.Text = "原MIT许可和版权";
            this.tabDaviunic.UseVisualStyleBackColor = true;
            // 
            // MIT_License_Copyright
            // 
            this.MIT_License_Copyright.BackColor = System.Drawing.SystemColors.Window;
            this.MIT_License_Copyright.Location = new System.Drawing.Point(0, 3);
            this.MIT_License_Copyright.Multiline = true;
            this.MIT_License_Copyright.Name = "MIT_License_Copyright";
            this.MIT_License_Copyright.ReadOnly = true;
            this.MIT_License_Copyright.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MIT_License_Copyright.Size = new System.Drawing.Size(1022, 320);
            this.MIT_License_Copyright.TabIndex = 18;
            this.MIT_License_Copyright.Text = resources.GetString("MIT_License_Copyright.Text");
            this.MIT_License_Copyright.WordWrap = false;
            // 
            // lnkGithub2
            // 
            this.lnkGithub2.AutoSize = true;
            this.lnkGithub2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkGithub2.Location = new System.Drawing.Point(-2, 326);
            this.lnkGithub2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkGithub2.Name = "lnkGithub2";
            this.lnkGithub2.Size = new System.Drawing.Size(379, 28);
            this.lnkGithub2.TabIndex = 17;
            this.lnkGithub2.TabStop = true;
            this.lnkGithub2.Text = "https://github.com/86Box/86BoxManager";
            this.lnkGithub2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub2_LinkClicked);
            // 
            // dlgSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1063, 504);
            this.Controls.Add(this.tbcSettings);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgSettings_FormClosing);
            this.Load += new System.EventHandler(this.dlgSettings_Load);
            this.pnlBottom.ResumeLayout(false);
            this.tbcSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.gbxBehaviour.ResumeLayout(false);
            this.gbxBehaviour.PerformLayout();
            this.CopyrightD.ResumeLayout(false);
            this.CopyrightD.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.gbxLogging.ResumeLayout(false);
            this.gbxLogging.PerformLayout();
            this.gbxMisc.ResumeLayout(false);
            this.gbxMisc.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.tabDaviunic.ResumeLayout(false);
            this.tabDaviunic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbxShowConsole;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox gbxBehaviour;
        private System.Windows.Forms.CheckBox cbxMinimizeTray;
        private System.Windows.Forms.CheckBox cbxCloseTray;
        private System.Windows.Forms.CheckBox cbxMinimize;
        private System.Windows.Forms.GroupBox CopyrightD;
        private System.Windows.Forms.Label lblCFGdir;
        private System.Windows.Forms.TextBox txtCFGdir;
        private System.Windows.Forms.TextBox txtEXEdir;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lblEXEdir;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.Label lbl86BoxVer1;
        private System.Windows.Forms.Label lbl86BoxVer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbxMisc;
        private System.Windows.Forms.CheckBox cbxLogging;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.CheckBox cbxGrid;
        private System.Windows.Forms.GroupBox gbxLogging;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.LinkLabel lnkGithub1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblVersion1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabDaviunic;
        private System.Windows.Forms.LinkLabel lnkGithub2;
        private System.Windows.Forms.TextBox MIT_License_Copyright;
    }
}