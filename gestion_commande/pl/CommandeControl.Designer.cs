
namespace gestion_commande.pl
{
    partial class CommandeControl
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
            this.button7 = new System.Windows.Forms.Button();
            this.btn_actialiser = new System.Windows.Forms.Button();
            this.btn_enrg = new System.Windows.Forms.Button();
            this.num_cmd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adrliv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.combClt = new System.Windows.Forms.ComboBox();
            this.telephpne = new System.Windows.Forms.TextBox();
            this.codePostal = new System.Windows.Forms.TextBox();
            this.adrClt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.combArt = new System.Windows.Forms.ComboBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.prixU = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvlignecmd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.article = new System.Windows.Forms.DataGridViewButtonColumn();
            this.quantite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.qt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlignecmd)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::gestion_commande.Properties.Resources.Close_2_icon;
            this.button7.Location = new System.Drawing.Point(1543, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 63);
            this.button7.TabIndex = 19;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_actialiser
            // 
            this.btn_actialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(55)))));
            this.btn_actialiser.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actialiser.Location = new System.Drawing.Point(536, 396);
            this.btn_actialiser.Name = "btn_actialiser";
            this.btn_actialiser.Size = new System.Drawing.Size(128, 35);
            this.btn_actialiser.TabIndex = 18;
            this.btn_actialiser.Text = "Annuler";
            this.btn_actialiser.UseVisualStyleBackColor = false;
            this.btn_actialiser.Click += new System.EventHandler(this.btn_actialiser_Click);
            // 
            // btn_enrg
            // 
            this.btn_enrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(55)))));
            this.btn_enrg.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enrg.Location = new System.Drawing.Point(409, 396);
            this.btn_enrg.Name = "btn_enrg";
            this.btn_enrg.Size = new System.Drawing.Size(121, 35);
            this.btn_enrg.TabIndex = 17;
            this.btn_enrg.Text = "OK";
            this.btn_enrg.UseVisualStyleBackColor = false;
            this.btn_enrg.Click += new System.EventHandler(this.btn_enrg_Click);
            // 
            // num_cmd
            // 
            this.num_cmd.Location = new System.Drawing.Point(144, 70);
            this.num_cmd.Name = "num_cmd";
            this.num_cmd.Size = new System.Drawing.Size(182, 26);
            this.num_cmd.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ajouter commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numéro";
            // 
            // adrliv
            // 
            this.adrliv.Location = new System.Drawing.Point(272, 178);
            this.adrliv.Name = "adrliv";
            this.adrliv.Size = new System.Drawing.Size(182, 26);
            this.adrliv.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adresse livraison";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(22, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1576, 2);
            this.panel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 35);
            this.label4.TabIndex = 26;
            this.label4.Text = "Client";
            // 
            // combClt
            // 
            this.combClt.FormattingEnabled = true;
            this.combClt.Location = new System.Drawing.Point(126, 245);
            this.combClt.Name = "combClt";
            this.combClt.Size = new System.Drawing.Size(200, 28);
            this.combClt.TabIndex = 27;
            this.combClt.SelectedIndexChanged += new System.EventHandler(this.combClt_SelectedIndexChanged);
            // 
            // telephpne
            // 
            this.telephpne.Location = new System.Drawing.Point(1185, 238);
            this.telephpne.Name = "telephpne";
            this.telephpne.Size = new System.Drawing.Size(136, 26);
            this.telephpne.TabIndex = 28;
            // 
            // codePostal
            // 
            this.codePostal.Location = new System.Drawing.Point(883, 243);
            this.codePostal.Name = "codePostal";
            this.codePostal.Size = new System.Drawing.Size(125, 26);
            this.codePostal.TabIndex = 29;
            // 
            // adrClt
            // 
            this.adrClt.Location = new System.Drawing.Point(482, 245);
            this.adrClt.Name = "adrClt";
            this.adrClt.Size = new System.Drawing.Size(182, 26);
            this.adrClt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(359, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 35);
            this.label5.TabIndex = 31;
            this.label5.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1014, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 35);
            this.label7.TabIndex = 32;
            this.label7.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(693, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 35);
            this.label8.TabIndex = 33;
            this.label8.Text = "Code postale";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(22, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1576, 2);
            this.panel2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(16, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 35);
            this.label9.TabIndex = 26;
            this.label9.Text = "Article";
            // 
            // combArt
            // 
            this.combArt.FormattingEnabled = true;
            this.combArt.Location = new System.Drawing.Point(126, 331);
            this.combArt.Name = "combArt";
            this.combArt.Size = new System.Drawing.Size(101, 28);
            this.combArt.TabIndex = 27;
            this.combArt.SelectedIndexChanged += new System.EventHandler(this.combArt_SelectedIndexChanged);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(365, 331);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(84, 26);
            this.code.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(266, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 35);
            this.label10.TabIndex = 31;
            this.label10.Text = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(491, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 35);
            this.label11.TabIndex = 33;
            this.label11.Text = "Designation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(832, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 35);
            this.label12.TabIndex = 34;
            this.label12.Text = "Prix unitaire";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // prixU
            // 
            this.prixU.Location = new System.Drawing.Point(1020, 324);
            this.prixU.Name = "prixU";
            this.prixU.Size = new System.Drawing.Size(125, 26);
            this.prixU.TabIndex = 35;
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(684, 331);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(125, 26);
            this.designation.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(22, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1576, 2);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(22, 451);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1576, 2);
            this.panel4.TabIndex = 28;
            // 
            // dgvlignecmd
            // 
            this.dgvlignecmd.AllowUserToAddRows = false;
            this.dgvlignecmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlignecmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlignecmd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlignecmd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlignecmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlignecmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cmd,
            this.article,
            this.quantite,
            this.id_article,
            this.id_cmd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlignecmd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlignecmd.EnableHeadersVisualStyles = false;
            this.dgvlignecmd.Location = new System.Drawing.Point(22, 509);
            this.dgvlignecmd.Name = "dgvlignecmd";
            this.dgvlignecmd.RowHeadersVisible = false;
            this.dgvlignecmd.RowHeadersWidth = 62;
            this.dgvlignecmd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvlignecmd.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlignecmd.RowTemplate.Height = 28;
            this.dgvlignecmd.Size = new System.Drawing.Size(1371, 239);
            this.dgvlignecmd.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // cmd
            // 
            this.cmd.HeaderText = "Commande";
            this.cmd.MinimumWidth = 8;
            this.cmd.Name = "cmd";
            this.cmd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // article
            // 
            this.article.HeaderText = "Article";
            this.article.MinimumWidth = 8;
            this.article.Name = "article";
            this.article.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantite";
            this.quantite.MinimumWidth = 8;
            this.quantite.Name = "quantite";
            this.quantite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // id_article
            // 
            this.id_article.HeaderText = "id_art";
            this.id_article.MinimumWidth = 8;
            this.id_article.Name = "id_article";
            this.id_article.Visible = false;
            // 
            // id_cmd
            // 
            this.id_cmd.HeaderText = "id_cmd";
            this.id_cmd.MinimumWidth = 8;
            this.id_cmd.Name = "id_cmd";
            this.id_cmd.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(27, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 35);
            this.label13.TabIndex = 38;
            this.label13.Text = "Ligne Commande";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(55)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1155, 754);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 69);
            this.button1.TabIndex = 40;
            this.button1.Text = "actialiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(55)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(941, 754);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 69);
            this.button2.TabIndex = 39;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // qt
            // 
            this.qt.Location = new System.Drawing.Point(1493, 324);
            this.qt.Name = "qt";
            this.qt.Size = new System.Drawing.Size(96, 26);
            this.qt.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(1179, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 35);
            this.label14.TabIndex = 42;
            this.label14.Text = "Quantite";
            // 
            // CommandeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.qt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvlignecmd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.prixU);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.code);
            this.Controls.Add(this.adrClt);
            this.Controls.Add(this.codePostal);
            this.Controls.Add(this.telephpne);
            this.Controls.Add(this.combArt);
            this.Controls.Add(this.combClt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adrliv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_actialiser);
            this.Controls.Add(this.btn_enrg);
            this.Controls.Add(this.num_cmd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "CommandeControl";
            this.Size = new System.Drawing.Size(1638, 843);
            this.Load += new System.EventHandler(this.Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlignecmd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button btn_actialiser;
        public System.Windows.Forms.Button btn_enrg;
        private System.Windows.Forms.TextBox num_cmd;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adrliv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combClt;
        private System.Windows.Forms.TextBox telephpne;
        private System.Windows.Forms.TextBox codePostal;
        private System.Windows.Forms.TextBox adrClt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combArt;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox prixU;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvlignecmd;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox qt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn cmd;
        private System.Windows.Forms.DataGridViewButtonColumn article;
        private System.Windows.Forms.DataGridViewButtonColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cmd;
    }
}
