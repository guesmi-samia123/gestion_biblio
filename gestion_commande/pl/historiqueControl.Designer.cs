
namespace gestion_commande.pl
{
    partial class historiqueControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_liv_emp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat_Empreinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_liv_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_liv_emp
            // 
            this.dg_liv_emp.AllowUserToAddRows = false;
            this.dg_liv_emp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg_liv_emp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_liv_emp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_liv_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_liv_emp.BackgroundColor = System.Drawing.Color.White;
            this.dg_liv_emp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_liv_emp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_liv_emp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_liv_emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_liv_emp.ColumnHeadersHeight = 32;
            this.dg_liv_emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre,
            this.Auteur,
            this.date_debut,
            this.date_fin,
            this.Type_doc,
            this.Etat_Empreinte});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_liv_emp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_liv_emp.EnableHeadersVisualStyles = false;
            this.dg_liv_emp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_liv_emp.Location = new System.Drawing.Point(64, 385);
            this.dg_liv_emp.Name = "dg_liv_emp";
            this.dg_liv_emp.ReadOnly = true;
            this.dg_liv_emp.RowHeadersVisible = false;
            this.dg_liv_emp.RowHeadersWidth = 120;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.dg_liv_emp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_liv_emp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_liv_emp.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.dg_liv_emp.RowTemplate.Height = 70;
            this.dg_liv_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_liv_emp.Size = new System.Drawing.Size(1063, 413);
            this.dg_liv_emp.TabIndex = 14;
            this.dg_liv_emp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_liv_emp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_liv_emp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_liv_emp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_liv_emp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_liv_emp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_liv_emp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_liv_emp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dg_liv_emp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_liv_emp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.dg_liv_emp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_liv_emp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_liv_emp.ThemeStyle.HeaderStyle.Height = 32;
            this.dg_liv_emp.ThemeStyle.ReadOnly = true;
            this.dg_liv_emp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_liv_emp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_liv_emp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dg_liv_emp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_liv_emp.ThemeStyle.RowsStyle.Height = 70;
            this.dg_liv_emp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_liv_emp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 15;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.White;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "",
            "Epuisé    ",
            "En Cours  "});
            this.guna2ComboBox1.Location = new System.Drawing.Point(64, 187);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(539, 36);
            this.guna2ComboBox1.TabIndex = 15;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(77, -37);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(242, 152);
            this.guna2CircleButton1.TabIndex = 16;
            this.guna2CircleButton1.Text = "Historique";
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre";
            this.Titre.MinimumWidth = 8;
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.MinimumWidth = 8;
            this.Auteur.Name = "Auteur";
            this.Auteur.ReadOnly = true;
            // 
            // date_debut
            // 
            this.date_debut.HeaderText = "Date Debut";
            this.date_debut.MinimumWidth = 8;
            this.date_debut.Name = "date_debut";
            this.date_debut.ReadOnly = true;
            // 
            // date_fin
            // 
            this.date_fin.HeaderText = "Date_fin";
            this.date_fin.MinimumWidth = 8;
            this.date_fin.Name = "date_fin";
            this.date_fin.ReadOnly = true;
            // 
            // Type_doc
            // 
            this.Type_doc.HeaderText = "Type Document";
            this.Type_doc.MinimumWidth = 8;
            this.Type_doc.Name = "Type_doc";
            this.Type_doc.ReadOnly = true;
            // 
            // Etat_Empreinte
            // 
            this.Etat_Empreinte.HeaderText = "Etat Empreinte";
            this.Etat_Empreinte.MinimumWidth = 8;
            this.Etat_Empreinte.Name = "Etat_Empreinte";
            this.Etat_Empreinte.ReadOnly = true;
            // 
            // historiqueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.dg_liv_emp);
            this.Name = "historiqueControl";
            this.Size = new System.Drawing.Size(1161, 1030);
            this.Load += new System.EventHandler(this.historiqueControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_liv_emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dg_liv_emp;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat_Empreinte;
    }
}
