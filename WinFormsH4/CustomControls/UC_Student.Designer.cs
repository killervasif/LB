namespace LogBook.CustomControls
{
    partial class UC_Student
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Student));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLastEnterance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAbsent = new System.Windows.Forms.RadioButton();
            this.rbLate = new System.Windows.Forms.RadioButton();
            this.rbPresent = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cBoxClassWork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cBoxLabWork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClearDiamonds = new Guna.UI2.WinForms.Guna2Button();
            this.diamondButton3 = new LogBook.CustomControls.DiamondButton();
            this.diamondButton2 = new LogBook.CustomControls.DiamondButton();
            this.dBtn1 = new LogBook.CustomControls.DiamondButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnComment = new LogBook.CustomControls.TextEditButton();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblBorder = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProfile)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.05554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.42507F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.54395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.431818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.68182F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pBoxProfile);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 70);
            this.panel1.TabIndex = 0;
            // 
            // pBoxProfile
            // 
            this.pBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxProfile.FillColor = System.Drawing.Color.Transparent;
            this.pBoxProfile.Image = global::LogBook.Properties.Resources.dufaultAvatar;
            this.pBoxProfile.ImageRotate = 0F;
            this.pBoxProfile.Location = new System.Drawing.Point(39, 3);
            this.pBoxProfile.Name = "pBoxProfile";
            this.pBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pBoxProfile.Size = new System.Drawing.Size(64, 64);
            this.pBoxProfile.TabIndex = 4;
            this.pBoxProfile.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.Location = new System.Drawing.Point(105, 26);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(58, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "FullName";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(3, 23);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(30, 20);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLastEnterance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 70);
            this.panel2.TabIndex = 0;
            // 
            // lblLastEnterance
            // 
            this.lblLastEnterance.AutoSize = true;
            this.lblLastEnterance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastEnterance.Location = new System.Drawing.Point(9, 25);
            this.lblLastEnterance.Name = "lblLastEnterance";
            this.lblLastEnterance.Size = new System.Drawing.Size(88, 17);
            this.lblLastEnterance.TabIndex = 3;
            this.lblLastEnterance.Text = "LastEnterance";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbAbsent);
            this.panel3.Controls.Add(this.rbLate);
            this.panel3.Controls.Add(this.rbPresent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(101, 70);
            this.panel3.TabIndex = 0;
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.BackColor = System.Drawing.Color.Transparent;
            this.rbAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAbsent.ForeColor = System.Drawing.Color.Red;
            this.rbAbsent.Location = new System.Drawing.Point(72, 29);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbAbsent.Size = new System.Drawing.Size(13, 12);
            this.rbAbsent.TabIndex = 0;
            this.rbAbsent.UseVisualStyleBackColor = false;
            this.rbAbsent.CheckedChanged += new System.EventHandler(this.rbAbsent_CheckedChanged);
            // 
            // rbLate
            // 
            this.rbLate.AutoSize = true;
            this.rbLate.BackColor = System.Drawing.Color.Transparent;
            this.rbLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLate.ForeColor = System.Drawing.Color.Yellow;
            this.rbLate.Location = new System.Drawing.Point(44, 29);
            this.rbLate.Name = "rbLate";
            this.rbLate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbLate.Size = new System.Drawing.Size(13, 12);
            this.rbLate.TabIndex = 0;
            this.rbLate.UseVisualStyleBackColor = false;
            this.rbLate.CheckedChanged += new System.EventHandler(this.radioPresentOrLateButton_CheckedChanged);
            // 
            // rbPresent
            // 
            this.rbPresent.AutoSize = true;
            this.rbPresent.BackColor = System.Drawing.Color.Transparent;
            this.rbPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPresent.ForeColor = System.Drawing.Color.Lime;
            this.rbPresent.Location = new System.Drawing.Point(15, 29);
            this.rbPresent.Name = "rbPresent";
            this.rbPresent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbPresent.Size = new System.Drawing.Size(13, 12);
            this.rbPresent.TabIndex = 0;
            this.rbPresent.UseVisualStyleBackColor = false;
            this.rbPresent.CheckedChanged += new System.EventHandler(this.radioPresentOrLateButton_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cBoxClassWork);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(484, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(83, 70);
            this.panel5.TabIndex = 0;
            // 
            // cBoxClassWork
            // 
            this.cBoxClassWork.AutoRoundedCorners = true;
            this.cBoxClassWork.BackColor = System.Drawing.Color.Transparent;
            this.cBoxClassWork.BorderRadius = 17;
            this.cBoxClassWork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxClassWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxClassWork.FillColor = System.Drawing.SystemColors.Control;
            this.cBoxClassWork.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBoxClassWork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBoxClassWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxClassWork.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cBoxClassWork.ItemHeight = 30;
            this.cBoxClassWork.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBoxClassWork.Location = new System.Drawing.Point(8, 15);
            this.cBoxClassWork.Name = "cBoxClassWork";
            this.cBoxClassWork.Size = new System.Drawing.Size(64, 36);
            this.cBoxClassWork.StartIndex = 0;
            this.cBoxClassWork.TabIndex = 0;
            this.cBoxClassWork.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cBoxLabWork);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(404, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 70);
            this.panel4.TabIndex = 0;
            // 
            // cBoxLabWork
            // 
            this.cBoxLabWork.AutoRoundedCorners = true;
            this.cBoxLabWork.BackColor = System.Drawing.Color.Transparent;
            this.cBoxLabWork.BorderRadius = 17;
            this.cBoxLabWork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxLabWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLabWork.FillColor = System.Drawing.SystemColors.Control;
            this.cBoxLabWork.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBoxLabWork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBoxLabWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxLabWork.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cBoxLabWork.ItemHeight = 30;
            this.cBoxLabWork.Items.AddRange(new object[] {
            "-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBoxLabWork.Location = new System.Drawing.Point(8, 17);
            this.cBoxLabWork.Name = "cBoxLabWork";
            this.cBoxLabWork.Size = new System.Drawing.Size(64, 36);
            this.cBoxLabWork.StartIndex = 0;
            this.cBoxLabWork.TabIndex = 0;
            this.cBoxLabWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cBoxLabWork.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClearDiamonds);
            this.panel6.Controls.Add(this.diamondButton3);
            this.panel6.Controls.Add(this.diamondButton2);
            this.panel6.Controls.Add(this.dBtn1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(567, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 70);
            this.panel6.TabIndex = 0;
            // 
            // btnClearDiamonds
            // 
            this.btnClearDiamonds.BackgroundImage = global::LogBook.Properties.Resources.diamond_clear;
            this.btnClearDiamonds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearDiamonds.BorderColor = System.Drawing.Color.Transparent;
            this.btnClearDiamonds.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearDiamonds.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearDiamonds.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearDiamonds.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearDiamonds.FillColor = System.Drawing.Color.Transparent;
            this.btnClearDiamonds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearDiamonds.ForeColor = System.Drawing.Color.White;
            this.btnClearDiamonds.Location = new System.Drawing.Point(94, 18);
            this.btnClearDiamonds.Name = "btnClearDiamonds";
            this.btnClearDiamonds.Size = new System.Drawing.Size(26, 31);
            this.btnClearDiamonds.TabIndex = 1;
            this.btnClearDiamonds.Text = "guna2Button1";
            this.btnClearDiamonds.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnClearDiamonds.Click += new System.EventHandler(this.btnClearDiamonds_Click);
            // 
            // diamondButton3
            // 
            this.diamondButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diamondButton3.BackgroundImage")));
            this.diamondButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diamondButton3.Checked = false;
            this.diamondButton3.FlatAppearance.BorderSize = 0;
            this.diamondButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamondButton3.Location = new System.Drawing.Point(67, 18);
            this.diamondButton3.Name = "diamondButton3";
            this.diamondButton3.Position = ((byte)(3));
            this.diamondButton3.Size = new System.Drawing.Size(26, 31);
            this.diamondButton3.TabIndex = 0;
            this.diamondButton3.UseVisualStyleBackColor = true;
            this.diamondButton3.Click += new System.EventHandler(this.diamondBtn_Click);
            // 
            // diamondButton2
            // 
            this.diamondButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diamondButton2.BackgroundImage")));
            this.diamondButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diamondButton2.Checked = false;
            this.diamondButton2.FlatAppearance.BorderSize = 0;
            this.diamondButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamondButton2.Location = new System.Drawing.Point(35, 18);
            this.diamondButton2.Name = "diamondButton2";
            this.diamondButton2.Position = ((byte)(2));
            this.diamondButton2.Size = new System.Drawing.Size(26, 31);
            this.diamondButton2.TabIndex = 0;
            this.diamondButton2.UseVisualStyleBackColor = true;
            this.diamondButton2.Click += new System.EventHandler(this.diamondBtn_Click);
            // 
            // dBtn1
            // 
            this.dBtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtn1.BackgroundImage")));
            this.dBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dBtn1.Checked = false;
            this.dBtn1.FlatAppearance.BorderSize = 0;
            this.dBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dBtn1.Location = new System.Drawing.Point(3, 18);
            this.dBtn1.Name = "dBtn1";
            this.dBtn1.Position = ((byte)(1));
            this.dBtn1.Size = new System.Drawing.Size(26, 31);
            this.dBtn1.TabIndex = 0;
            this.dBtn1.UseVisualStyleBackColor = true;
            this.dBtn1.Click += new System.EventHandler(this.diamondBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnComment);
            this.panel7.Controls.Add(this.txtComment);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(696, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel7.Size = new System.Drawing.Size(184, 70);
            this.panel7.TabIndex = 0;
            // 
            // btnComment
            // 
            this.btnComment.BackgroundImage = global::LogBook.Properties.Resources.comment;
            this.btnComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComment.Checked = false;
            this.btnComment.FlatAppearance.BorderSize = 0;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Location = new System.Drawing.Point(12, 20);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(26, 31);
            this.btnComment.TabIndex = 3;
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtComment.Location = new System.Drawing.Point(41, 4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(140, 61);
            this.txtComment.TabIndex = 2;
            this.txtComment.Visible = false;
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBorder.Location = new System.Drawing.Point(0, 68);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(880, 2);
            this.lblBorder.TabIndex = 1;
            // 
            // UC_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(880, 70);
            this.Name = "UC_Student";
            this.Size = new System.Drawing.Size(880, 70);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProfile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBorder;
        private Label lblNumber;
        private Label lblFullName;
        private Label lblLastEnterance;
        private Guna.UI2.WinForms.Guna2ComboBox cBoxLabWork;
        private Guna.UI2.WinForms.Guna2ComboBox cBoxClassWork;
        private DiamondButton diamondButton3;
        private DiamondButton diamondButton2;
        private DiamondButton dBtn1;
        private Guna.UI2.WinForms.Guna2Button btnClearDiamonds;
        private TextBox txtComment;
        private TextEditButton btnComment;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pBoxProfile;
        public Panel panel3;
        public Panel panel7;
        public RadioButton rbAbsent;
        public RadioButton rbLate;
        public RadioButton rbPresent;
        public Panel panel1;
        public Panel panel2;
        public Panel panel5;
        public Panel panel4;
        public Panel panel6;
    }
}
