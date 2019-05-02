namespace Encrypt_and_Decrypt_with_pass__UI_
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Decription = new System.Windows.Forms.Label();
            this.lbl_Web = new System.Windows.Forms.LinkLabel();
            this.lbl_Copy = new System.Windows.Forms.Label();
            this.lbl_ES = new System.Windows.Forms.Label();
            this.lbl_ENG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Encrypt_and_Decrypt_with_pass__UI_.Properties.Resources.perfil_recor;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Title.Location = new System.Drawing.Point(8, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(1126, 53);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Acerca del desarrollador";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Decription
            // 
            this.lbl_Decription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Decription.Location = new System.Drawing.Point(302, 114);
            this.lbl_Decription.Name = "lbl_Decription";
            this.lbl_Decription.Size = new System.Drawing.Size(784, 287);
            this.lbl_Decription.TabIndex = 2;
            this.lbl_Decription.Text = resources.GetString("lbl_Decription.Text");
            // 
            // lbl_Web
            // 
            this.lbl_Web.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Web.Location = new System.Drawing.Point(7, 443);
            this.lbl_Web.Name = "lbl_Web";
            this.lbl_Web.Size = new System.Drawing.Size(1137, 35);
            this.lbl_Web.TabIndex = 3;
            this.lbl_Web.TabStop = true;
            this.lbl_Web.Text = "www.CarlosUlises.ml";
            this.lbl_Web.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Copy
            // 
            this.lbl_Copy.Location = new System.Drawing.Point(8, 478);
            this.lbl_Copy.Name = "lbl_Copy";
            this.lbl_Copy.Size = new System.Drawing.Size(1126, 23);
            this.lbl_Copy.TabIndex = 4;
            this.lbl_Copy.Text = "Todos los derechos reservados ® Copyright © 2010 - 2019";
            this.lbl_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ES
            // 
            this.lbl_ES.AutoSize = true;
            this.lbl_ES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ES.Location = new System.Drawing.Point(961, 62);
            this.lbl_ES.Name = "lbl_ES";
            this.lbl_ES.Size = new System.Drawing.Size(67, 20);
            this.lbl_ES.TabIndex = 5;
            this.lbl_ES.Text = "Spanish";
            this.lbl_ES.Click += new System.EventHandler(this.lbl_ES_Click);
            // 
            // lbl_ENG
            // 
            this.lbl_ENG.AutoSize = true;
            this.lbl_ENG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ENG.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_ENG.Location = new System.Drawing.Point(1055, 62);
            this.lbl_ENG.Name = "lbl_ENG";
            this.lbl_ENG.Size = new System.Drawing.Size(61, 20);
            this.lbl_ENG.TabIndex = 6;
            this.lbl_ENG.Text = "English";
            this.lbl_ENG.Click += new System.EventHandler(this.lbl_ENG_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 516);
            this.Controls.Add(this.lbl_ENG);
            this.Controls.Add(this.lbl_ES);
            this.Controls.Add(this.lbl_Copy);
            this.Controls.Add(this.lbl_Web);
            this.Controls.Add(this.lbl_Decription);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AcercaDe";
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Decription;
        private System.Windows.Forms.LinkLabel lbl_Web;
        private System.Windows.Forms.Label lbl_Copy;
        private System.Windows.Forms.Label lbl_ES;
        private System.Windows.Forms.Label lbl_ENG;
    }
}