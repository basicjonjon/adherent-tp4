namespace Adherent_TP3
{
    partial class FrmGestionAdherents
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBAdherents = new System.Windows.Forms.ListBox();
            this.rdbAdherent = new System.Windows.Forms.RadioButton();
            this.rdbGestionnaire = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabCAdherentGestionnaire = new System.Windows.Forms.TabControl();
            this.tabPAdherent = new System.Windows.Forms.TabPage();
            this.btModifMail = new System.Windows.Forms.Button();
            this.txtMailA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPGestionnaire = new System.Windows.Forms.TabPage();
            this.txtDateNaissG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSupAdherent = new System.Windows.Forms.Button();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btAjoutAdherent = new System.Windows.Forms.Button();
            this.txtMailG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabCAdherentGestionnaire.SuspendLayout();
            this.tabPAdherent.SuspendLayout();
            this.tabPGestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBAdherents
            // 
            this.listBAdherents.FormattingEnabled = true;
            this.listBAdherents.Location = new System.Drawing.Point(63, 64);
            this.listBAdherents.Name = "listBAdherents";
            this.listBAdherents.Size = new System.Drawing.Size(194, 355);
            this.listBAdherents.TabIndex = 0;
            this.listBAdherents.SelectedIndexChanged += new System.EventHandler(this.listBAdherents_SelectedIndexChanged);
            // 
            // rdbAdherent
            // 
            this.rdbAdherent.AutoSize = true;
            this.rdbAdherent.Checked = true;
            this.rdbAdherent.Location = new System.Drawing.Point(35, 16);
            this.rdbAdherent.Name = "rdbAdherent";
            this.rdbAdherent.Size = new System.Drawing.Size(68, 17);
            this.rdbAdherent.TabIndex = 1;
            this.rdbAdherent.TabStop = true;
            this.rdbAdherent.Text = "Adhérent";
            this.rdbAdherent.UseVisualStyleBackColor = true;
            this.rdbAdherent.CheckedChanged += new System.EventHandler(this.rdbAdherent_CheckedChanged);
            // 
            // rdbGestionnaire
            // 
            this.rdbGestionnaire.AutoSize = true;
            this.rdbGestionnaire.Location = new System.Drawing.Point(155, 16);
            this.rdbGestionnaire.Name = "rdbGestionnaire";
            this.rdbGestionnaire.Size = new System.Drawing.Size(84, 17);
            this.rdbGestionnaire.TabIndex = 2;
            this.rdbGestionnaire.Text = "Gestionnaire";
            this.rdbGestionnaire.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGestionnaire);
            this.groupBox1.Controls.Add(this.rdbAdherent);
            this.groupBox1.Location = new System.Drawing.Point(60, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir un rôle";
            // 
            // tabCAdherentGestionnaire
            // 
            this.tabCAdherentGestionnaire.Controls.Add(this.tabPAdherent);
            this.tabCAdherentGestionnaire.Controls.Add(this.tabPGestionnaire);
            this.tabCAdherentGestionnaire.Location = new System.Drawing.Point(411, 49);
            this.tabCAdherentGestionnaire.Name = "tabCAdherentGestionnaire";
            this.tabCAdherentGestionnaire.SelectedIndex = 0;
            this.tabCAdherentGestionnaire.Size = new System.Drawing.Size(296, 357);
            this.tabCAdherentGestionnaire.TabIndex = 4;
            // 
            // tabPAdherent
            // 
            this.tabPAdherent.Controls.Add(this.lblAge);
            this.tabPAdherent.Controls.Add(this.label7);
            this.tabPAdherent.Controls.Add(this.btModifMail);
            this.tabPAdherent.Controls.Add(this.txtMailA);
            this.tabPAdherent.Controls.Add(this.label3);
            this.tabPAdherent.Controls.Add(this.label2);
            this.tabPAdherent.Controls.Add(this.lblPrenom);
            this.tabPAdherent.Controls.Add(this.lblNom);
            this.tabPAdherent.Controls.Add(this.label1);
            this.tabPAdherent.Location = new System.Drawing.Point(4, 22);
            this.tabPAdherent.Name = "tabPAdherent";
            this.tabPAdherent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAdherent.Size = new System.Drawing.Size(288, 331);
            this.tabPAdherent.TabIndex = 0;
            this.tabPAdherent.Text = "Adherent";
            this.tabPAdherent.UseVisualStyleBackColor = true;
            this.tabPAdherent.Click += new System.EventHandler(this.Gestionnaire_Click);
            // 
            // btModifMail
            // 
            this.btModifMail.Location = new System.Drawing.Point(27, 199);
            this.btModifMail.Name = "btModifMail";
            this.btModifMail.Size = new System.Drawing.Size(107, 23);
            this.btModifMail.TabIndex = 6;
            this.btModifMail.Text = "Modifier le mail";
            this.btModifMail.UseVisualStyleBackColor = true;
            this.btModifMail.Click += new System.EventHandler(this.btModifMail_Click);
            // 
            // txtMailA
            // 
            this.txtMailA.Location = new System.Drawing.Point(125, 111);
            this.txtMailA.Name = "txtMailA";
            this.txtMailA.Size = new System.Drawing.Size(100, 20);
            this.txtMailA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(122, 64);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(122, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // tabPGestionnaire
            // 
            this.tabPGestionnaire.Controls.Add(this.txtDateNaissG);
            this.tabPGestionnaire.Controls.Add(this.label6);
            this.tabPGestionnaire.Controls.Add(this.btSupAdherent);
            this.tabPGestionnaire.Controls.Add(this.txtPrenom);
            this.tabPGestionnaire.Controls.Add(this.txtNom);
            this.tabPGestionnaire.Controls.Add(this.btAjoutAdherent);
            this.tabPGestionnaire.Controls.Add(this.txtMailG);
            this.tabPGestionnaire.Controls.Add(this.label4);
            this.tabPGestionnaire.Controls.Add(this.label5);
            this.tabPGestionnaire.Controls.Add(this.label8);
            this.tabPGestionnaire.Location = new System.Drawing.Point(4, 22);
            this.tabPGestionnaire.Name = "tabPGestionnaire";
            this.tabPGestionnaire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPGestionnaire.Size = new System.Drawing.Size(288, 331);
            this.tabPGestionnaire.TabIndex = 1;
            this.tabPGestionnaire.Text = "Gestionnaire";
            this.tabPGestionnaire.UseVisualStyleBackColor = true;
            // 
            // txtDateNaissG
            // 
            this.txtDateNaissG.Location = new System.Drawing.Point(165, 172);
            this.txtDateNaissG.Name = "txtDateNaissG";
            this.txtDateNaissG.Size = new System.Drawing.Size(94, 20);
            this.txtDateNaissG.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date de naissance";
            // 
            // btSupAdherent
            // 
            this.btSupAdherent.Location = new System.Drawing.Point(33, 269);
            this.btSupAdherent.Name = "btSupAdherent";
            this.btSupAdherent.Size = new System.Drawing.Size(133, 23);
            this.btSupAdherent.TabIndex = 16;
            this.btSupAdherent.Text = "Supprimer l\'adhérent sélectionné";
            this.btSupAdherent.UseVisualStyleBackColor = true;
            this.btSupAdherent.Click += new System.EventHandler(this.btSupAdherent_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(143, 76);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 15;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(143, 33);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(88, 20);
            this.txtNom.TabIndex = 14;
            // 
            // btAjoutAdherent
            // 
            this.btAjoutAdherent.Location = new System.Drawing.Point(44, 210);
            this.btAjoutAdherent.Name = "btAjoutAdherent";
            this.btAjoutAdherent.Size = new System.Drawing.Size(107, 23);
            this.btAjoutAdherent.TabIndex = 13;
            this.btAjoutAdherent.Text = "Ajouter l\'adhérent";
            this.btAjoutAdherent.UseVisualStyleBackColor = true;
            this.btAjoutAdherent.Click += new System.EventHandler(this.btAjoutAdherent_Click);
            // 
            // txtMailG
            // 
            this.txtMailG.Location = new System.Drawing.Point(143, 119);
            this.txtMailG.Name = "txtMailG";
            this.txtMailG.Size = new System.Drawing.Size(100, 20);
            this.txtMailG.TabIndex = 12;
            this.txtMailG.Text = "mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prénom : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nom : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Age : ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(140, 158);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "label9";
            // 
            // FrmGestionAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 523);
            this.Controls.Add(this.tabCAdherentGestionnaire);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBAdherents);
            this.Name = "FrmGestionAdherents";
            this.Text = "Gestion des adhérents";
            this.Load += new System.EventHandler(this.FrmGestionAdherents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCAdherentGestionnaire.ResumeLayout(false);
            this.tabPAdherent.ResumeLayout(false);
            this.tabPAdherent.PerformLayout();
            this.tabPGestionnaire.ResumeLayout(false);
            this.tabPGestionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBAdherents;
        private System.Windows.Forms.RadioButton rdbAdherent;
        private System.Windows.Forms.RadioButton rdbGestionnaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabCAdherentGestionnaire;
        private System.Windows.Forms.TabPage tabPAdherent;
        private System.Windows.Forms.Button btModifMail;
        private System.Windows.Forms.TextBox txtMailA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPGestionnaire;
        private System.Windows.Forms.Button btAjoutAdherent;
        private System.Windows.Forms.TextBox txtMailG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btSupAdherent;
        private System.Windows.Forms.TextBox txtDateNaissG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label7;
    }
}

