﻿
namespace EDnevnik
{
    partial class Login
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(172, 50);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 22);
            this.txt_name.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(172, 85);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(180, 22);
            this.txt_pass.TabIndex = 1;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(141, 9);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(248, 17);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Dobrodosli! Da bi ste nastavili unesite:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(84, 53);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 17);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "E-mail";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(84, 90);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(57, 17);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Lozinka";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(204, 171);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(120, 28);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Login";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 268);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_ok;
    }
}