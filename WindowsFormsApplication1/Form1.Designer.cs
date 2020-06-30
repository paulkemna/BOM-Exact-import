namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseDebtor = new System.Windows.Forms.Button();
            this.cmbDebtorComp = new System.Windows.Forms.ComboBox();
            this.lblDebNr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReferentie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpLeverdatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exact Converter";
            // 
            // btnChooseDebtor
            // 
            this.btnChooseDebtor.Location = new System.Drawing.Point(128, 381);
            this.btnChooseDebtor.Name = "btnChooseDebtor";
            this.btnChooseDebtor.Size = new System.Drawing.Size(114, 23);
            this.btnChooseDebtor.TabIndex = 4;
            this.btnChooseDebtor.Text = "Convert";
            this.btnChooseDebtor.UseVisualStyleBackColor = true;
            this.btnChooseDebtor.Click += new System.EventHandler(this.btnChooseDebtor_Click);
            // 
            // cmbDebtorComp
            // 
            this.cmbDebtorComp.FormattingEnabled = true;
            this.cmbDebtorComp.Location = new System.Drawing.Point(33, 76);
            this.cmbDebtorComp.Name = "cmbDebtorComp";
            this.cmbDebtorComp.Size = new System.Drawing.Size(309, 21);
            this.cmbDebtorComp.TabIndex = 7;
            this.cmbDebtorComp.SelectedIndexChanged += new System.EventHandler(this.cmbDebtorComp_SelectedIndexChanged);
            // 
            // lblDebNr
            // 
            this.lblDebNr.AutoSize = true;
            this.lblDebNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebNr.Location = new System.Drawing.Point(33, 100);
            this.lblDebNr.Name = "lblDebNr";
            this.lblDebNr.Size = new System.Drawing.Size(51, 18);
            this.lblDebNr.TabIndex = 8;
            this.lblDebNr.Text = "DebNr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Debiteur";
            // 
            // txtReferentie
            // 
            this.txtReferentie.Location = new System.Drawing.Point(33, 249);
            this.txtReferentie.Name = "txtReferentie";
            this.txtReferentie.Size = new System.Drawing.Size(309, 20);
            this.txtReferentie.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Uw referentie";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(33, 334);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(309, 20);
            this.txtOmschrijving.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Omschrijving";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Leverdatum";
            // 
            // dtpLeverdatum
            // 
            this.dtpLeverdatum.Location = new System.Drawing.Point(33, 166);
            this.dtpLeverdatum.Name = "dtpLeverdatum";
            this.dtpLeverdatum.Size = new System.Drawing.Size(200, 20);
            this.dtpLeverdatum.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 416);
            this.Controls.Add(this.dtpLeverdatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReferentie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDebNr);
            this.Controls.Add(this.cmbDebtorComp);
            this.Controls.Add(this.btnChooseDebtor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseDebtor;
        private System.Windows.Forms.ComboBox cmbDebtorComp;
        private System.Windows.Forms.Label lblDebNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReferentie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpLeverdatum;
    }
}

