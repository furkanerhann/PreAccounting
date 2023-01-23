namespace UI
{
    partial class CustomerMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_balance = new System.Windows.Forms.ComboBox();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.btn_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataview.EnableHeadersVisualStyles = false;
            this.dataview.Location = new System.Drawing.Point(297, 100);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            this.dataview.RowTemplate.Height = 25;
            this.dataview.Size = new System.Drawing.Size(1071, 645);
            this.dataview.TabIndex = 18;
            this.dataview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellDoubleClick);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_back.Location = new System.Drawing.Point(12, 587);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(279, 76);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Geri Dön";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_exit.Location = new System.Drawing.Point(12, 669);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(279, 76);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_settings.Location = new System.Drawing.Point(12, 157);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(279, 76);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "Müşteri Ayarları";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 85);
            this.label1.TabIndex = 20;
            this.label1.Text = "MARKAM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_add.Location = new System.Drawing.Point(12, 239);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(279, 76);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Yeni İşlem Yap";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_update.Location = new System.Drawing.Point(12, 321);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(279, 76);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "İşlem Düzenle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_delete.Location = new System.Drawing.Point(12, 403);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(279, 76);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "İşlem Sil";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_customer
            // 
            this.lbl_customer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_customer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_customer.Location = new System.Drawing.Point(12, 94);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(279, 29);
            this.lbl_customer.TabIndex = 24;
            this.lbl_customer.Text = "Müşteri Adı";
            // 
            // lbl_balance
            // 
            this.lbl_balance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_balance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_balance.Location = new System.Drawing.Point(12, 123);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(279, 31);
            this.lbl_balance.TabIndex = 25;
            this.lbl_balance.Text = "Bakiye";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.Tomato;
            this.btn_search.Location = new System.Drawing.Point(1123, 52);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(245, 39);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Arama Yap";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_balance
            // 
            this.cb_balance.BackColor = System.Drawing.Color.DodgerBlue;
            this.cb_balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_balance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_balance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cb_balance.FormattingEnabled = true;
            this.cb_balance.Items.AddRange(new object[] {
            "Hepsi",
            "Borçlanmalar",
            "Ödemeler"});
            this.cb_balance.Location = new System.Drawing.Point(811, 52);
            this.cb_balance.Name = "cb_balance";
            this.cb_balance.Size = new System.Drawing.Size(306, 39);
            this.cb_balance.TabIndex = 2;
            this.cb_balance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_balance_KeyDown);
            // 
            // cb_date
            // 
            this.cb_date.BackColor = System.Drawing.Color.DodgerBlue;
            this.cb_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_date.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_date.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Items.AddRange(new object[] {
            "Hepsi",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.cb_date.Location = new System.Drawing.Point(499, 52);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(306, 39);
            this.cb_date.TabIndex = 1;
            this.cb_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_date_KeyDown);
            // 
            // lbl_selected
            // 
            this.lbl_selected.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_selected.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_selected.Location = new System.Drawing.Point(12, 482);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(279, 37);
            this.lbl_selected.TabIndex = 31;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pdf.FlatAppearance.BorderSize = 0;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdf.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pdf.ForeColor = System.Drawing.Color.Tomato;
            this.btn_pdf.Location = new System.Drawing.Point(1123, 7);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(245, 39);
            this.btn_pdf.TabIndex = 10;
            this.btn_pdf.Text = "PDF Yazdir";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // CustomerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1380, 757);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.lbl_selected);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_balance);
            this.Controls.Add(this.cb_date);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CustomerMenuForm";
            this.Text = "Müşteri Menüsü";
            this.Load += new System.EventHandler(this.CustomerMenuForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerMenuForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataview;
        private Button btn_back;
        private Button btn_exit;
        private Button btn_settings;
        private Label label1;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label lbl_customer;
        private Label lbl_balance;
        private Button btn_search;
        private ComboBox cb_balance;
        private ComboBox cb_date;
        private Label lbl_selected;
        private Button btn_pdf;
    }
}