namespace UI
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_server = new System.Windows.Forms.TextBox();
            this.txtbox_database = new System.Windows.Forms.TextBox();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_target = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(548, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(548, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veri Tabanı:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(548, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(548, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // txtbox_server
            // 
            this.txtbox_server.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_server.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_server.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_server.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtbox_server.Location = new System.Drawing.Point(548, 186);
            this.txtbox_server.Name = "txtbox_server";
            this.txtbox_server.Size = new System.Drawing.Size(292, 37);
            this.txtbox_server.TabIndex = 1;
            this.txtbox_server.Text = "localhost";
            this.txtbox_server.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_server_KeyDown);
            // 
            // txtbox_database
            // 
            this.txtbox_database.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_database.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_database.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_database.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtbox_database.Location = new System.Drawing.Point(548, 265);
            this.txtbox_database.Name = "txtbox_database";
            this.txtbox_database.Size = new System.Drawing.Size(292, 37);
            this.txtbox_database.TabIndex = 2;
            this.txtbox_database.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_database_KeyDown);
            // 
            // txtbox_username
            // 
            this.txtbox_username.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_username.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_username.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtbox_username.Location = new System.Drawing.Point(548, 344);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(292, 37);
            this.txtbox_username.TabIndex = 3;
            this.txtbox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_username_KeyDown);
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_password.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_password.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtbox_password.Location = new System.Drawing.Point(548, 423);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(292, 37);
            this.txtbox_password.TabIndex = 4;
            this.txtbox_password.UseSystemPasswordChar = true;
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_password_KeyDown);
            // 
            // btn_target
            // 
            this.btn_target.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_target.FlatAppearance.BorderSize = 0;
            this.btn_target.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_target.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_target.ForeColor = System.Drawing.Color.Tomato;
            this.btn_target.Location = new System.Drawing.Point(548, 466);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(292, 105);
            this.btn_target.TabIndex = 5;
            this.btn_target.Text = "Bağlantı Kur";
            this.btn_target.UseVisualStyleBackColor = false;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_change.FlatAppearance.BorderSize = 0;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_change.ForeColor = System.Drawing.Color.Tomato;
            this.btn_change.Location = new System.Drawing.Point(1076, 640);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(292, 105);
            this.btn_change.TabIndex = 7;
            this.btn_change.Text = "Yeni Veri Tabanı Oluştur";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.Tomato;
            this.btn_exit.Location = new System.Drawing.Point(12, 640);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(292, 105);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1356, 85);
            this.label5.TabIndex = 17;
            this.label5.Text = "MARKAM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1380, 757);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.txtbox_database);
            this.Controls.Add(this.txtbox_server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.Text = "Giriş Yap";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbox_server;
        private TextBox txtbox_database;
        private TextBox txtbox_username;
        private TextBox txtbox_password;
        private Button btn_target;
        private Button btn_change;
        private Button btn_exit;
        private Label label5;
    }
}