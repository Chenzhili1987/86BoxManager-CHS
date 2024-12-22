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
    partial class dlgAddVM
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
            this.cbxOpenCFG = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPath1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tipLblPath1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxStartVM = new System.Windows.Forms.CheckBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tipTxtName = new System.Windows.Forms.ToolTip(this.components);
            this.txtImportPath = new System.Windows.Forms.TextBox();
            this.cbxImport = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxOpenCFG
            // 
            this.cbxOpenCFG.AutoSize = true;
            this.cbxOpenCFG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxOpenCFG.Location = new System.Drawing.Point(352, 266);
            this.cbxOpenCFG.Name = "cbxOpenCFG";
            this.cbxOpenCFG.Size = new System.Drawing.Size(197, 33);
            this.cbxOpenCFG.TabIndex = 6;
            this.cbxOpenCFG.Text = "立即配置该虚拟机";
            this.cbxOpenCFG.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(762, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(658, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新建";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 28);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "名字:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(16, 170);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(56, 28);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "注释:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(144, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(714, 34);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(144, 165);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(714, 34);
            this.txtDescription.TabIndex = 4;
            // 
            // lblPath1
            // 
            this.lblPath1.AutoEllipsis = true;
            this.lblPath1.Location = new System.Drawing.Point(82, 219);
            this.lblPath1.MaximumSize = new System.Drawing.Size(644, 26);
            this.lblPath1.Name = "lblPath1";
            this.lblPath1.Size = new System.Drawing.Size(644, 26);
            this.lblPath1.TabIndex = 12;
            this.lblPath1.Text = "<路径在这里>";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(16, 219);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(56, 28);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "路径:";
            // 
            // cbxStartVM
            // 
            this.cbxStartVM.AutoSize = true;
            this.cbxStartVM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxStartVM.Location = new System.Drawing.Point(22, 266);
            this.cbxStartVM.Name = "cbxStartVM";
            this.cbxStartVM.Size = new System.Drawing.Size(197, 33);
            this.cbxStartVM.TabIndex = 5;
            this.cbxStartVM.Text = "立即启动该虚拟机";
            this.cbxStartVM.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 316);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(876, 78);
            this.pnlBottom.TabIndex = 15;
            // 
            // tipTxtName
            // 
            this.tipTxtName.Active = false;
            this.tipTxtName.AutomaticDelay = 0;
            this.tipTxtName.IsBalloon = true;
            this.tipTxtName.ShowAlways = true;
            this.tipTxtName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.tipTxtName.ToolTipTitle = "名称包含无效字符";
            // 
            // txtImportPath
            // 
            this.txtImportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImportPath.Enabled = false;
            this.txtImportPath.Location = new System.Drawing.Point(22, 60);
            this.txtImportPath.Name = "txtImportPath";
            this.txtImportPath.Size = new System.Drawing.Size(724, 34);
            this.txtImportPath.TabIndex = 1;
            // 
            // cbxImport
            // 
            this.cbxImport.AutoSize = true;
            this.cbxImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxImport.Location = new System.Drawing.Point(22, 18);
            this.cbxImport.Margin = new System.Windows.Forms.Padding(4);
            this.cbxImport.Name = "cbxImport";
            this.cbxImport.Size = new System.Drawing.Size(251, 33);
            this.cbxImport.TabIndex = 0;
            this.cbxImport.Text = "从以下位置导入虚拟机文件:";
            this.cbxImport.UseVisualStyleBackColor = true;
            this.cbxImport.CheckedChanged += new System.EventHandler(this.cbxImport_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Enabled = false;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Location = new System.Drawing.Point(754, 56);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 45);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dlgAddVM
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(876, 394);
            this.Controls.Add(this.txtImportPath);
            this.Controls.Add(this.cbxImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.cbxStartVM);
            this.Controls.Add(this.cbxOpenCFG);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblPath1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgAddVM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建一个虚拟机";
            this.Load += new System.EventHandler(this.dlgAddVM_Load);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxOpenCFG;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPath1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ToolTip tipLblPath1;
        private System.Windows.Forms.CheckBox cbxStartVM;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ToolTip tipTxtName;
        private System.Windows.Forms.TextBox txtImportPath;
        private System.Windows.Forms.CheckBox cbxImport;
        private System.Windows.Forms.Button btnBrowse;
    }
}