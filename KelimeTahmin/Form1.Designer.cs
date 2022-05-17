
namespace KelimeTahmin
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
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.btnNewGame = new DevExpress.XtraEditors.SimpleButton();
            this.questionsArea = new System.Windows.Forms.GroupBox();
            this.answerArea = new System.Windows.Forms.GroupBox();
            this.txtLetters = new DevExpress.XtraEditors.TextEdit();
            this.txtTahmin = new DevExpress.XtraEditors.TextEdit();
            this.btnHarfGir = new DevExpress.XtraEditors.SimpleButton();
            this.btnTahminEt = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblGirilenHarfler = new DevExpress.XtraEditors.LabelControl();
            this.lblKalanHak = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAyarlar = new DevExpress.XtraEditors.SimpleButton();
            this.btnMin = new DevExpress.XtraEditors.SimpleButton();
            this.lblGharf = new DevExpress.XtraEditors.LabelControl();
            this.lblAçıklama = new DevExpress.XtraEditors.LabelControl();
            this.questionsArea.SuspendLayout();
            this.answerArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLetters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTahmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(45, 53);
            this.btnNewGame.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNewGame.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnNewGame.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(637, 32);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Yeni Oyun Başlat";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // questionsArea
            // 
            this.questionsArea.Controls.Add(this.lblAçıklama);
            this.questionsArea.ForeColor = System.Drawing.Color.White;
            this.questionsArea.Location = new System.Drawing.Point(45, 107);
            this.questionsArea.Name = "questionsArea";
            this.questionsArea.Size = new System.Drawing.Size(637, 176);
            this.questionsArea.TabIndex = 1;
            this.questionsArea.TabStop = false;
            this.questionsArea.Text = "Soru Alanı";
            // 
            // answerArea
            // 
            this.answerArea.Controls.Add(this.lblGharf);
            this.answerArea.Controls.Add(this.lblKalanHak);
            this.answerArea.Controls.Add(this.lblGirilenHarfler);
            this.answerArea.Controls.Add(this.labelControl1);
            this.answerArea.Controls.Add(this.btnTahminEt);
            this.answerArea.Controls.Add(this.btnHarfGir);
            this.answerArea.Controls.Add(this.txtTahmin);
            this.answerArea.Controls.Add(this.txtLetters);
            this.answerArea.ForeColor = System.Drawing.Color.White;
            this.answerArea.Location = new System.Drawing.Point(45, 319);
            this.answerArea.Name = "answerArea";
            this.answerArea.Size = new System.Drawing.Size(637, 194);
            this.answerArea.TabIndex = 1;
            this.answerArea.TabStop = false;
            this.answerArea.Text = "Cevap Alanı";
            this.answerArea.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtLetters
            // 
            this.txtLetters.Location = new System.Drawing.Point(36, 37);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtLetters.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLetters.Properties.Appearance.Options.UseBackColor = true;
            this.txtLetters.Properties.Appearance.Options.UseFont = true;
            this.txtLetters.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetters.Size = new System.Drawing.Size(126, 22);
            this.txtLetters.TabIndex = 0;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(293, 37);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTahmin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Properties.Appearance.Options.UseBackColor = true;
            this.txtTahmin.Properties.Appearance.Options.UseFont = true;
            this.txtTahmin.Size = new System.Drawing.Size(153, 22);
            this.txtTahmin.TabIndex = 0;
            // 
            // btnHarfGir
            // 
            this.btnHarfGir.Location = new System.Drawing.Point(180, 36);
            this.btnHarfGir.LookAndFeel.SkinName = "DevExpress Style";
            this.btnHarfGir.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnHarfGir.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnHarfGir.Name = "btnHarfGir";
            this.btnHarfGir.Size = new System.Drawing.Size(93, 23);
            this.btnHarfGir.TabIndex = 1;
            this.btnHarfGir.Text = "Harf Gir";
            this.btnHarfGir.Click += new System.EventHandler(this.btnHarfGir_Click);
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(462, 36);
            this.btnTahminEt.LookAndFeel.SkinName = "DevExpress Style";
            this.btnTahminEt.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnTahminEt.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(93, 23);
            this.btnTahminEt.TabIndex = 1;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kalan Hak :";
            // 
            // lblGirilenHarfler
            // 
            this.lblGirilenHarfler.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirilenHarfler.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblGirilenHarfler.Appearance.Options.UseFont = true;
            this.lblGirilenHarfler.Appearance.Options.UseForeColor = true;
            this.lblGirilenHarfler.Location = new System.Drawing.Point(36, 86);
            this.lblGirilenHarfler.Name = "lblGirilenHarfler";
            this.lblGirilenHarfler.Size = new System.Drawing.Size(87, 16);
            this.lblGirilenHarfler.TabIndex = 2;
            this.lblGirilenHarfler.Text = "Girilen Harfler :";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHak.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblKalanHak.Appearance.Options.UseFont = true;
            this.lblKalanHak.Appearance.Options.UseForeColor = true;
            this.lblKalanHak.Location = new System.Drawing.Point(110, 125);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(7, 16);
            this.lblKalanHak.TabIndex = 3;
            this.lblKalanHak.Text = "5";
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = global::KelimeTahmin.Properties.Resources.icons8_cancel_24px;
            this.btnExit.Location = new System.Drawing.Point(690, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnExit.Size = new System.Drawing.Size(31, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.ImageOptions.Image = global::KelimeTahmin.Properties.Resources.icons8_settings_24px;
            this.btnAyarlar.Location = new System.Drawing.Point(2, 1);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAyarlar.Size = new System.Drawing.Size(31, 28);
            this.btnAyarlar.TabIndex = 2;
            this.btnAyarlar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnMin
            // 
            this.btnMin.ImageOptions.Image = global::KelimeTahmin.Properties.Resources.icons8_horizontal_line_24px_1;
            this.btnMin.Location = new System.Drawing.Point(653, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMin.Size = new System.Drawing.Size(31, 28);
            this.btnMin.TabIndex = 3;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblGharf
            // 
            this.lblGharf.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGharf.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblGharf.Appearance.Options.UseFont = true;
            this.lblGharf.Appearance.Options.UseForeColor = true;
            this.lblGharf.Location = new System.Drawing.Point(130, 86);
            this.lblGharf.Name = "lblGharf";
            this.lblGharf.Size = new System.Drawing.Size(0, 16);
            this.lblGharf.TabIndex = 4;
            // 
            // lblAçıklama
            // 
            this.lblAçıklama.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAçıklama.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblAçıklama.Appearance.Options.UseFont = true;
            this.lblAçıklama.Appearance.Options.UseForeColor = true;
            this.lblAçıklama.Location = new System.Drawing.Point(29, 81);
            this.lblAçıklama.Name = "lblAçıklama";
            this.lblAçıklama.Size = new System.Drawing.Size(0, 23);
            this.lblAçıklama.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 570);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.answerArea);
            this.Controls.Add(this.questionsArea);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulamazsın ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.questionsArea.ResumeLayout(false);
            this.questionsArea.PerformLayout();
            this.answerArea.ResumeLayout(false);
            this.answerArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLetters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTahmin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.SimpleButton btnNewGame;
        private System.Windows.Forms.GroupBox questionsArea;
        private System.Windows.Forms.GroupBox answerArea;
        private DevExpress.XtraEditors.LabelControl lblKalanHak;
        private DevExpress.XtraEditors.LabelControl lblGirilenHarfler;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTahminEt;
        private DevExpress.XtraEditors.SimpleButton btnHarfGir;
        private DevExpress.XtraEditors.TextEdit txtTahmin;
        private DevExpress.XtraEditors.TextEdit txtLetters;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAyarlar;
        private DevExpress.XtraEditors.SimpleButton btnMin;
        private DevExpress.XtraEditors.LabelControl lblGharf;
        private DevExpress.XtraEditors.LabelControl lblAçıklama;
    }
}

