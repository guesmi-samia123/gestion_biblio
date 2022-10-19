
namespace gestion_commande.pl
{
    partial class Ajouter_modifier_Client
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
            this.label6 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.auteur = new System.Windows.Forms.TextBox();
            this.editeur = new System.Windows.Forms.TextBox();
            this.titre = new System.Windows.Forms.TextBox();
            this.btn_enrg = new System.Windows.Forms.Button();
            this.btn_actialiser = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Num_livre = new System.Windows.Forms.Label();
            this.nb_page = new System.Windows.Forms.TextBox();
            this.dispo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.date_e = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ajouter Livre";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(368, 86);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(362, 48);
            this.num.TabIndex = 6;
            this.num.TextChanged += new System.EventHandler(this.nom_clt_TextChanged);
            // 
            // auteur
            // 
            this.auteur.Location = new System.Drawing.Point(368, 214);
            this.auteur.Multiline = true;
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(362, 48);
            this.auteur.TabIndex = 7;
            // 
            // editeur
            // 
            this.editeur.Location = new System.Drawing.Point(368, 278);
            this.editeur.Multiline = true;
            this.editeur.Name = "editeur";
            this.editeur.Size = new System.Drawing.Size(362, 48);
            this.editeur.TabIndex = 8;
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(368, 150);
            this.titre.Multiline = true;
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(362, 48);
            this.titre.TabIndex = 10;
            // 
            // btn_enrg
            // 
            this.btn_enrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(55)))));
            this.btn_enrg.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enrg.Location = new System.Drawing.Point(242, 885);
            this.btn_enrg.Name = "btn_enrg";
            this.btn_enrg.Size = new System.Drawing.Size(199, 69);
            this.btn_enrg.TabIndex = 11;
            this.btn_enrg.Text = "Enregistrer";
            this.btn_enrg.UseVisualStyleBackColor = false;
            this.btn_enrg.Click += new System.EventHandler(this.btn_enrg_Click);
            // 
            // btn_actialiser
            // 
            this.btn_actialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(55)))));
            this.btn_actialiser.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actialiser.Location = new System.Drawing.Point(481, 885);
            this.btn_actialiser.Name = "btn_actialiser";
            this.btn_actialiser.Size = new System.Drawing.Size(199, 69);
            this.btn_actialiser.TabIndex = 12;
            this.btn_actialiser.Text = "actialiser";
            this.btn_actialiser.UseVisualStyleBackColor = false;
            this.btn_actialiser.Click += new System.EventHandler(this.btn_actialiser_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::gestion_commande.Properties.Resources.Close_2_icon;
            this.button7.Location = new System.Drawing.Point(960, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 63);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre des Page :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-278, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date Edition :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Disponibilité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Editeur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Titre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Auteur :";
            // 
            // Num_livre
            // 
            this.Num_livre.AutoSize = true;
            this.Num_livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_livre.Location = new System.Drawing.Point(48, 79);
            this.Num_livre.Name = "Num_livre";
            this.Num_livre.Size = new System.Drawing.Size(138, 32);
            this.Num_livre.TabIndex = 14;
            this.Num_livre.Text = "Numéro :";
            // 
            // nb_page
            // 
            this.nb_page.Location = new System.Drawing.Point(368, 514);
            this.nb_page.Multiline = true;
            this.nb_page.Name = "nb_page";
            this.nb_page.Size = new System.Drawing.Size(362, 48);
            this.nb_page.TabIndex = 22;
            // 
            // dispo
            // 
            this.dispo.Location = new System.Drawing.Point(368, 364);
            this.dispo.Multiline = true;
            this.dispo.Name = "dispo";
            this.dispo.Size = new System.Drawing.Size(362, 48);
            this.dispo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 730);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "Image";
            // 
            // picture
            // 
            this.picture.ImageRotate = 0F;
            this.picture.Location = new System.Drawing.Point(368, 668);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(240, 112);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 25;
            this.picture.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(614, 668);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(116, 45);
            this.guna2Button1.TabIndex = 27;
            this.guna2Button1.Text = "Parcourir";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(368, 450);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(362, 48);
            this.description.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "description :";
            // 
            // date_e
            // 
            this.date_e.Checked = true;
            this.date_e.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_e.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_e.Location = new System.Drawing.Point(368, 581);
            this.date_e.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_e.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_e.Name = "date_e";
            this.date_e.Size = new System.Drawing.Size(273, 48);
            this.date_e.TabIndex = 30;
            this.date_e.Value = new System.DateTime(2022, 4, 27, 7, 26, 34, 214);
            // 
            // Ajouter_modifier_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1048, 1106);
            this.Controls.Add(this.date_e);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.description);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dispo);
            this.Controls.Add(this.nb_page);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Num_livre);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_actialiser);
            this.Controls.Add(this.btn_enrg);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.editeur);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajouter_modifier_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_modifier_Client";
            this.Load += new System.EventHandler(this.Ajouter_modifier_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox auteur;
        private System.Windows.Forms.TextBox editeur;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button btn_enrg;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_actialiser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Num_livre;
        private System.Windows.Forms.TextBox nb_page;
        private System.Windows.Forms.TextBox dispo;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox picture;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_e;
    }
}