namespace WHBoxProtector
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnProtector = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.txtFileName = new DrakeUI.Framework.DrakeUITextBox();
            this.drakeUILabel2 = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUILabel1 = new DrakeUI.Framework.DrakeUILabel();
            this.numberattr = new DrakeUI.Framework.DrakeUITextBox();
            this.btnOpenFile = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.txtOpenFile = new DrakeUI.Framework.DrakeUITextBox();
            this.ObfuscationDL = new DrakeUI.Framework.DrakeUICheckBox();
            this.AntiDeBonDot = new DrakeUI.Framework.DrakeUICheckBox();
            this.protName = new DrakeUI.Framework.DrakeUICheckBox();
            this.microAtt = new DrakeUI.Framework.DrakeUICheckBox();
            this.strEncrypt = new DrakeUI.Framework.DrakeUICheckBox();
            this.drakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.icopath = new DrakeUI.Framework.DrakeUITextBox();
            this.drakeUILinkLabel1 = new DrakeUI.Framework.DrakeUILinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProtector
            // 
            this.btnProtector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnProtector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProtector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnProtector.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.btnProtector.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnProtector.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnProtector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProtector.Location = new System.Drawing.Point(231, 217);
            this.btnProtector.Name = "btnProtector";
            this.btnProtector.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnProtector.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnProtector.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.btnProtector.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnProtector.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnProtector.Size = new System.Drawing.Size(138, 35);
            this.btnProtector.Style = DrakeUI.Framework.UIStyle.Custom;
            this.btnProtector.Symbol = 61746;
            this.btnProtector.TabIndex = 33;
            this.btnProtector.Text = "Protector";
            this.btnProtector.Click += new System.EventHandler(this.btnProtector_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.FillColor = System.Drawing.Color.White;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileName.ForeColor = System.Drawing.Color.Black;
            this.txtFileName.Location = new System.Drawing.Point(231, 183);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileName.Maximum = 2147483647D;
            this.txtFileName.Minimum = -2147483648D;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Padding = new System.Windows.Forms.Padding(5);
            this.txtFileName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txtFileName.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtFileName.Size = new System.Drawing.Size(138, 26);
            this.txtFileName.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtFileName.TabIndex = 30;
            this.txtFileName.Text = "DrakeProtector";
            // 
            // drakeUILabel2
            // 
            this.drakeUILabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUILabel2.ForeColor = System.Drawing.Color.White;
            this.drakeUILabel2.Location = new System.Drawing.Point(227, 155);
            this.drakeUILabel2.Name = "drakeUILabel2";
            this.drakeUILabel2.Size = new System.Drawing.Size(99, 23);
            this.drakeUILabel2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel2.TabIndex = 32;
            this.drakeUILabel2.Text = "File Name";
            this.drakeUILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUILabel1
            // 
            this.drakeUILabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUILabel1.ForeColor = System.Drawing.Color.White;
            this.drakeUILabel1.Location = new System.Drawing.Point(227, 99);
            this.drakeUILabel1.Name = "drakeUILabel1";
            this.drakeUILabel1.Size = new System.Drawing.Size(154, 23);
            this.drakeUILabel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel1.TabIndex = 31;
            this.drakeUILabel1.Text = "Number of attributes";
            this.drakeUILabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberattr
            // 
            this.numberattr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberattr.DoubleValue = 20D;
            this.numberattr.FillColor = System.Drawing.Color.White;
            this.numberattr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberattr.ForeColor = System.Drawing.Color.Black;
            this.numberattr.IntValue = 20;
            this.numberattr.Location = new System.Drawing.Point(231, 124);
            this.numberattr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberattr.Maximum = 2147483647D;
            this.numberattr.Minimum = -2147483648D;
            this.numberattr.Name = "numberattr";
            this.numberattr.Padding = new System.Windows.Forms.Padding(5);
            this.numberattr.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.numberattr.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.numberattr.Size = new System.Drawing.Size(138, 26);
            this.numberattr.Style = DrakeUI.Framework.UIStyle.Custom;
            this.numberattr.TabIndex = 28;
            this.numberattr.Text = "20";
            this.numberattr.TextChanged += new System.EventHandler(this.numberattr_TextChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnOpenFile.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.btnOpenFile.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnOpenFile.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpenFile.Location = new System.Drawing.Point(19, 53);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnOpenFile.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnOpenFile.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.btnOpenFile.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnOpenFile.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.btnOpenFile.Size = new System.Drawing.Size(109, 26);
            this.btnOpenFile.Style = DrakeUI.Framework.UIStyle.Custom;
            this.btnOpenFile.Symbol = 61563;
            this.btnOpenFile.TabIndex = 29;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpenFile.FillColor = System.Drawing.Color.White;
            this.txtOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOpenFile.Location = new System.Drawing.Point(135, 53);
            this.txtOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOpenFile.Maximum = 2147483647D;
            this.txtOpenFile.Minimum = -2147483648D;
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Padding = new System.Windows.Forms.Padding(5);
            this.txtOpenFile.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txtOpenFile.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txtOpenFile.Size = new System.Drawing.Size(235, 26);
            this.txtOpenFile.Style = DrakeUI.Framework.UIStyle.Custom;
            this.txtOpenFile.TabIndex = 27;
            // 
            // ObfuscationDL
            // 
            this.ObfuscationDL.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ObfuscationDL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ObfuscationDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ObfuscationDL.ForeColor = System.Drawing.Color.White;
            this.ObfuscationDL.Location = new System.Drawing.Point(19, 223);
            this.ObfuscationDL.Name = "ObfuscationDL";
            this.ObfuscationDL.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ObfuscationDL.Size = new System.Drawing.Size(150, 29);
            this.ObfuscationDL.Style = DrakeUI.Framework.UIStyle.Custom;
            this.ObfuscationDL.TabIndex = 26;
            this.ObfuscationDL.Text = "Obfuscator";
            this.ObfuscationDL.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.ObfuscationDL_ValueChanged);
            // 
            // AntiDeBonDot
            // 
            this.AntiDeBonDot.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.AntiDeBonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AntiDeBonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AntiDeBonDot.ForeColor = System.Drawing.Color.White;
            this.AntiDeBonDot.Location = new System.Drawing.Point(19, 192);
            this.AntiDeBonDot.Name = "AntiDeBonDot";
            this.AntiDeBonDot.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.AntiDeBonDot.Size = new System.Drawing.Size(150, 29);
            this.AntiDeBonDot.Style = DrakeUI.Framework.UIStyle.Custom;
            this.AntiDeBonDot.TabIndex = 25;
            this.AntiDeBonDot.Text = "Anti-De4dot";
            this.AntiDeBonDot.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.AntiDeBonDot_ValueChanged);
            // 
            // protName
            // 
            this.protName.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.protName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.protName.ForeColor = System.Drawing.Color.White;
            this.protName.Location = new System.Drawing.Point(19, 159);
            this.protName.Name = "protName";
            this.protName.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.protName.Size = new System.Drawing.Size(150, 29);
            this.protName.Style = DrakeUI.Framework.UIStyle.Custom;
            this.protName.TabIndex = 24;
            this.protName.Text = "Name Protection";
            this.protName.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.protName_ValueChanged);
            // 
            // microAtt
            // 
            this.microAtt.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.microAtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.microAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.microAtt.ForeColor = System.Drawing.Color.White;
            this.microAtt.Location = new System.Drawing.Point(19, 128);
            this.microAtt.Name = "microAtt";
            this.microAtt.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.microAtt.Size = new System.Drawing.Size(150, 29);
            this.microAtt.Style = DrakeUI.Framework.UIStyle.Custom;
            this.microAtt.TabIndex = 23;
            this.microAtt.Text = "Micro Attribute";
            this.microAtt.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.microAtt_ValueChanged);
            // 
            // strEncrypt
            // 
            this.strEncrypt.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.strEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.strEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.strEncrypt.ForeColor = System.Drawing.Color.White;
            this.strEncrypt.Location = new System.Drawing.Point(19, 99);
            this.strEncrypt.Name = "strEncrypt";
            this.strEncrypt.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.strEncrypt.Size = new System.Drawing.Size(164, 29);
            this.strEncrypt.Style = DrakeUI.Framework.UIStyle.Custom;
            this.strEncrypt.TabIndex = 22;
            this.strEncrypt.Text = "String Encryption";
            this.strEncrypt.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.strEncrypt_ValueChanged);
            // 
            // drakeUIButtonIcon1
            // 
            this.drakeUIButtonIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.drakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.drakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.drakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.drakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.drakeUIButtonIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIButtonIcon1.Location = new System.Drawing.Point(19, 280);
            this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
            this.drakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.drakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.drakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.drakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.drakeUIButtonIcon1.Size = new System.Drawing.Size(109, 35);
            this.drakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon1.Symbol = 61473;
            this.drakeUIButtonIcon1.TabIndex = 37;
            this.drakeUIButtonIcon1.Text = "Icon";
            this.drakeUIButtonIcon1.Click += new System.EventHandler(this.drakeUIButtonIcon1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WHBoxProtector.Properties.Resources.drakelamdotco;
            this.pictureBox1.Location = new System.Drawing.Point(398, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 262);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // icopath
            // 
            this.icopath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.icopath.FillColor = System.Drawing.Color.White;
            this.icopath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.icopath.ForeColor = System.Drawing.Color.Black;
            this.icopath.Location = new System.Drawing.Point(135, 284);
            this.icopath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.icopath.Maximum = 2147483647D;
            this.icopath.Minimum = -2147483648D;
            this.icopath.Name = "icopath";
            this.icopath.Padding = new System.Windows.Forms.Padding(5);
            this.icopath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.icopath.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.icopath.Size = new System.Drawing.Size(234, 26);
            this.icopath.Style = DrakeUI.Framework.UIStyle.Custom;
            this.icopath.TabIndex = 31;
            // 
            // drakeUILinkLabel1
            // 
            this.drakeUILinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.drakeUILinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUILinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.drakeUILinkLabel1.LinkColor = System.Drawing.Color.Green;
            this.drakeUILinkLabel1.Location = new System.Drawing.Point(690, 318);
            this.drakeUILinkLabel1.Name = "drakeUILinkLabel1";
            this.drakeUILinkLabel1.Size = new System.Drawing.Size(107, 23);
            this.drakeUILinkLabel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILinkLabel1.TabIndex = 39;
            this.drakeUILinkLabel1.TabStop = true;
            this.drakeUILinkLabel1.Text = "by Drake Lam";
            this.drakeUILinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.drakeUILinkLabel1.Click += new System.EventHandler(this.drakeUILinkLabel1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.drakeUILinkLabel1);
            this.Controls.Add(this.icopath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.drakeUIButtonIcon1);
            this.Controls.Add(this.btnProtector);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.drakeUILabel2);
            this.Controls.Add(this.drakeUILabel1);
            this.Controls.Add(this.numberattr);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtOpenFile);
            this.Controls.Add(this.ObfuscationDL);
            this.Controls.Add(this.AntiDeBonDot);
            this.Controls.Add(this.protName);
            this.Controls.Add(this.microAtt);
            this.Controls.Add(this.strEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ShowIcon = true;
            this.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Text = "Drake Protector";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DrakeUI.Framework.DrakeUIButtonIcon btnProtector;
        private DrakeUI.Framework.DrakeUITextBox txtFileName;
        private DrakeUI.Framework.DrakeUILabel drakeUILabel2;
        private DrakeUI.Framework.DrakeUILabel drakeUILabel1;
        private DrakeUI.Framework.DrakeUITextBox numberattr;
        private DrakeUI.Framework.DrakeUIButtonIcon btnOpenFile;
        private DrakeUI.Framework.DrakeUITextBox txtOpenFile;
        private DrakeUI.Framework.DrakeUICheckBox ObfuscationDL;
        private DrakeUI.Framework.DrakeUICheckBox AntiDeBonDot;
        private DrakeUI.Framework.DrakeUICheckBox protName;
        private DrakeUI.Framework.DrakeUICheckBox microAtt;
        private DrakeUI.Framework.DrakeUICheckBox strEncrypt;
        private DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DrakeUI.Framework.DrakeUITextBox icopath;
        private DrakeUI.Framework.DrakeUILinkLabel drakeUILinkLabel1;
    }
}