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
            this.lb_User = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lb_PassWord = new System.Windows.Forms.Label();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.lb_chose = new System.Windows.Forms.Label();
            this.ptb_SignUp = new System.Windows.Forms.PictureBox();
            this.ptb_ADmin = new System.Windows.Forms.PictureBox();
            this.ptb_SignIn = new System.Windows.Forms.PictureBox();
            this.ptb_Back = new System.Windows.Forms.PictureBox();
            this.ptb_BackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ADmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.Color.White;
            this.lb_User.Location = new System.Drawing.Point(40, 287);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(80, 16);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "User Name:";
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(39, 317);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(346, 28);
            this.txt_User.TabIndex = 3;
            // 
            // lb_PassWord
            // 
            this.lb_PassWord.AutoSize = true;
            this.lb_PassWord.BackColor = System.Drawing.Color.Transparent;
            this.lb_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PassWord.ForeColor = System.Drawing.Color.White;
            this.lb_PassWord.Location = new System.Drawing.Point(40, 358);
            this.lb_PassWord.Name = "lb_PassWord";
            this.lb_PassWord.Size = new System.Drawing.Size(78, 16);
            this.lb_PassWord.TabIndex = 4;
            this.lb_PassWord.Text = "Pass Word:";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassWord.Location = new System.Drawing.Point(39, 388);
            this.txt_PassWord.Multiline = true;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(346, 28);
            this.txt_PassWord.TabIndex = 5;
            // 
            // lb_chose
            // 
            this.lb_chose.AutoSize = true;
            this.lb_chose.BackColor = System.Drawing.Color.Transparent;
            this.lb_chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chose.ForeColor = System.Drawing.Color.White;
            this.lb_chose.Location = new System.Drawing.Point(84, 603);
            this.lb_chose.Name = "lb_chose";
            this.lb_chose.Size = new System.Drawing.Size(147, 16);
            this.lb_chose.TabIndex = 8;
            this.lb_chose.Text = "can\'t have an account ?";
            // 
            // ptb_SignUp
            // 
            this.ptb_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.ptb_SignUp.Image = global::Appp.Properties.Resources.SignUp;
            this.ptb_SignUp.Location = new System.Drawing.Point(237, 601);
            this.ptb_SignUp.Name = "ptb_SignUp";
            this.ptb_SignUp.Size = new System.Drawing.Size(80, 20);
            this.ptb_SignUp.TabIndex = 9;
            this.ptb_SignUp.TabStop = false;
            this.ptb_SignUp.Click += new System.EventHandler(this.ptb_SignUp_Click);
            // 
            // ptb_ADmin
            // 
            this.ptb_ADmin.BackColor = System.Drawing.Color.Transparent;
            this.ptb_ADmin.Image = global::Appp.Properties.Resources.Admin1;
            this.ptb_ADmin.Location = new System.Drawing.Point(140, 529);
            this.ptb_ADmin.Name = "ptb_ADmin";
            this.ptb_ADmin.Size = new System.Drawing.Size(136, 44);
            this.ptb_ADmin.TabIndex = 7;
            this.ptb_ADmin.TabStop = false;
            // 
            // ptb_SignIn
            // 
            this.ptb_SignIn.BackColor = System.Drawing.Color.Transparent;
            this.ptb_SignIn.Image = global::Appp.Properties.Resources.SignIn_1;
            this.ptb_SignIn.Location = new System.Drawing.Point(140, 469);
            this.ptb_SignIn.Name = "ptb_SignIn";
            this.ptb_SignIn.Size = new System.Drawing.Size(136, 44);
            this.ptb_SignIn.TabIndex = 6;
            this.ptb_SignIn.TabStop = false;
            this.ptb_SignIn.Click += new System.EventHandler(this.ptb_SignIn_Click);
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
            this.ptb_BackGround.Image = global::Appp.Properties.Resources._1;
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
            this.Controls.Add(this.ptb_SignUp);
            this.Controls.Add(this.lb_chose);
            this.Controls.Add(this.ptb_ADmin);
            this.Controls.Add(this.ptb_SignIn);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.lb_PassWord);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.ptb_Back);
            this.Controls.Add(this.ptb_BackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SignIn";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Frm_SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ADmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_BackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_BackGround;
        private System.Windows.Forms.PictureBox ptb_Back;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lb_PassWord;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.PictureBox ptb_SignIn;
        private System.Windows.Forms.PictureBox ptb_ADmin;
        private System.Windows.Forms.Label lb_chose;
        private System.Windows.Forms.PictureBox ptb_SignUp;
    }
}

