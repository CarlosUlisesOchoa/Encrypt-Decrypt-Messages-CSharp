namespace Encrypt_and_Decrypt_with_pass__UI_
{
    partial class Encrypter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encrypter));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl01 = new System.Windows.Forms.TabControl();
            this.tabPageEncrypt = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCharCountOut = new System.Windows.Forms.Label();
            this.lblCharCountIn = new System.Windows.Forms.Label();
            this.lblClean = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.radBtnEncrypt = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.picBox_Eye = new System.Windows.Forms.PictureBox();
            this.picBoxExchange = new System.Windows.Forms.PictureBox();
            this.picBoxDDecrypt = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabControl01.SuspendLayout();
            this.tabPageEncrypt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDDecrypt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encrypt and Decrypt data!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 100);
            this.panel1.TabIndex = 2;
            // 
            // tabControl01
            // 
            this.tabControl01.Controls.Add(this.tabPageEncrypt);
            this.tabControl01.Location = new System.Drawing.Point(12, 118);
            this.tabControl01.Name = "tabControl01";
            this.tabControl01.SelectedIndex = 0;
            this.tabControl01.Size = new System.Drawing.Size(933, 399);
            this.tabControl01.TabIndex = 3;
            // 
            // tabPageEncrypt
            // 
            this.tabPageEncrypt.Controls.Add(this.picBox_Eye);
            this.tabPageEncrypt.Controls.Add(this.label5);
            this.tabPageEncrypt.Controls.Add(this.label4);
            this.tabPageEncrypt.Controls.Add(this.label3);
            this.tabPageEncrypt.Controls.Add(this.label2);
            this.tabPageEncrypt.Controls.Add(this.picBoxExchange);
            this.tabPageEncrypt.Controls.Add(this.lblCharCountOut);
            this.tabPageEncrypt.Controls.Add(this.lblCharCountIn);
            this.tabPageEncrypt.Controls.Add(this.lblClean);
            this.tabPageEncrypt.Controls.Add(this.btnGo);
            this.tabPageEncrypt.Controls.Add(this.groupBox1);
            this.tabPageEncrypt.Controls.Add(this.txtOutput);
            this.tabPageEncrypt.Controls.Add(this.txtPassword);
            this.tabPageEncrypt.Controls.Add(this.txtInput);
            this.tabPageEncrypt.Location = new System.Drawing.Point(4, 25);
            this.tabPageEncrypt.Name = "tabPageEncrypt";
            this.tabPageEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncrypt.Size = new System.Drawing.Size(925, 370);
            this.tabPageEncrypt.TabIndex = 0;
            this.tabPageEncrypt.Text = "Encrypt";
            this.tabPageEncrypt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "KEY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "OUTPUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "(if blank, a random key will be generated)";
            // 
            // lblCharCountOut
            // 
            this.lblCharCountOut.AutoSize = true;
            this.lblCharCountOut.Location = new System.Drawing.Point(854, 231);
            this.lblCharCountOut.Name = "lblCharCountOut";
            this.lblCharCountOut.Size = new System.Drawing.Size(16, 17);
            this.lblCharCountOut.TabIndex = 8;
            this.lblCharCountOut.Text = "0";
            // 
            // lblCharCountIn
            // 
            this.lblCharCountIn.AutoSize = true;
            this.lblCharCountIn.Location = new System.Drawing.Point(322, 231);
            this.lblCharCountIn.Name = "lblCharCountIn";
            this.lblCharCountIn.Size = new System.Drawing.Size(16, 17);
            this.lblCharCountIn.TabIndex = 7;
            this.lblCharCountIn.Text = "0";
            // 
            // lblClean
            // 
            this.lblClean.AutoSize = true;
            this.lblClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClean.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClean.Location = new System.Drawing.Point(428, 238);
            this.lblClean.Name = "lblClean";
            this.lblClean.Size = new System.Drawing.Size(64, 25);
            this.lblClean.TabIndex = 6;
            this.lblClean.Text = "Clean";
            this.lblClean.Click += new System.EventHandler(this.lblClean_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(400, 285);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(113, 38);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnDecrypt);
            this.groupBox1.Controls.Add(this.radBtnEncrypt);
            this.groupBox1.Location = new System.Drawing.Point(378, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // radBtnDecrypt
            // 
            this.radBtnDecrypt.AutoSize = true;
            this.radBtnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnDecrypt.Location = new System.Drawing.Point(19, 92);
            this.radBtnDecrypt.Name = "radBtnDecrypt";
            this.radBtnDecrypt.Size = new System.Drawing.Size(116, 33);
            this.radBtnDecrypt.TabIndex = 1;
            this.radBtnDecrypt.Text = "Decrypt";
            this.radBtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // radBtnEncrypt
            // 
            this.radBtnEncrypt.AutoSize = true;
            this.radBtnEncrypt.Checked = true;
            this.radBtnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnEncrypt.Location = new System.Drawing.Point(19, 39);
            this.radBtnEncrypt.Name = "radBtnEncrypt";
            this.radBtnEncrypt.Size = new System.Drawing.Size(114, 33);
            this.radBtnEncrypt.TabIndex = 0;
            this.radBtnEncrypt.TabStop = true;
            this.radBtnEncrypt.Text = "Encrypt";
            this.radBtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(570, 70);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(312, 158);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Click += new System.EventHandler(this.txtOutput_Click);
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(94, 267);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(200, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(42, 70);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(312, 158);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // picBox_Eye
            // 
            this.picBox_Eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_Eye.Image = global::Encrypt_and_Decrypt_with_pass__UI_.Properties.Resources.eye_on;
            this.picBox_Eye.Location = new System.Drawing.Point(305, 276);
            this.picBox_Eye.Name = "picBox_Eye";
            this.picBox_Eye.Size = new System.Drawing.Size(39, 24);
            this.picBox_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Eye.TabIndex = 14;
            this.picBox_Eye.TabStop = false;
            this.picBox_Eye.Click += new System.EventHandler(this.picBox_Eye_On_Click);
            // 
            // picBoxExchange
            // 
            this.picBoxExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxExchange.Image = global::Encrypt_and_Decrypt_with_pass__UI_.Properties.Resources.exchange_icon;
            this.picBoxExchange.Location = new System.Drawing.Point(411, 10);
            this.picBoxExchange.Name = "picBoxExchange";
            this.picBoxExchange.Size = new System.Drawing.Size(100, 50);
            this.picBoxExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxExchange.TabIndex = 9;
            this.picBoxExchange.TabStop = false;
            this.picBoxExchange.Click += new System.EventHandler(this.picBoxExchange_Click);
            // 
            // picBoxDDecrypt
            // 
            this.picBoxDDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxDDecrypt.Image = global::Encrypt_and_Decrypt_with_pass__UI_.Properties.Resources.dencrypt;
            this.picBoxDDecrypt.Location = new System.Drawing.Point(384, 70);
            this.picBoxDDecrypt.Name = "picBoxDDecrypt";
            this.picBoxDDecrypt.Size = new System.Drawing.Size(154, 158);
            this.picBoxDDecrypt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDDecrypt.TabIndex = 0;
            this.picBoxDDecrypt.TabStop = false;
            this.picBoxDDecrypt.Click += new System.EventHandler(this.picBoxEncrypt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutThisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutThisToolStripMenuItem
            // 
            this.aboutThisToolStripMenuItem.Name = "aboutThisToolStripMenuItem";
            this.aboutThisToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.aboutThisToolStripMenuItem.Text = "About this";
            // 
            // Encrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encrypter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl01.ResumeLayout(false);
            this.tabPageEncrypt.ResumeLayout(false);
            this.tabPageEncrypt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDDecrypt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl01;
        private System.Windows.Forms.TabPage tabPageEncrypt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox picBoxDDecrypt;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnDecrypt;
        private System.Windows.Forms.RadioButton radBtnEncrypt;
        private System.Windows.Forms.Label lblClean;
        private System.Windows.Forms.Label lblCharCountOut;
        private System.Windows.Forms.Label lblCharCountIn;
        private System.Windows.Forms.PictureBox picBoxExchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Eye;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisToolStripMenuItem;
    }
}

