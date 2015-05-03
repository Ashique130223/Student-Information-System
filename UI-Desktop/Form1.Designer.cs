namespace UI_Desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboTerm = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textContct = new System.Windows.Forms.TextBox();
            this.lblContct = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.textBatch = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.textRoll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboTerm
            // 
            this.comboTerm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboTerm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboTerm.FormattingEnabled = true;
            this.comboTerm.Items.AddRange(new object[] {
            "I",
            "II"});
            this.comboTerm.Location = new System.Drawing.Point(240, 333);
            this.comboTerm.Name = "comboTerm";
            this.comboTerm.Size = new System.Drawing.Size(333, 35);
            this.comboTerm.TabIndex = 90;
            this.comboTerm.SelectedIndexChanged += new System.EventHandler(this.comboTerm_SelectedIndexChanged);
            // 
            // comboYear
            // 
            this.comboYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboYear.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.comboYear.Location = new System.Drawing.Point(242, 278);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(331, 35);
            this.comboYear.TabIndex = 89;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonExit.Location = new System.Drawing.Point(446, 447);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(114, 36);
            this.buttonExit.TabIndex = 88;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblYear.Location = new System.Drawing.Point(116, 278);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(78, 30);
            this.lblYear.TabIndex = 87;
            this.lblYear.Text = "Year :";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.BackColor = System.Drawing.Color.Transparent;
            this.lblTerm.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTerm.Location = new System.Drawing.Point(115, 338);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(93, 30);
            this.lblTerm.TabIndex = 86;
            this.lblTerm.Text = "Term : ";
            this.lblTerm.Click += new System.EventHandler(this.lblTerm_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShow.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonShow.Location = new System.Drawing.Point(285, 447);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(119, 36);
            this.buttonShow.TabIndex = 85;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSave.Location = new System.Drawing.Point(120, 447);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 36);
            this.buttonSave.TabIndex = 84;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textContct
            // 
            this.textContct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textContct.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textContct.Location = new System.Drawing.Point(242, 390);
            this.textContct.Name = "textContct";
            this.textContct.Size = new System.Drawing.Size(331, 34);
            this.textContct.TabIndex = 83;
            this.textContct.TextChanged += new System.EventHandler(this.textContct_TextChanged);
            // 
            // lblContct
            // 
            this.lblContct.AutoSize = true;
            this.lblContct.BackColor = System.Drawing.Color.Transparent;
            this.lblContct.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblContct.Location = new System.Drawing.Point(101, 394);
            this.lblContct.Name = "lblContct";
            this.lblContct.Size = new System.Drawing.Size(146, 30);
            this.lblContct.TabIndex = 82;
            this.lblContct.Text = "Contact No :";
            this.lblContct.Click += new System.EventHandler(this.lblContct_Click);
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textAddress.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textAddress.Location = new System.Drawing.Point(240, 226);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(333, 34);
            this.textAddress.TabIndex = 81;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAddress.Location = new System.Drawing.Point(113, 225);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 30);
            this.lblAddress.TabIndex = 80;
            this.lblAddress.Text = "Address :";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.BackColor = System.Drawing.Color.Transparent;
            this.lblBatch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBatch.Location = new System.Drawing.Point(114, 180);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(89, 30);
            this.lblBatch.TabIndex = 79;
            this.lblBatch.Text = "Batch :";
            this.lblBatch.Click += new System.EventHandler(this.lblBatch_Click);
            // 
            // textBatch
            // 
            this.textBatch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBatch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBatch.Location = new System.Drawing.Point(240, 181);
            this.textBatch.Name = "textBatch";
            this.textBatch.Size = new System.Drawing.Size(333, 34);
            this.textBatch.TabIndex = 78;
            this.textBatch.TextChanged += new System.EventHandler(this.textBatch_TextChanged);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textName.Location = new System.Drawing.Point(240, 137);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(333, 34);
            this.textName.TabIndex = 77;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(111, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 30);
            this.lblName.TabIndex = 76;
            this.lblName.Text = "Name :";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.Color.Transparent;
            this.lblRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRoll.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRoll.Location = new System.Drawing.Point(115, 91);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(67, 30);
            this.lblRoll.TabIndex = 75;
            this.lblRoll.Text = "Roll :";
            this.lblRoll.Click += new System.EventHandler(this.lblRoll_Click);
            // 
            // textRoll
            // 
            this.textRoll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textRoll.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textRoll.Location = new System.Drawing.Point(240, 88);
            this.textRoll.Name = "textRoll";
            this.textRoll.Size = new System.Drawing.Size(333, 34);
            this.textRoll.TabIndex = 74;
            this.textRoll.TextChanged += new System.EventHandler(this.textRoll_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 45);
            this.label1.TabIndex = 91;
            this.label1.Text = "CSE Discipline, Student Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(708, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTerm);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textContct);
            this.Controls.Add(this.lblContct);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.textBatch);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.textRoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSE Discipline, Student Info";
            this.TransparencyKey = System.Drawing.Color.Teal;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTerm;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textContct;
        private System.Windows.Forms.Label lblContct;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.TextBox textBatch;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.TextBox textRoll;
        private System.Windows.Forms.Label label1;
    }
}

