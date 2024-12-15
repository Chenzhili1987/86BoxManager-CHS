namespace _86boxManager
{
    partial class dlgCloneVM
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
            this.lblPath = new System.Windows.Forms.Label();
            this.lblPath1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.cbxStartVM = new System.Windows.Forms.CheckBox();
            this.cbxOpenCFG = new System.Windows.Forms.CheckBox();
            this.lblOldVM = new System.Windows.Forms.Label();
            this.tipLblPath1 = new System.Windows.Forms.ToolTip(this.components);
            this.tipTxtName = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(16, 178);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(56, 28);
            this.lblPath.TabIndex = 19;
            this.lblPath.Text = "路径:";
            // 
            // lblPath1
            // 
            this.lblPath1.AutoEllipsis = true;
            this.lblPath1.Location = new System.Drawing.Point(82, 178);
            this.lblPath1.MaximumSize = new System.Drawing.Size(644, 26);
            this.lblPath1.Name = "lblPath1";
            this.lblPath1.Size = new System.Drawing.Size(644, 26);
            this.lblPath1.TabIndex = 18;
            this.lblPath1.Text = "<路径在这里>";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(144, 124);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(714, 34);
            this.txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(144, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(714, 34);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(16, 129);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(56, 28);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "注释:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 28);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "名字:";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnClone);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 282);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(876, 78);
            this.pnlBottom.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(762, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClone
            // 
            this.btnClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClone.Enabled = false;
            this.btnClone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClone.Location = new System.Drawing.Point(658, 16);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(98, 45);
            this.btnClone.TabIndex = 4;
            this.btnClone.Text = "克隆";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // cbxStartVM
            // 
            this.cbxStartVM.AutoSize = true;
            this.cbxStartVM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxStartVM.Location = new System.Drawing.Point(22, 225);
            this.cbxStartVM.Name = "cbxStartVM";
            this.cbxStartVM.Size = new System.Drawing.Size(210, 33);
            this.cbxStartVM.TabIndex = 2;
            this.cbxStartVM.Text = "立即启动该虚拟机";
            this.cbxStartVM.UseVisualStyleBackColor = true;
            // 
            // cbxOpenCFG
            // 
            this.cbxOpenCFG.AutoSize = true;
            this.cbxOpenCFG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxOpenCFG.Location = new System.Drawing.Point(352, 225);
            this.cbxOpenCFG.Name = "cbxOpenCFG";
            this.cbxOpenCFG.Size = new System.Drawing.Size(210, 33);
            this.cbxOpenCFG.TabIndex = 3;
            this.cbxOpenCFG.Text = "立即配置该虚拟机";
            this.cbxOpenCFG.UseVisualStyleBackColor = true;
            // 
            // lblOldVM
            // 
            this.lblOldVM.AutoSize = true;
            this.lblOldVM.Location = new System.Drawing.Point(16, 22);
            this.lblOldVM.Name = "lblOldVM";
            this.lblOldVM.Size = new System.Drawing.Size(330, 28);
            this.lblOldVM.TabIndex = 23;
            this.lblOldVM.Text = "虚拟机 \"<名字在这里>\" 将被克隆到:";
            this.lblOldVM.Click += new System.EventHandler(this.lblOldVM_Click);
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
            // dlgCloneVM
            // 
            this.AcceptButton = this.btnClone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(876, 360);
            this.Controls.Add(this.lblOldVM);
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
            this.Name = "dlgCloneVM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "克隆虚拟机";
            this.Load += new System.EventHandler(this.dlgCloneVM_Load);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblPath1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.CheckBox cbxStartVM;
        private System.Windows.Forms.CheckBox cbxOpenCFG;
        private System.Windows.Forms.Label lblOldVM;
        private System.Windows.Forms.ToolTip tipLblPath1;
        private System.Windows.Forms.ToolTip tipTxtName;
    }
}