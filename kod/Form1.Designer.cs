
namespace Otobüs_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSefer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seferBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs seçiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Items.AddRange(new object[] {
            "Trevago",
            "Neoplan",
            "Setra"});
            this.cmbOtobus.Location = new System.Drawing.Point(951, 84);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(169, 28);
            this.cmbOtobus.TabIndex = 2;
            this.cmbOtobus.SelectedIndexChanged += new System.EventHandler(this.cmbOtobus_SelectedIndexChanged);
            // 
            // cmbNereden
            // 
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
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
            this.cmbNereden.Location = new System.Drawing.Point(126, 32);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(169, 28);
            this.cmbNereden.TabIndex = 3;
            this.cmbNereden.SelectedIndexChanged += new System.EventHandler(this.cmbNereden_SelectedIndexChanged);
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
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
            this.cmbNereye.Location = new System.Drawing.Point(126, 80);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(169, 28);
            this.cmbNereye.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nereden";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nereye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarih.Location = new System.Drawing.Point(951, 258);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(169, 27);
            this.dtpTarih.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(951, 322);
            this.nudFiyat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudFiyat.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(169, 27);
            this.nudFiyat.TabIndex = 10;
            this.nudFiyat.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(859, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNereden);
            this.groupBox1.Controls.Add(this.cmbNereye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(825, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İSTİKAMET";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 28);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // btnSefer
            // 
            this.btnSefer.Location = new System.Drawing.Point(96, 15);
            this.btnSefer.Name = "btnSefer";
            this.btnSefer.Size = new System.Drawing.Size(161, 29);
            this.btnSefer.TabIndex = 13;
            this.btnSefer.Text = "Sefer Oluştur";
            this.btnSefer.UseVisualStyleBackColor = true;
            this.btnSefer.Click += new System.EventHandler(this.btnSefer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.btnSefer);
            this.groupBox2.Location = new System.Drawing.Point(374, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 423);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader17});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(0, 50);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(357, 375);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Otobüs ad";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Nereden";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Nereye";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Tarih";
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataSource = typeof(Otobüs_Projesi.Sefer);
            // 
            // seferBindingSource1
            // 
            this.seferBindingSource1.DataSource = typeof(Otobüs_Projesi.Sefer);
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader13,
            this.columnHeader14});
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(1139, 65);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(263, 516);
            this.listView3.TabIndex = 18;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Müşteri";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Telefon";
            this.columnHeader13.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Cinsiyet";
            this.columnHeader14.Width = 70;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(1401, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 516);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nereden";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nereye";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Koltuk No";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            this.columnHeader6.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1786, 784);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOtobus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
        private System.Windows.Forms.Button btnSefer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private System.Windows.Forms.BindingSource seferBindingSource1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

