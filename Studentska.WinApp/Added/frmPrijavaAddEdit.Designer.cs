namespace Studentska.WinApp.Added
{
    partial class frmPrijavaAddEdit
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
            label1 = new Label();
            cmbStudenti = new ComboBox();
            label2 = new Label();
            cmbProjekti = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbStatus = new ComboBox();
            btnSacuvaj = new Button();
            btnGenerisiPrijave = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            dtpDatumPrijave = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // cmbStudenti
            // 
            cmbStudenti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(12, 37);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(348, 28);
            cmbStudenti.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 14);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Projekat:";
            // 
            // cmbProjekti
            // 
            cmbProjekti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjekti.FormattingEnabled = true;
            cmbProjekti.Location = new Point(388, 37);
            cmbProjekti.Name = "cmbProjekti";
            cmbProjekti.Size = new Size(348, 28);
            cmbProjekti.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 0;
            label3.Text = "Datum prijave:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 84);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "ZAVRSENA" });
            cmbStatus.Location = new Point(388, 107);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(348, 28);
            cmbStatus.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(577, 156);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(159, 29);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnGenerisiPrijave
            // 
            btnGenerisiPrijave.Location = new Point(12, 156);
            btnGenerisiPrijave.Name = "btnGenerisiPrijave";
            btnGenerisiPrijave.Size = new Size(175, 29);
            btnGenerisiPrijave.TabIndex = 3;
            btnGenerisiPrijave.Text = "Generisi prijave";
            btnGenerisiPrijave.UseVisualStyleBackColor = true;
            btnGenerisiPrijave.Click += btnGenerisiPrijave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Location = new Point(12, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 262);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 26);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(712, 230);
            txtInfo.TabIndex = 0;
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(12, 108);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(348, 27);
            dtpDatumPrijave.TabIndex = 5;
            // 
            // frmPrijavaAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 473);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(groupBox1);
            Controls.Add(btnGenerisiPrijave);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbStatus);
            Controls.Add(cmbProjekti);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cmbStudenti);
            Controls.Add(label1);
            Name = "frmPrijavaAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_3BrojIndeksa";
            Load += frmPrijavaAddEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStudenti;
        private Label label2;
        private ComboBox cmbProjekti;
        private Label label3;
        private Label label4;
        private ComboBox cmbStatus;
        private Button btnSacuvaj;
        private Button btnGenerisiPrijave;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private DateTimePicker dtpDatumPrijave;
    }
}