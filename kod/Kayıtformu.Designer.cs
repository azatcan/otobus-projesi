
namespace Otobüs_Projesi
{
    partial class Kayıtformu
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
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.Soyisim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.mskdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdbBay = new System.Windows.Forms.RadioButton();
            this.rdbBayan = new System.Windows.Forms.RadioButton();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(333, 61);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(173, 27);
            this.txtİsim.TabIndex = 1;
            // 
            // Soyisim
            // 
            this.Soyisim.AutoSize = true;
            this.Soyisim.Location = new System.Drawing.Point(122, 114);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(63, 20);
            this.Soyisim.TabIndex = 0;
            this.Soyisim.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(333, 114);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(173, 27);
            this.txtSoyisim.TabIndex = 1;
            // 
            // mskdTelefon
            // 
            this.mskdTelefon.Location = new System.Drawing.Point(333, 163);
            this.mskdTelefon.Mask = "(999) 000-0000";
            this.mskdTelefon.Name = "mskdTelefon";
            this.mskdTelefon.Size = new System.Drawing.Size(173, 27);
            this.mskdTelefon.TabIndex = 2;
            // 
            // rdbBay
            // 
            this.rdbBay.AutoSize = true;
            this.rdbBay.Location = new System.Drawing.Point(136, 287);
            this.rdbBay.Name = "rdbBay";
            this.rdbBay.Size = new System.Drawing.Size(56, 24);
            this.rdbBay.TabIndex = 3;
            this.rdbBay.Text = "Bay";
            this.rdbBay.UseVisualStyleBackColor = true;
            // 
            // rdbBayan
            // 
            this.rdbBayan.AutoSize = true;
            this.rdbBayan.Checked = true;
            this.rdbBayan.Location = new System.Drawing.Point(426, 287);
            this.rdbBayan.Name = "rdbBayan";
            this.rdbBayan.Size = new System.Drawing.Size(73, 24);
            this.rdbBayan.TabIndex = 4;
            this.rdbBayan.TabStop = true;
            this.rdbBayan.Text = "Bayan";
            this.rdbBayan.UseVisualStyleBackColor = true;
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(152, 345);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(106, 29);
            this.btnİptal.TabIndex = 5;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(452, 345);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(106, 29);
            this.btnTamam.TabIndex = 6;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // Kayıtformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 487);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.rdbBayan);
            this.Controls.Add(this.rdbBay);
            this.Controls.Add(this.mskdTelefon);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kayıtformu";
            this.Text = "Kayıtformu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Soyisim;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnİptal;
        public System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.TextBox txtİsim;
        public System.Windows.Forms.TextBox txtSoyisim;
        public System.Windows.Forms.MaskedTextBox mskdTelefon;
        public System.Windows.Forms.RadioButton rdbBay;
        public System.Windows.Forms.RadioButton rdbBayan;
    }
}