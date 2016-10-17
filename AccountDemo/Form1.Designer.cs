namespace AccountDemo
{
    partial class Form1
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
            this.btmExit = new System.Windows.Forms.Button();
            this.btmClear = new System.Windows.Forms.Button();
            this.btmDel = new System.Windows.Forms.Button();
            this.btmVer = new System.Windows.Forms.Button();
            this.btmAdd = new System.Windows.Forms.Button();
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbxNewNum = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.cancelVer = new System.Windows.Forms.Button();
            this.verify = new System.Windows.Forms.Button();
            this.tbxVerN = new System.Windows.Forms.TextBox();
            this.CancelDel = new System.Windows.Forms.Button();
            this.DelNum = new System.Windows.Forms.Button();
            this.tbxDelNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Location = new System.Drawing.Point(190, 203);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(75, 23);
            this.btmExit.TabIndex = 13;
            this.btmExit.Text = "Exit";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // btmClear
            // 
            this.btmClear.Location = new System.Drawing.Point(190, 174);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(75, 23);
            this.btmClear.TabIndex = 12;
            this.btmClear.Text = "Clear List";
            this.btmClear.UseVisualStyleBackColor = true;
            this.btmClear.Click += new System.EventHandler(this.btmClear_Click);
            // 
            // btmDel
            // 
            this.btmDel.Location = new System.Drawing.Point(190, 132);
            this.btmDel.Name = "btmDel";
            this.btmDel.Size = new System.Drawing.Size(75, 36);
            this.btmDel.TabIndex = 11;
            this.btmDel.Text = "Delete Account";
            this.btmDel.UseVisualStyleBackColor = true;
            this.btmDel.Click += new System.EventHandler(this.btmDel_Click);
            // 
            // btmVer
            // 
            this.btmVer.Location = new System.Drawing.Point(190, 90);
            this.btmVer.Name = "btmVer";
            this.btmVer.Size = new System.Drawing.Size(75, 36);
            this.btmVer.TabIndex = 10;
            this.btmVer.Text = "Verify Account";
            this.btmVer.UseVisualStyleBackColor = true;
            this.btmVer.Click += new System.EventHandler(this.btmVer_Click);
            // 
            // btmAdd
            // 
            this.btmAdd.Location = new System.Drawing.Point(190, 49);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(75, 35);
            this.btmAdd.TabIndex = 9;
            this.btmAdd.Text = "Add Account";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // listAccounts
            // 
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.Location = new System.Drawing.Point(16, 32);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(150, 212);
            this.listAccounts.Sorted = true;
            this.listAccounts.TabIndex = 8;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(164, 20);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Account Maintenance";
            // 
            // tbxNewNum
            // 
            this.tbxNewNum.Location = new System.Drawing.Point(182, 49);
            this.tbxNewNum.MaxLength = 5;
            this.tbxNewNum.Name = "tbxNewNum";
            this.tbxNewNum.Size = new System.Drawing.Size(100, 20);
            this.tbxNewNum.TabIndex = 0;
            this.tbxNewNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNewNum.Visible = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(182, 81);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(42, 25);
            this.add.TabIndex = 14;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(229, 81);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(53, 25);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // cancelVer
            // 
            this.cancelVer.Location = new System.Drawing.Point(229, 96);
            this.cancelVer.Name = "cancelVer";
            this.cancelVer.Size = new System.Drawing.Size(53, 25);
            this.cancelVer.TabIndex = 18;
            this.cancelVer.Text = "Cancel";
            this.cancelVer.UseVisualStyleBackColor = true;
            this.cancelVer.Visible = false;
            this.cancelVer.Click += new System.EventHandler(this.cancelVer_Click);
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(182, 96);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(42, 25);
            this.verify.TabIndex = 17;
            this.verify.Text = "Verify";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Visible = false;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // tbxVerN
            // 
            this.tbxVerN.Location = new System.Drawing.Point(182, 64);
            this.tbxVerN.MaxLength = 5;
            this.tbxVerN.Name = "tbxVerN";
            this.tbxVerN.Size = new System.Drawing.Size(100, 20);
            this.tbxVerN.TabIndex = 16;
            this.tbxVerN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxVerN.Visible = false;
            // 
            // CancelDel
            // 
            this.CancelDel.Location = new System.Drawing.Point(229, 138);
            this.CancelDel.Name = "CancelDel";
            this.CancelDel.Size = new System.Drawing.Size(53, 25);
            this.CancelDel.TabIndex = 21;
            this.CancelDel.Text = "Cancel";
            this.CancelDel.UseVisualStyleBackColor = true;
            this.CancelDel.Visible = false;
            // 
            // DelNum
            // 
            this.DelNum.Location = new System.Drawing.Point(172, 138);
            this.DelNum.Name = "DelNum";
            this.DelNum.Size = new System.Drawing.Size(52, 25);
            this.DelNum.TabIndex = 20;
            this.DelNum.Text = "Delete";
            this.DelNum.UseVisualStyleBackColor = true;
            this.DelNum.Visible = false;
            this.DelNum.Click += new System.EventHandler(this.DelNum_Click);
            // 
            // tbxDelNum
            // 
            this.tbxDelNum.Location = new System.Drawing.Point(182, 106);
            this.tbxDelNum.MaxLength = 5;
            this.tbxDelNum.Name = "tbxDelNum";
            this.tbxDelNum.Size = new System.Drawing.Size(100, 20);
            this.tbxDelNum.TabIndex = 19;
            this.tbxDelNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxDelNum.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 261);
            this.ControlBox = false;
            this.Controls.Add(this.CancelDel);
            this.Controls.Add(this.DelNum);
            this.Controls.Add(this.tbxDelNum);
            this.Controls.Add(this.cancelVer);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.tbxVerN);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tbxNewNum);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btmClear);
            this.Controls.Add(this.btmDel);
            this.Controls.Add(this.btmVer);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Account Maintenance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Button btmClear;
        private System.Windows.Forms.Button btmDel;
        private System.Windows.Forms.Button btmVer;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbxNewNum;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button cancelVer;
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.TextBox tbxVerN;
        private System.Windows.Forms.Button CancelDel;
        private System.Windows.Forms.Button DelNum;
        private System.Windows.Forms.TextBox tbxDelNum;
    }
}

