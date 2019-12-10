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
            System.Windows.Forms.Label nomLbl;
            System.Windows.Forms.Label adherentIDLabel;
            System.Windows.Forms.Label DateNaissanceLabel;
            System.Windows.Forms.Label salaireLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label ArrivéeLabel;
            System.Windows.Forms.Label departLabel;
            System.Windows.Forms.Label etablissementLabel;
            System.Windows.Forms.Label roleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdherent));
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
            this.roleTextbox = new System.Windows.Forms.TextBox();
            this.etablissementTextbox = new System.Windows.Forms.TextBox();
            this.departTextbox = new System.Windows.Forms.TextBox();
            this.arriveeTextbox = new System.Windows.Forms.TextBox();
            this.TempsTextbox = new System.Windows.Forms.TextBox();
            this.salaireTextbox = new System.Windows.Forms.TextBox();
            this.DateNaissanceTextbox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.adherentIDTextBox = new System.Windows.Forms.TextBox();
            this.AfpaPic = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            nomLbl = new System.Windows.Forms.Label();
            adherentIDLabel = new System.Windows.Forms.Label();
            DateNaissanceLabel = new System.Windows.Forms.Label();
            salaireLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ArrivéeLabel = new System.Windows.Forms.Label();
            departLabel = new System.Windows.Forms.Label();
            etablissementLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.gbRecherche.SuspendLayout();
            this.gbBoutonOpe.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfpaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(15, 39);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 21);
            label1.TabIndex = 7;
            label1.Text = "Par son identfiant :";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(14, 74);
            nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(177, 21);
            nomLabel.TabIndex = 7;
            nomLabel.Text = "Par le début du nom :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(15, 102);
            prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(73, 21);
            prenomLabel.TabIndex = 8;
            prenomLabel.Text = "Prenom:";
            // 
            // nomLbl
            // 
            nomLbl.AutoSize = true;
            nomLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLbl.Location = new System.Drawing.Point(14, 62);
            nomLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomLbl.Name = "nomLbl";
            nomLbl.Size = new System.Drawing.Size(55, 21);
            nomLbl.TabIndex = 6;
            nomLbl.Text = "Nom :";
            // 
            // adherentIDLabel
            // 
            adherentIDLabel.AutoSize = true;
            adherentIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adherentIDLabel.Location = new System.Drawing.Point(12, 22);
            adherentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            adherentIDLabel.Name = "adherentIDLabel";
            adherentIDLabel.Size = new System.Drawing.Size(100, 21);
            adherentIDLabel.TabIndex = 6;
            adherentIDLabel.Text = "Identifiant :";
            // 
            // DateNaissanceLabel
            // 
            DateNaissanceLabel.AutoSize = true;
            DateNaissanceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateNaissanceLabel.Location = new System.Drawing.Point(15, 142);
            DateNaissanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DateNaissanceLabel.Name = "DateNaissanceLabel";
            DateNaissanceLabel.Size = new System.Drawing.Size(160, 21);
            DateNaissanceLabel.TabIndex = 9;
            DateNaissanceLabel.Text = "Date de naissance:";
            // 
            // salaireLabel
            // 
            salaireLabel.AutoSize = true;
            salaireLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaireLabel.Location = new System.Drawing.Point(15, 182);
            salaireLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            salaireLabel.Name = "salaireLabel";
            salaireLabel.Size = new System.Drawing.Size(102, 21);
            salaireLabel.TabIndex = 12;
            salaireLabel.Text = "Salaire brut:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(15, 222);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 21);
            label2.TabIndex = 13;
            label2.Text = "Temps de travail:";
            // 
            // ArrivéeLabel
            // 
            ArrivéeLabel.AutoSize = true;
            ArrivéeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ArrivéeLabel.Location = new System.Drawing.Point(15, 262);
            ArrivéeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ArrivéeLabel.Name = "ArrivéeLabel";
            ArrivéeLabel.Size = new System.Drawing.Size(126, 21);
            ArrivéeLabel.TabIndex = 15;
            ArrivéeLabel.Text = "Date d\'arrivée:";
            // 
            // departLabel
            // 
            departLabel.AutoSize = true;
            departLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departLabel.Location = new System.Drawing.Point(15, 302);
            departLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departLabel.Name = "departLabel";
            departLabel.Size = new System.Drawing.Size(138, 21);
            departLabel.TabIndex = 20;
            departLabel.Text = "Date de départ:";
            // 
            // etablissementLabel
            // 
            etablissementLabel.AutoSize = true;
            etablissementLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            etablissementLabel.Location = new System.Drawing.Point(15, 342);
            etablissementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            etablissementLabel.Name = "etablissementLabel";
            etablissementLabel.Size = new System.Drawing.Size(122, 21);
            etablissementLabel.TabIndex = 21;
            etablissementLabel.Text = "Etablissement:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roleLabel.Location = new System.Drawing.Point(15, 382);
            roleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(82, 21);
            roleLabel.TabIndex = 22;
            roleLabel.Text = "Fonction:";
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
            this.gbRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRecherche.AutoSize = true;
            this.gbRecherche.Controls.Add(label1);
            this.gbRecherche.Controls.Add(nomLabel);
            this.gbRecherche.Controls.Add(this.txtDebNom);
            this.gbRecherche.Controls.Add(this.btnRechercher);
            this.gbRecherche.Controls.Add(this.txtAdherentID);
            this.gbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecherche.Location = new System.Drawing.Point(854, 11);
            this.gbRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Padding = new System.Windows.Forms.Padding(2);
            this.gbRecherche.Size = new System.Drawing.Size(478, 150);
            this.gbRecherche.TabIndex = 3;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Identifier l\'adhérent";
            // 
            // txtDebNom
            // 
            this.txtDebNom.Location = new System.Drawing.Point(195, 69);
            this.txtDebNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebNom.Name = "txtDebNom";
            this.txtDebNom.Size = new System.Drawing.Size(138, 26);
            this.txtDebNom.TabIndex = 1;
            this.txtDebNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebNom_KeyDown);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(195, 103);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(138, 43);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtAdherentID
            // 
            this.txtAdherentID.Location = new System.Drawing.Point(195, 39);
            this.txtAdherentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdherentID.Name = "txtAdherentID";
            this.txtAdherentID.Size = new System.Drawing.Size(138, 26);
            this.txtAdherentID.TabIndex = 0;
            this.txtAdherentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdherentID_KeyDown);
            // 
            // gbBoutonOpe
            // 
            this.gbBoutonOpe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBoutonOpe.Controls.Add(this.btnAnnuler);
            this.gbBoutonOpe.Controls.Add(this.btnValider);
            this.gbBoutonOpe.Controls.Add(this.btnNouveau);
            this.gbBoutonOpe.Controls.Add(this.btnEditer);
            this.gbBoutonOpe.Location = new System.Drawing.Point(794, 639);
            this.gbBoutonOpe.Margin = new System.Windows.Forms.Padding(2);
            this.gbBoutonOpe.Name = "gbBoutonOpe";
            this.gbBoutonOpe.Padding = new System.Windows.Forms.Padding(2);
            this.gbBoutonOpe.Size = new System.Drawing.Size(610, 72);
            this.gbBoutonOpe.TabIndex = 5;
            this.gbBoutonOpe.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(468, 22);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(138, 28);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(309, 22);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(138, 28);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(155, 22);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(138, 28);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditer.ForeColor = System.Drawing.Color.White;
            this.btnEditer.Location = new System.Drawing.Point(4, 22);
            this.btnEditer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(138, 28);
            this.btnEditer.TabIndex = 0;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = false;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.AutoSize = true;
            this.gbDetails.Controls.Add(roleLabel);
            this.gbDetails.Controls.Add(etablissementLabel);
            this.gbDetails.Controls.Add(departLabel);
            this.gbDetails.Controls.Add(this.roleTextbox);
            this.gbDetails.Controls.Add(this.etablissementTextbox);
            this.gbDetails.Controls.Add(this.departTextbox);
            this.gbDetails.Controls.Add(this.arriveeTextbox);
            this.gbDetails.Controls.Add(ArrivéeLabel);
            this.gbDetails.Controls.Add(this.TempsTextbox);
            this.gbDetails.Controls.Add(label2);
            this.gbDetails.Controls.Add(salaireLabel);
            this.gbDetails.Controls.Add(this.salaireTextbox);
            this.gbDetails.Controls.Add(this.DateNaissanceTextbox);
            this.gbDetails.Controls.Add(DateNaissanceLabel);
            this.gbDetails.Controls.Add(this.nomTextBox);
            this.gbDetails.Controls.Add(this.prenomTextBox);
            this.gbDetails.Controls.Add(prenomLabel);
            this.gbDetails.Controls.Add(nomLbl);
            this.gbDetails.Controls.Add(adherentIDLabel);
            this.gbDetails.Controls.Add(this.adherentIDTextBox);
            this.gbDetails.Location = new System.Drawing.Point(854, 161);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbDetails.Size = new System.Drawing.Size(478, 474);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            // 
            // roleTextbox
            // 
            this.roleTextbox.Location = new System.Drawing.Point(195, 383);
            this.roleTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.roleTextbox.Name = "roleTextbox";
            this.roleTextbox.ReadOnly = true;
            this.roleTextbox.Size = new System.Drawing.Size(184, 20);
            this.roleTextbox.TabIndex = 19;
            // 
            // etablissementTextbox
            // 
            this.etablissementTextbox.Location = new System.Drawing.Point(195, 343);
            this.etablissementTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.etablissementTextbox.Name = "etablissementTextbox";
            this.etablissementTextbox.ReadOnly = true;
            this.etablissementTextbox.Size = new System.Drawing.Size(184, 20);
            this.etablissementTextbox.TabIndex = 18;
            // 
            // departTextbox
            // 
            this.departTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "EndDate", true));
            this.departTextbox.Location = new System.Drawing.Point(195, 303);
            this.departTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.departTextbox.Name = "departTextbox";
            this.departTextbox.Size = new System.Drawing.Size(184, 20);
            this.departTextbox.TabIndex = 17;
            // 
            // arriveeTextbox
            // 
            this.arriveeTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "StartDate", true));
            this.arriveeTextbox.Location = new System.Drawing.Point(195, 263);
            this.arriveeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.arriveeTextbox.Name = "arriveeTextbox";
            this.arriveeTextbox.Size = new System.Drawing.Size(184, 20);
            this.arriveeTextbox.TabIndex = 16;
            // 
            // TempsTextbox
            // 
            this.TempsTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "WorkQuantity", true));
            this.TempsTextbox.Location = new System.Drawing.Point(195, 223);
            this.TempsTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.TempsTextbox.Name = "TempsTextbox";
            this.TempsTextbox.Size = new System.Drawing.Size(184, 20);
            this.TempsTextbox.TabIndex = 14;
            // 
            // salaireTextbox
            // 
            this.salaireTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "GrossSalary", true));
            this.salaireTextbox.Location = new System.Drawing.Point(195, 183);
            this.salaireTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.salaireTextbox.Name = "salaireTextbox";
            this.salaireTextbox.Size = new System.Drawing.Size(184, 20);
            this.salaireTextbox.TabIndex = 11;
            // 
            // DateNaissanceTextbox
            // 
            this.DateNaissanceTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "BirthDate", true));
            this.DateNaissanceTextbox.Location = new System.Drawing.Point(195, 143);
            this.DateNaissanceTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.DateNaissanceTextbox.Name = "DateNaissanceTextbox";
            this.DateNaissanceTextbox.Size = new System.Drawing.Size(184, 20);
            this.DateNaissanceTextbox.TabIndex = 10;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "LastName", true));
            this.nomTextBox.Location = new System.Drawing.Point(195, 63);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(184, 20);
            this.nomTextBox.TabIndex = 4;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "FirstName", true));
            this.prenomTextBox.Location = new System.Drawing.Point(195, 103);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(184, 20);
            this.prenomTextBox.TabIndex = 5;
            // 
            // adherentIDTextBox
            // 
            this.adherentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "EmployeeID", true));
            this.adherentIDTextBox.Location = new System.Drawing.Point(195, 23);
            this.adherentIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adherentIDTextBox.Name = "adherentIDTextBox";
            this.adherentIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.adherentIDTextBox.TabIndex = 3;
            // 
            // AfpaPic
            // 
            this.AfpaPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AfpaPic.Image = ((System.Drawing.Image)(resources.GetObject("AfpaPic.Image")));
            this.AfpaPic.Location = new System.Drawing.Point(59, 4);
            this.AfpaPic.Name = "AfpaPic";
            this.AfpaPic.Size = new System.Drawing.Size(720, 705);
            this.AfpaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AfpaPic.TabIndex = 6;
            this.AfpaPic.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Personnel.DAL.PersonnelRepository);
            // 
            // FrmAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 715);
            this.Controls.Add(this.AfpaPic);
            this.Controls.Add(this.gbRecherche);
            this.Controls.Add(this.gbBoutonOpe);
            this.Controls.Add(this.gbDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdherent";
            this.Text = "Gestion Employés";
            this.Load += new System.EventHandler(this.FrmAdherent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdherentEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.gbBoutonOpe.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfpaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox DateNaissanceTextbox;
        private System.Windows.Forms.TextBox salaireTextbox;
        private System.Windows.Forms.PictureBox AfpaPic;
        private System.Windows.Forms.TextBox TempsTextbox;
        private System.Windows.Forms.TextBox roleTextbox;
        private System.Windows.Forms.TextBox etablissementTextbox;
        private System.Windows.Forms.TextBox departTextbox;
        private System.Windows.Forms.TextBox arriveeTextbox;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

