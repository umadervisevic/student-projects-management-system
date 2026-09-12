namespace Studentska.WinApp.Added
{
    partial class frmPretraga
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
            txtPretraga = new TextBox();
            label1 = new Label();
            cmbStatus = new ComboBox();
            label2 = new Label();
            btnNoviProjekat = new Button();
            btnNovaPrijava = new Button();
            dgvPretraga = new DataGridView();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Naziv = new DataGridViewTextBoxColumn();
            RokZavrsetka = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DatumPrijave = new DataGridViewTextBoxColumn();
            DatumPromjeneStatusa = new DataGridViewTextBoxColumn();
            Stanje = new DataGridViewTextBoxColumn();
            Arhiviraj = new DataGridViewButtonColumn();
            btnPrint = new Button();
            label3 = new Label();
            cmbStanje = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 40);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(381, 27);
            txtPretraga.TabIndex = 0;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(277, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime i prezime studenta ili naziv projekta:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Sve", "PODNESENA", "PRIHVACENA", "ODBIJENA", "ZAVRSENA" });
            cmbStatus.Location = new Point(399, 39);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(172, 28);
            cmbStatus.TabIndex = 2;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 17);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Status prijave:";
            // 
            // btnNoviProjekat
            // 
            btnNoviProjekat.Location = new Point(918, 38);
            btnNoviProjekat.Name = "btnNoviProjekat";
            btnNoviProjekat.Size = new Size(166, 29);
            btnNoviProjekat.TabIndex = 3;
            btnNoviProjekat.Text = "Novi projekat";
            btnNoviProjekat.UseVisualStyleBackColor = true;
            btnNoviProjekat.Click += btnNoviProjekat_Click;
            // 
            // btnNovaPrijava
            // 
            btnNovaPrijava.Location = new Point(1090, 38);
            btnNovaPrijava.Name = "btnNovaPrijava";
            btnNovaPrijava.Size = new Size(166, 29);
            btnNovaPrijava.TabIndex = 4;
            btnNovaPrijava.Text = "Nova prijava";
            btnNovaPrijava.UseVisualStyleBackColor = true;
            btnNovaPrijava.Click += btnNovaPrijava_Click;
            // 
            // dgvPretraga
            // 
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Naziv, RokZavrsetka, Status, DatumPrijave, DatumPromjeneStatusa, Stanje, Arhiviraj });
            dgvPretraga.Location = new Point(12, 73);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.Size = new Size(1244, 319);
            dgvPretraga.TabIndex = 5;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
            dgvPretraga.CellDoubleClick += dgvPretraga_CellDoubleClick;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "Student";
            IndeksImePrezime.MinimumWidth = 6;
            IndeksImePrezime.Name = "IndeksImePrezime";
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Projekat";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            // 
            // RokZavrsetka
            // 
            RokZavrsetka.DataPropertyName = "RokZavrsetka";
            RokZavrsetka.HeaderText = "Rok završetka";
            RokZavrsetka.MinimumWidth = 6;
            RokZavrsetka.Name = "RokZavrsetka";
            RokZavrsetka.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status prijave";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // DatumPrijave
            // 
            DatumPrijave.DataPropertyName = "DatumPrijave";
            DatumPrijave.HeaderText = "Prijavljen";
            DatumPrijave.MinimumWidth = 6;
            DatumPrijave.Name = "DatumPrijave";
            DatumPrijave.Width = 125;
            // 
            // DatumPromjeneStatusa
            // 
            DatumPromjeneStatusa.DataPropertyName = "DatumPromjeneStatusa";
            DatumPromjeneStatusa.HeaderText = "Promjena";
            DatumPromjeneStatusa.MinimumWidth = 6;
            DatumPromjeneStatusa.Name = "DatumPromjeneStatusa";
            DatumPromjeneStatusa.Width = 125;
            // 
            // Stanje
            // 
            Stanje.DataPropertyName = "Stanje";
            Stanje.HeaderText = "Stanje prijave";
            Stanje.MinimumWidth = 6;
            Stanje.Name = "Stanje";
            Stanje.Width = 125;
            // 
            // Arhiviraj
            // 
            Arhiviraj.DataPropertyName = "Arhiviraj";
            Arhiviraj.HeaderText = "";
            Arhiviraj.MinimumWidth = 6;
            Arhiviraj.Name = "Arhiviraj";
            Arhiviraj.Text = "Arhiviraj";
            Arhiviraj.UseColumnTextForButtonValue = true;
            Arhiviraj.Width = 125;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1090, 395);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(166, 29);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 17);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 1;
            label3.Text = "Stanje prijave:";
            // 
            // cmbStanje
            // 
            cmbStanje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStanje.FormattingEnabled = true;
            cmbStanje.Items.AddRange(new object[] { "Sve", "Aktivna", "Arhivirana" });
            cmbStanje.Location = new Point(577, 39);
            cmbStanje.Name = "cmbStanje";
            cmbStanje.Size = new Size(172, 28);
            cmbStanje.TabIndex = 2;
            cmbStanje.SelectedIndexChanged += cmbStanje_SelectedIndexChanged;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 428);
            Controls.Add(btnPrint);
            Controls.Add(dgvPretraga);
            Controls.Add(btnNovaPrijava);
            Controls.Add(btnNoviProjekat);
            Controls.Add(cmbStanje);
            Controls.Add(label3);
            Controls.Add(cmbStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPretraga);
            Name = "frmPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga prijava na projekte";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPretraga;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private Button btnNoviProjekat;
        private Button btnNovaPrijava;
        private DataGridView dgvPretraga;
        private Button btnPrint;
        private Label label3;
        private ComboBox cmbStanje;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn RokZavrsetka;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DatumPrijave;
        private DataGridViewTextBoxColumn DatumPromjeneStatusa;
        private DataGridViewTextBoxColumn Stanje;
        private DataGridViewButtonColumn Arhiviraj;
    }
}