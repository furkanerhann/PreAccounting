namespace UI
{
    partial class MainMenuForm
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.cb_balance = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_totalbalance = new System.Windows.Forms.Button();
            this.btn_operations = new System.Windows.Forms.Button();
            this.lbl_selected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
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
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Geri Dön";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtbox_search
            // 
            this.txtbox_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_search.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_search.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtbox_search.Location = new System.Drawing.Point(499, 12);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.PlaceholderText = "Arama";
            this.txtbox_search.Size = new System.Drawing.Size(869, 37);
            this.txtbox_search.TabIndex = 1;
            this.txtbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_search_KeyDown);
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.Color.DodgerBlue;
            this.cb_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_type.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_type.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Hepsi",
            "Müşteriler",
            "Tedarikçiler"});
            this.cb_type.Location = new System.Drawing.Point(499, 55);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(202, 39);
            this.cb_type.TabIndex = 2;
            this.cb_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_type_KeyDown);
            // 
            // cb_currency
            // 
            this.cb_currency.BackColor = System.Drawing.Color.DodgerBlue;
            this.cb_currency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_currency.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_currency.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Items.AddRange(new object[] {
            "Hepsi",
            "TL",
            "Dolar",
            "Euro"});
            this.cb_currency.Location = new System.Drawing.Point(707, 55);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(202, 39);
            this.cb_currency.TabIndex = 3;
            this.cb_currency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_currency_KeyDown);
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
            "Borçlular",
            "Alacaklılar"});
            this.cb_balance.Location = new System.Drawing.Point(915, 55);
            this.cb_balance.Name = "cb_balance";
            this.cb_balance.Size = new System.Drawing.Size(202, 39);
            this.cb_balance.TabIndex = 4;
            this.cb_balance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_balance_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.Tomato;
            this.btn_search.Location = new System.Drawing.Point(1123, 55);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(245, 39);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Arama Yap";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.dataview.TabIndex = 15;
            this.dataview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 85);
            this.label1.TabIndex = 16;
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
            this.btn_add.Location = new System.Drawing.Point(12, 264);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(279, 76);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Müşteri Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_delete.Location = new System.Drawing.Point(12, 346);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(279, 76);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Müşteri Sil";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_totalbalance
            // 
            this.btn_totalbalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_totalbalance.FlatAppearance.BorderSize = 0;
            this.btn_totalbalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_totalbalance.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_totalbalance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_totalbalance.Location = new System.Drawing.Point(12, 182);
            this.btn_totalbalance.Name = "btn_totalbalance";
            this.btn_totalbalance.Size = new System.Drawing.Size(279, 76);
            this.btn_totalbalance.TabIndex = 7;
            this.btn_totalbalance.Text = "Toplam Bakiye";
            this.btn_totalbalance.UseVisualStyleBackColor = false;
            this.btn_totalbalance.Click += new System.EventHandler(this.btn_totalbalance_Click);
            // 
            // btn_operations
            // 
            this.btn_operations.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_operations.FlatAppearance.BorderSize = 0;
            this.btn_operations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_operations.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_operations.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_operations.Location = new System.Drawing.Point(12, 100);
            this.btn_operations.Name = "btn_operations";
            this.btn_operations.Size = new System.Drawing.Size(279, 76);
            this.btn_operations.TabIndex = 6;
            this.btn_operations.Text = "Müşteri İşlemleri";
            this.btn_operations.UseVisualStyleBackColor = false;
            this.btn_operations.Click += new System.EventHandler(this.btn_operations_Click);
            // 
            // lbl_selected
            // 
            this.lbl_selected.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_selected.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_selected.Location = new System.Drawing.Point(12, 425);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(279, 37);
            this.lbl_selected.TabIndex = 32;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1380, 757);
            this.Controls.Add(this.lbl_selected);
            this.Controls.Add(this.btn_operations);
            this.Controls.Add(this.btn_totalbalance);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_balance);
            this.Controls.Add(this.cb_currency);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenuForm";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenuForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_exit;
        private Button btn_back;
        private TextBox txtbox_search;
        private ComboBox cb_type;
        private ComboBox cb_currency;
        private ComboBox cb_balance;
        private Button btn_search;
        private DataGridView dataview;
        private Label label1;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_totalbalance;
        private Button btn_operations;
        private Label lbl_selected;
    }
}