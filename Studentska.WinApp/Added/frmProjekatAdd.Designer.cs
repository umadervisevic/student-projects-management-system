namespace Studentska.WinApp.Added
{
    partial class frmProjekatAdd
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbLogo = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnSacuvaj = new Button();
            cbAktivan = new CheckBox();
            txtNapomena = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtNaziv = new TextBox();
            dtpRokZavrsetka = new DateTimePicker();
            label2 = new Label();
            txtMaxBroj = new TextBox();
            label4 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 14);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Naziv:";
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(12, 37);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(236, 253);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(597, 261);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(134, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(651, 220);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(80, 24);
            cbAktivan.TabIndex = 5;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(254, 106);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(477, 71);
            txtNapomena.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 83);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "Napomena:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 14);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 1;
            label5.Text = "Logo:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(254, 37);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(477, 27);
            txtNaziv.TabIndex = 0;
            // 
            // dtpRokZavrsetka
            // 
            dtpRokZavrsetka.Location = new Point(254, 220);
            dtpRokZavrsetka.Name = "dtpRokZavrsetka";
            dtpRokZavrsetka.Size = new Size(184, 27);
            dtpRokZavrsetka.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 197);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Rok zavrsetka:";
            // 
            // txtMaxBroj
            // 
            txtMaxBroj.Location = new Point(444, 220);
            txtMaxBroj.Name = "txtMaxBroj";
            txtMaxBroj.Size = new Size(201, 27);
            txtMaxBroj.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 197);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 1;
            label4.Text = "Maksimalno studenata:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmProjekatAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 303);
            Controls.Add(dtpRokZavrsetka);
            Controls.Add(cbAktivan);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbLogo);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtMaxBroj);
            Controls.Add(txtNaziv);
            Controls.Add(txtNapomena);
            Name = "frmProjekatAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projekat";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private PictureBox pbLogo;
        private OpenFileDialog openFileDialog1;
        private Button btnSacuvaj;
        private CheckBox cbAktivan;
        private TextBox txtNapomena;
        private TextBox textBox4;
        private Label label3;
        private Label label5;
        private TextBox txtNaziv;
        private DateTimePicker dtpRokZavrsetka;
        private Label label2;
        private TextBox txtMaxBroj;
        private Label label4;
        private ErrorProvider err;
    }
}