namespace UI
{
    partial class CustomerSettingsForm
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.Tomato;
            this.btn_back.Location = new System.Drawing.Point(12, 641);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(292, 105);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Geri Dön";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.Tomato;
            this.btn_save.Location = new System.Drawing.Point(1076, 640);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(292, 105);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Değişiklikleri Kaydet";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_currency
            // 
            this.cb_currency.BackColor = System.Drawing.Color.DodgerBlue;
            this.cb_currency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_currency.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_currency.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Items.AddRange(new object[] {
            "TL",
            "Dolar",
            "Euro"});
            this.cb_currency.Location = new System.Drawing.Point(545, 411);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(292, 39);
            this.cb_currency.TabIndex = 3;
            this.cb_currency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_currency_KeyDown);
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.Color.DodgerBlue;
            this.cb_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_type.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_type.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Müşteri",
            "Tedarikçi"});
            this.cb_type.Location = new System.Drawing.Point(545, 332);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(292, 39);
            this.cb_type.TabIndex = 2;
            this.cb_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_type_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(545, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "Para Birimi:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(545, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "Müşteri Türü:";
            // 
            // txtbox_customer
            // 
            this.txtbox_customer.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_customer.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_customer.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtbox_customer.Location = new System.Drawing.Point(545, 253);
            this.txtbox_customer.Name = "txtbox_customer";
            this.txtbox_customer.Size = new System.Drawing.Size(292, 37);
            this.txtbox_customer.TabIndex = 1;
            this.txtbox_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_customer_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(545, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Müşteri:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1356, 85);
            this.label5.TabIndex = 28;
            this.label5.Text = "MARKAM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1380, 757);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_currency);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CustomerSettingsForm";
            this.Text = "Müşteri Ayarlar";
            this.Load += new System.EventHandler(this.CustomerSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_back;
        private Button btn_save;
        private ComboBox cb_currency;
        private ComboBox cb_type;
        private Label label3;
        private Label label1;
        private TextBox txtbox_customer;
        private Label label2;
        private Label label5;
    }
}