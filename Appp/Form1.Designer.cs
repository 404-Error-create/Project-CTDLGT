namespace Appp
{
    partial class Frm_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SignIn));
            this.ptb_Back = new System.Windows.Forms.PictureBox();
            this.ptb_BackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Back
            // 
            this.ptb_Back.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Back.Image = global::Appp.Properties.Resources.Back;
            this.ptb_Back.Location = new System.Drawing.Point(13, 13);
            this.ptb_Back.Name = "ptb_Back";
            this.ptb_Back.Size = new System.Drawing.Size(64, 22);
            this.ptb_Back.TabIndex = 1;
            this.ptb_Back.TabStop = false;
            // 
            // ptb_BackGround
            // 
            this.ptb_BackGround.BackColor = System.Drawing.Color.Transparent;
            this.ptb_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_BackGround.Image = global::Appp.Properties.Resources._2;
            this.ptb_BackGround.Location = new System.Drawing.Point(0, 0);
            this.ptb_BackGround.Name = "ptb_BackGround";
            this.ptb_BackGround.Size = new System.Drawing.Size(435, 683);
            this.ptb_BackGround.TabIndex = 0;
            this.ptb_BackGround.TabStop = false;
            // 
            // Frm_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 683);
            this.Controls.Add(this.ptb_Back);
            this.Controls.Add(this.ptb_BackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SignIn";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Frm_SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_BackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_BackGround;
        private System.Windows.Forms.PictureBox ptb_Back;
    }
}

