namespace Otobüs_Projesi
{
    partial class Sefer
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
            this.cmbNereden1 = new System.Windows.Forms.ComboBox();
            this.cmbNereye1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden";
            // 
            // cmbNereden1
            // 
            this.cmbNereden1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden1.FormattingEnabled = true;
            this.cmbNereden1.Items.AddRange(new object[] {
            "İstanbul ",
            "Ankara ",
            "Antalya",
            "Bursa",
            "Kayseri",
            "Ardahan",
            "Edirne",
            "Malatya",
            "Kırklareli",
            "Urfa"});
            this.cmbNereden1.Location = new System.Drawing.Point(324, 101);
            this.cmbNereden1.Name = "cmbNereden1";
            this.cmbNereden1.Size = new System.Drawing.Size(151, 28);
            this.cmbNereden1.TabIndex = 1;
            // 
            // cmbNereye1
            // 
            this.cmbNereye1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye1.FormattingEnabled = true;
            this.cmbNereye1.Items.AddRange(new object[] {
            "İstanbul ",
            "Ankara ",
            "Antalya",
            "Bursa",
            "Kayseri",
            "Ardahan",
            "Edirne",
            "Malatya",
            "Kırklareli",
            "Urfa"});
            this.cmbNereye1.Location = new System.Drawing.Point(324, 167);
            this.cmbNereye1.Name = "cmbNereye1";
            this.cmbNereye1.Size = new System.Drawing.Size(151, 28);
            this.cmbNereye1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(224, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih";
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih1.Location = new System.Drawing.Point(324, 235);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(151, 27);
            this.dtpTarih1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(381, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(224, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Otobüs";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trevago",
            "Neoplan",
            "Setra"});
            this.comboBox1.Location = new System.Drawing.Point(324, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 467);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNereye1);
            this.Controls.Add(this.cmbNereden1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sefer";
            this.Text = "Sefer";
            this.Load += new System.EventHandler(this.Sefer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbNereden1;
        public System.Windows.Forms.DateTimePicker dtpTarih1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox cmbNereye1;
    }
}