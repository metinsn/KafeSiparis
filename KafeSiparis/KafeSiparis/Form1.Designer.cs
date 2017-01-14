namespace KafeSiparis
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmBoxYemek = new System.Windows.Forms.ComboBox();
            this.cmBoxIcecek = new System.Windows.Forms.ComboBox();
            this.numYemekMiktar = new System.Windows.Forms.NumericUpDown();
            this.numIcecekMiktar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lstBoxSiparisler = new System.Windows.Forms.ListBox();
            this.gboxOdemeTipi = new System.Windows.Forms.GroupBox();
            this.rbtnTL = new System.Windows.Forms.RadioButton();
            this.rbtnEuro = new System.Windows.Forms.RadioButton();
            this.rbtnUSD = new System.Windows.Forms.RadioButton();
            this.btnOde = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYemekMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIcecekMiktar)).BeginInit();
            this.gboxOdemeTipi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSiparisVer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numIcecekMiktar);
            this.groupBox2.Controls.Add(this.numYemekMiktar);
            this.groupBox2.Controls.Add(this.cmBoxYemek);
            this.groupBox2.Controls.Add(this.cmBoxIcecek);
            this.groupBox2.Location = new System.Drawing.Point(0, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş";
            // 
            // cmBoxYemek
            // 
            this.cmBoxYemek.FormattingEnabled = true;
            this.cmBoxYemek.Items.AddRange(new object[] {
            "Kuru Fasulye",
            "Tavuklu Pilav",
            "Pizza",
            "Hamburger",
            "Tost"});
            this.cmBoxYemek.Location = new System.Drawing.Point(6, 40);
            this.cmBoxYemek.Name = "cmBoxYemek";
            this.cmBoxYemek.Size = new System.Drawing.Size(121, 21);
            this.cmBoxYemek.TabIndex = 2;
            // 
            // cmBoxIcecek
            // 
            this.cmBoxIcecek.FormattingEnabled = true;
            this.cmBoxIcecek.Items.AddRange(new object[] {
            "Cola",
            "Fanta",
            "Çay",
            "Su",
            "Kahve"});
            this.cmBoxIcecek.Location = new System.Drawing.Point(6, 80);
            this.cmBoxIcecek.Name = "cmBoxIcecek";
            this.cmBoxIcecek.Size = new System.Drawing.Size(121, 21);
            this.cmBoxIcecek.TabIndex = 3;
            // 
            // numYemekMiktar
            // 
            this.numYemekMiktar.Location = new System.Drawing.Point(133, 40);
            this.numYemekMiktar.Name = "numYemekMiktar";
            this.numYemekMiktar.Size = new System.Drawing.Size(53, 20);
            this.numYemekMiktar.TabIndex = 4;
            // 
            // numIcecekMiktar
            // 
            this.numIcecekMiktar.Location = new System.Drawing.Point(133, 81);
            this.numIcecekMiktar.Name = "numIcecekMiktar";
            this.numIcecekMiktar.Size = new System.Drawing.Size(53, 20);
            this.numIcecekMiktar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yemek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "İçecek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miktar";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(6, 120);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(180, 23);
            this.btnSiparisVer.TabIndex = 2;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            // 
            // lstBoxSiparisler
            // 
            this.lstBoxSiparisler.FormattingEnabled = true;
            this.lstBoxSiparisler.Location = new System.Drawing.Point(208, 12);
            this.lstBoxSiparisler.Name = "lstBoxSiparisler";
            this.lstBoxSiparisler.Size = new System.Drawing.Size(254, 303);
            this.lstBoxSiparisler.TabIndex = 2;
            // 
            // gboxOdemeTipi
            // 
            this.gboxOdemeTipi.Controls.Add(this.rbtnUSD);
            this.gboxOdemeTipi.Controls.Add(this.rbtnEuro);
            this.gboxOdemeTipi.Controls.Add(this.rbtnTL);
            this.gboxOdemeTipi.Location = new System.Drawing.Point(208, 321);
            this.gboxOdemeTipi.Name = "gboxOdemeTipi";
            this.gboxOdemeTipi.Size = new System.Drawing.Size(254, 61);
            this.gboxOdemeTipi.TabIndex = 3;
            this.gboxOdemeTipi.TabStop = false;
            this.gboxOdemeTipi.Text = "Ödeme Tipi";
            // 
            // rbtnTL
            // 
            this.rbtnTL.AutoSize = true;
            this.rbtnTL.Checked = true;
            this.rbtnTL.Location = new System.Drawing.Point(16, 24);
            this.rbtnTL.Name = "rbtnTL";
            this.rbtnTL.Size = new System.Drawing.Size(38, 17);
            this.rbtnTL.TabIndex = 0;
            this.rbtnTL.TabStop = true;
            this.rbtnTL.Text = "TL";
            this.rbtnTL.UseVisualStyleBackColor = true;
            // 
            // rbtnEuro
            // 
            this.rbtnEuro.AutoSize = true;
            this.rbtnEuro.Location = new System.Drawing.Point(99, 24);
            this.rbtnEuro.Name = "rbtnEuro";
            this.rbtnEuro.Size = new System.Drawing.Size(56, 17);
            this.rbtnEuro.TabIndex = 1;
            this.rbtnEuro.Text = "EURO";
            this.rbtnEuro.UseVisualStyleBackColor = true;
            // 
            // rbtnUSD
            // 
            this.rbtnUSD.AutoSize = true;
            this.rbtnUSD.Location = new System.Drawing.Point(190, 24);
            this.rbtnUSD.Name = "rbtnUSD";
            this.rbtnUSD.Size = new System.Drawing.Size(48, 17);
            this.rbtnUSD.TabIndex = 2;
            this.rbtnUSD.Text = "USD";
            this.rbtnUSD.UseVisualStyleBackColor = true;
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(208, 388);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(254, 35);
            this.btnOde.TabIndex = 4;
            this.btnOde.Text = "Ödeme";
            this.btnOde.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(468, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "EURO   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(468, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "TARİH  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(468, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DOLAR :";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(523, 52);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(0, 13);
            this.lblDolar.TabIndex = 10;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(523, 29);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 13);
            this.lblTarih.TabIndex = 9;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(523, 76);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(0, 13);
            this.lblEuro.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 432);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.gboxOdemeTipi);
            this.Controls.Add(this.lstBoxSiparisler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYemekMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIcecekMiktar)).EndInit();
            this.gboxOdemeTipi.ResumeLayout(false);
            this.gboxOdemeTipi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numIcecekMiktar;
        private System.Windows.Forms.NumericUpDown numYemekMiktar;
        private System.Windows.Forms.ComboBox cmBoxYemek;
        private System.Windows.Forms.ComboBox cmBoxIcecek;
        private System.Windows.Forms.ListBox lstBoxSiparisler;
        private System.Windows.Forms.GroupBox gboxOdemeTipi;
        private System.Windows.Forms.RadioButton rbtnUSD;
        private System.Windows.Forms.RadioButton rbtnEuro;
        private System.Windows.Forms.RadioButton rbtnTL;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblEuro;
    }
}

