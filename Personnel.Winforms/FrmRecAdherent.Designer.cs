namespace Personnel.Winforms
{
    partial class FrmRecAdherent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.adherentDataGridView = new System.Windows.Forms.DataGridView();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrossSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(190, 292);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 25);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(112, 292);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 25);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // adherentDataGridView
            // 
            this.adherentDataGridView.AllowUserToAddRows = false;
            this.adherentDataGridView.AllowUserToDeleteRows = false;
            this.adherentDataGridView.AutoGenerateColumns = false;
            this.adherentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.adherentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.adherentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adherentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adherentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adherentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adherentIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.BirthDate,
            this.GrossSalary});
            this.adherentDataGridView.DataSource = this.adherentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adherentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.adherentDataGridView.Location = new System.Drawing.Point(85, 42);
            this.adherentDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.adherentDataGridView.Name = "adherentDataGridView";
            this.adherentDataGridView.ReadOnly = true;
            this.adherentDataGridView.RowTemplate.Height = 24;
            this.adherentDataGridView.Size = new System.Drawing.Size(481, 214);
            this.adherentDataGridView.TabIndex = 3;
            this.adherentDataGridView.DoubleClick += new System.EventHandler(this.adherentDataGridView_DoubleClick);
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 76;
            // 
            // adherentIDDataGridViewTextBoxColumn
            // 
            this.adherentIDDataGridViewTextBoxColumn.DataPropertyName = "AdherentID";
            this.adherentIDDataGridViewTextBoxColumn.HeaderText = "AdherentID";
            this.adherentIDDataGridViewTextBoxColumn.Name = "adherentIDDataGridViewTextBoxColumn";
            this.adherentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.adherentIDDataGridViewTextBoxColumn.Width = 86;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.nomDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 80;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 79;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(Personnel.BOL.Employee);
            // 
            // GrossSalary
            // 
            this.GrossSalary.DataPropertyName = "GrossSalary";
            this.GrossSalary.HeaderText = "GrossSalary";
            this.GrossSalary.Name = "GrossSalary";
            this.GrossSalary.ReadOnly = true;
            this.GrossSalary.Width = 88;
            // 
            // FrmRecAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.adherentDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRecAdherent";
            this.Text = "FrmRecAdherent";
            this.Load += new System.EventHandler(this.FrmRecAdherent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView adherentDataGridView;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adherentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossSalary;
    }
}