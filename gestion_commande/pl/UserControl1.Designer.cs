
namespace gestion_commande.pl
{
    partial class UserControl1
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textRecherch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prenom = new System.Windows.Forms.DataGridViewButtonColumn();
            this.adresse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codePostale = new System.Windows.Forms.DataGridViewButtonColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::gestion_commande.Properties.Resources.Subtract_32;
            this.button6.Location = new System.Drawing.Point(840, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 42);
            this.button6.TabIndex = 21;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::gestion_commande.Properties.Resources.Shutdown_32;
            this.button7.Location = new System.Drawing.Point(901, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 42);
            this.button7.TabIndex = 20;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "nom",
            "prenom",
            "adresse",
            "telephone",
            "codePostale"});
            this.comboBox1.Location = new System.Drawing.Point(135, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 44);
            this.comboBox1.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(466, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 2);
            this.panel3.TabIndex = 24;
            // 
            // textRecherch
            // 
            this.textRecherch.BackColor = System.Drawing.SystemColors.Control;
            this.textRecherch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRecherch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRecherch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textRecherch.Location = new System.Drawing.Point(475, 171);
            this.textRecherch.Multiline = true;
            this.textRecherch.Name = "textRecherch";
            this.textRecherch.Size = new System.Drawing.Size(438, 49);
            this.textRecherch.TabIndex = 25;
            this.textRecherch.Text = "Recherche";
            this.textRecherch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRecherch.TextChanged += new System.EventHandler(this.textRecherch_TextChanged);
            this.textRecherch.Enter += new System.EventHandler(this.textRecherch_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(26, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 3);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(21, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 3);
            this.panel2.TabIndex = 23;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nom,
            this.prenom,
            this.adresse,
            this.codePostale,
            this.telephone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.EnableHeadersVisualStyles = false;
            this.dgvClient.Location = new System.Drawing.Point(5, 3);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidth = 62;
            this.dgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvClient.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClient.RowTemplate.Height = 28;
            this.dgvClient.Size = new System.Drawing.Size(887, 161);
            this.dgvClient.TabIndex = 27;
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            this.nom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            this.prenom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "adresse";
            this.adresse.MinimumWidth = 8;
            this.adresse.Name = "adresse";
            this.adresse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // codePostale
            // 
            this.codePostale.HeaderText = "codePostale";
            this.codePostale.MinimumWidth = 8;
            this.codePostale.Name = "codePostale";
            this.codePostale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "telephone";
            this.telephone.MinimumWidth = 8;
            this.telephone.Name = "telephone";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvClient);
            this.panel4.Location = new System.Drawing.Point(21, 294);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 195);
            this.panel4.TabIndex = 29;
            // 
            // btn_modif
            // 
            this.btn_modif.BackColor = System.Drawing.Color.Black;
            this.btn_modif.FlatAppearance.BorderSize = 0;
            this.btn_modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modif.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_modif.Location = new System.Drawing.Point(384, 58);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(293, 41);
            this.btn_modif.TabIndex = 32;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.BackColor = System.Drawing.Color.Black;
            this.btn_supp.FlatAppearance.BorderSize = 0;
            this.btn_supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supp.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_supp.Location = new System.Drawing.Point(700, 58);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(269, 41);
            this.btn_supp.TabIndex = 31;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(63, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textRecherch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(993, 502);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textRecherch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn nom;
        private System.Windows.Forms.DataGridViewButtonColumn prenom;
        private System.Windows.Forms.DataGridViewButtonColumn adresse;
        private System.Windows.Forms.DataGridViewButtonColumn codePostale;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Button button1;
    }
}
