
namespace gestion_commande.pl
{
    partial class control_liste_client
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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::gestion_commande.Properties.Resources.Subtract_32;
            this.button6.Location = new System.Drawing.Point(901, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 42);
            this.button6.TabIndex = 16;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::gestion_commande.Properties.Resources.Shutdown_32;
            this.button7.Location = new System.Drawing.Point(962, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 42);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(17, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 3);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(17, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 3);
            this.panel2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(600, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 49);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Recherche";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(591, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 2);
            this.panel3.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "nom",
            "prenom",
            "adresse",
            "telephone",
            "codePostale"});
            this.comboBox1.Location = new System.Drawing.Point(260, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 44);
            this.comboBox1.TabIndex = 20;
            // 
            // btn_modif
            // 
            this.btn_modif.BackColor = System.Drawing.Color.Black;
            this.btn_modif.FlatAppearance.BorderSize = 0;
            this.btn_modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modif.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_modif.Location = new System.Drawing.Point(409, 284);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(328, 53);
            this.btn_modif.TabIndex = 23;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = false;
            // 
            // btn_supp
            // 
            this.btn_supp.BackColor = System.Drawing.Color.Black;
            this.btn_supp.FlatAppearance.BorderSize = 0;
            this.btn_supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supp.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_supp.Location = new System.Drawing.Point(801, 284);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(287, 53);
            this.btn_supp.TabIndex = 22;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = false;
            // 
            // btn_ajout
            // 
            this.btn_ajout.BackColor = System.Drawing.Color.Black;
            this.btn_ajout.FlatAppearance.BorderSize = 0;
            this.btn_ajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajout.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ajout.Location = new System.Drawing.Point(18, 284);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(333, 53);
            this.btn_ajout.TabIndex = 21;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = false;
            // 
            // control_liste_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "control_liste_client";
            this.Text = "control_liste_client";
            this.Load += new System.EventHandler(this.control_liste_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Button btn_ajout;
    }
}