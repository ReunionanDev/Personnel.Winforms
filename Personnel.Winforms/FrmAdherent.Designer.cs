namespace Personnel.Winforms
{
    partial class FrmAdherent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label adherentIDLabel;
            this.AdherentEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.txtDebNom = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtAdherentID = new System.Windows.Forms.TextBox();
            this.gbBoutonOpe = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.adherentIDTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            adherentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.gbRecherche.SuspendLayout();
            this.gbBoutonOpe.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 21);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 13);
            label1.TabIndex = 7;
            label1.Text = "Par son identfiant :";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(14, 51);
            nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(108, 13);
            nomLabel.TabIndex = 7;
            nomLabel.Text = "Par le début du nom :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(14, 76);
            prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 8;
            prenomLabel.Text = "Prenom:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 54);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 6;
            label2.Text = "Nom :";
            // 
            // adherentIDLabel
            // 
            adherentIDLabel.AutoSize = true;
            adherentIDLabel.Location = new System.Drawing.Point(14, 30);
            adherentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            adherentIDLabel.Name = "adherentIDLabel";
            adherentIDLabel.Size = new System.Drawing.Size(59, 13);
            adherentIDLabel.TabIndex = 6;
            adherentIDLabel.Text = "Identifiant :";
            // 
            // AdherentEP
            // 
            this.AdherentEP.ContainerControl = this;
            this.AdherentEP.DataSource = this.adherentBindingSource;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Personnel.BOL.Employee);
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(label1);
            this.gbRecherche.Controls.Add(nomLabel);
            this.gbRecherche.Controls.Add(this.txtDebNom);
            this.gbRecherche.Controls.Add(this.btnRechercher);
            this.gbRecherche.Controls.Add(this.txtAdherentID);
            this.gbRecherche.Location = new System.Drawing.Point(125, 6);
            this.gbRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Padding = new System.Windows.Forms.Padding(2);
            this.gbRecherche.Size = new System.Drawing.Size(346, 119);
            this.gbRecherche.TabIndex = 3;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Identifier l\'adhérent";
            // 
            // txtDebNom
            // 
            this.txtDebNom.Location = new System.Drawing.Point(130, 49);
            this.txtDebNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebNom.Name = "txtDebNom";
            this.txtDebNom.Size = new System.Drawing.Size(138, 20);
            this.txtDebNom.TabIndex = 1;
            this.txtDebNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebNom_KeyDown);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(16, 82);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(79, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtAdherentID
            // 
            this.txtAdherentID.Location = new System.Drawing.Point(130, 17);
            this.txtAdherentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdherentID.Name = "txtAdherentID";
            this.txtAdherentID.Size = new System.Drawing.Size(101, 20);
            this.txtAdherentID.TabIndex = 0;
            this.txtAdherentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdherentID_KeyDown);
            // 
            // gbBoutonOpe
            // 
            this.gbBoutonOpe.Controls.Add(this.btnAnnuler);
            this.gbBoutonOpe.Controls.Add(this.btnValider);
            this.gbBoutonOpe.Controls.Add(this.btnNouveau);
            this.gbBoutonOpe.Controls.Add(this.btnEditer);
            this.gbBoutonOpe.Location = new System.Drawing.Point(125, 307);
            this.gbBoutonOpe.Margin = new System.Windows.Forms.Padding(2);
            this.gbBoutonOpe.Name = "gbBoutonOpe";
            this.gbBoutonOpe.Padding = new System.Windows.Forms.Padding(2);
            this.gbBoutonOpe.Size = new System.Drawing.Size(350, 52);
            this.gbBoutonOpe.TabIndex = 5;
            this.gbBoutonOpe.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(228, 17);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 21);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(160, 18);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 21);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(84, 18);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(72, 21);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(16, 18);
            this.btnEditer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(56, 21);
            this.btnEditer.TabIndex = 0;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.nomTextBox);
            this.gbDetails.Controls.Add(this.prenomTextBox);
            this.gbDetails.Controls.Add(prenomLabel);
            this.gbDetails.Controls.Add(label2);
            this.gbDetails.Controls.Add(adherentIDLabel);
            this.gbDetails.Controls.Add(this.adherentIDTextBox);
            this.gbDetails.Location = new System.Drawing.Point(125, 151);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbDetails.Size = new System.Drawing.Size(346, 121);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "LastName", true));
            this.nomTextBox.Location = new System.Drawing.Point(84, 50);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(184, 20);
            this.nomTextBox.TabIndex = 4;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "FirstName", true));
            this.prenomTextBox.Location = new System.Drawing.Point(84, 73);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(184, 20);
            this.prenomTextBox.TabIndex = 5;
            // 
            // adherentIDTextBox
            // 
            this.adherentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "EmployeeID", true));
            this.adherentIDTextBox.Location = new System.Drawing.Point(84, 28);
            this.adherentIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adherentIDTextBox.Name = "adherentIDTextBox";
            this.adherentIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.adherentIDTextBox.TabIndex = 3;
            // 
            // FrmAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.gbBoutonOpe);
            this.Controls.Add(this.gbDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdherent";
            this.Text = "Gestion Adherent";
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.gbBoutonOpe.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.ErrorProvider AdherentEP;
        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.TextBox txtDebNom;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtAdherentID;
        private System.Windows.Forms.GroupBox gbBoutonOpe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox adherentIDTextBox;
    }
}

