﻿namespace Appp
{
    partial class Frm_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SignUp));
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.lb_PassWord = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.ptb_SignUp = new System.Windows.Forms.PictureBox();
            this.ptb_Back = new System.Windows.Forms.PictureBox();
            this.ptb_BackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassWord.Location = new System.Drawing.Point(44, 378);
            this.txt_PassWord.Multiline = true;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(346, 28);
            this.txt_PassWord.TabIndex = 9;
            // 
            // lb_PassWord
            // 
            this.lb_PassWord.AutoSize = true;
            this.lb_PassWord.BackColor = System.Drawing.Color.Transparent;
            this.lb_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PassWord.ForeColor = System.Drawing.Color.White;
            this.lb_PassWord.Location = new System.Drawing.Point(45, 348);
            this.lb_PassWord.Name = "lb_PassWord";
            this.lb_PassWord.Size = new System.Drawing.Size(78, 16);
            this.lb_PassWord.TabIndex = 8;
            this.lb_PassWord.Text = "Pass Word:";
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(44, 307);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(346, 28);
            this.txt_User.TabIndex = 7;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.Color.White;
            this.lb_User.Location = new System.Drawing.Point(45, 277);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(80, 16);
            this.lb_User.TabIndex = 6;
            this.lb_User.Text = "User Name:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(44, 452);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(346, 28);
            this.txt_Email.TabIndex = 11;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.White;
            this.lb_Email.Location = new System.Drawing.Point(45, 422);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(45, 16);
            this.lb_Email.TabIndex = 10;
            this.lb_Email.Text = "Email:";
            // 
            // ptb_SignUp
            // 
            this.ptb_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.ptb_SignUp.Image = global::Appp.Properties.Resources.SignUp_2;
            this.ptb_SignUp.Location = new System.Drawing.Point(144, 512);
            this.ptb_SignUp.Name = "ptb_SignUp";
            this.ptb_SignUp.Size = new System.Drawing.Size(136, 44);
            this.ptb_SignUp.TabIndex = 12;
            this.ptb_SignUp.TabStop = false;
            // 
            // ptb_Back
            // 
            this.ptb_Back.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Back.Image = global::Appp.Properties.Resources.Back;
            this.ptb_Back.Location = new System.Drawing.Point(12, 12);
            this.ptb_Back.Name = "ptb_Back";
            this.ptb_Back.Size = new System.Drawing.Size(64, 22);
            this.ptb_Back.TabIndex = 2;
            this.ptb_Back.TabStop = false;
            this.ptb_Back.Click += new System.EventHandler(this.ptb_Back_Click);
            // 
            // ptb_BackGround
            // 
            this.ptb_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_BackGround.Image = global::Appp.Properties.Resources._11;
            this.ptb_BackGround.Location = new System.Drawing.Point(0, 0);
            this.ptb_BackGround.Name = "ptb_BackGround";
            this.ptb_BackGround.Size = new System.Drawing.Size(435, 683);
            this.ptb_BackGround.TabIndex = 0;
            this.ptb_BackGround.TabStop = false;
            // 
            // Frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 683);
            this.Controls.Add(this.ptb_SignUp);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.lb_PassWord);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.ptb_Back);
            this.Controls.Add(this.ptb_BackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SignUp";
            this.Text = "Đăng Kí";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_BackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_BackGround;
        private System.Windows.Forms.PictureBox ptb_Back;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Label lb_PassWord;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.PictureBox ptb_SignUp;
    }
}