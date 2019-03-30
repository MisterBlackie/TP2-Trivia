namespace TP2BD
{
    partial class Joueur
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
            this.NombreJoueur = new System.Windows.Forms.NumericUpDown();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.TBX_Prenom = new System.Windows.Forms.TextBox();
            this.TBX_Alias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.LBX_Joueur = new System.Windows.Forms.ListBox();
            this.BTN_AddJoueur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Pret = new System.Windows.Forms.Button();
            this.LBX_Pret = new System.Windows.Forms.ListBox();
            this.BTN_Retirer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NombreJoueur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de joueur";
            // 
            // NombreJoueur
            // 
            this.NombreJoueur.Location = new System.Drawing.Point(109, 7);
            this.NombreJoueur.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NombreJoueur.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NombreJoueur.Name = "NombreJoueur";
            this.NombreJoueur.Size = new System.Drawing.Size(31, 20);
            this.NombreJoueur.TabIndex = 5;
            this.NombreJoueur.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(109, 50);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(169, 20);
            this.TBX_Nom.TabIndex = 7;
            // 
            // TBX_Prenom
            // 
            this.TBX_Prenom.Location = new System.Drawing.Point(109, 78);
            this.TBX_Prenom.Name = "TBX_Prenom";
            this.TBX_Prenom.Size = new System.Drawing.Size(169, 20);
            this.TBX_Prenom.TabIndex = 7;
            // 
            // TBX_Alias
            // 
            this.TBX_Alias.Location = new System.Drawing.Point(109, 104);
            this.TBX_Alias.Name = "TBX_Alias";
            this.TBX_Alias.Size = new System.Drawing.Size(169, 20);
            this.TBX_Alias.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alias";
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(275, 259);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(198, 34);
            this.BTN_Start.TabIndex = 9;
            this.BTN_Start.Text = "Commencer";
            this.BTN_Start.UseVisualStyleBackColor = true;
            // 
            // LBX_Joueur
            // 
            this.LBX_Joueur.FormattingEnabled = true;
            this.LBX_Joueur.Location = new System.Drawing.Point(328, 30);
            this.LBX_Joueur.Name = "LBX_Joueur";
            this.LBX_Joueur.Size = new System.Drawing.Size(133, 108);
            this.LBX_Joueur.TabIndex = 10;
            this.LBX_Joueur.SelectedIndexChanged += new System.EventHandler(this.LBX_Joueur_SelectedIndexChanged);
            // 
            // BTN_AddJoueur
            // 
            this.BTN_AddJoueur.Location = new System.Drawing.Point(109, 130);
            this.BTN_AddJoueur.Name = "BTN_AddJoueur";
            this.BTN_AddJoueur.Size = new System.Drawing.Size(169, 23);
            this.BTN_AddJoueur.TabIndex = 11;
            this.BTN_AddJoueur.Text = "Creer un nouveau joueur";
            this.BTN_AddJoueur.UseVisualStyleBackColor = true;
            this.BTN_AddJoueur.Click += new System.EventHandler(this.BTN_AddJoueur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vous avez deja un Joueur?";
            // 
            // BTN_Pret
            // 
            this.BTN_Pret.Location = new System.Drawing.Point(328, 144);
            this.BTN_Pret.Name = "BTN_Pret";
            this.BTN_Pret.Size = new System.Drawing.Size(133, 23);
            this.BTN_Pret.TabIndex = 13;
            this.BTN_Pret.Text = "Pret";
            this.BTN_Pret.UseVisualStyleBackColor = true;
            this.BTN_Pret.Click += new System.EventHandler(this.BTN_Pret_Click);
            // 
            // LBX_Pret
            // 
            this.LBX_Pret.FormattingEnabled = true;
            this.LBX_Pret.Location = new System.Drawing.Point(328, 173);
            this.LBX_Pret.Name = "LBX_Pret";
            this.LBX_Pret.Size = new System.Drawing.Size(133, 56);
            this.LBX_Pret.TabIndex = 14;
            this.LBX_Pret.SelectedIndexChanged += new System.EventHandler(this.LBX_Pret_SelectedIndexChanged);
            // 
            // BTN_Retirer
            // 
            this.BTN_Retirer.Location = new System.Drawing.Point(386, 230);
            this.BTN_Retirer.Name = "BTN_Retirer";
            this.BTN_Retirer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Retirer.TabIndex = 15;
            this.BTN_Retirer.Text = "Retirer Joueur";
            this.BTN_Retirer.UseVisualStyleBackColor = true;
            this.BTN_Retirer.Click += new System.EventHandler(this.BTN_Retirer_Click);
            // 
            // Joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 305);
            this.Controls.Add(this.BTN_Retirer);
            this.Controls.Add(this.LBX_Pret);
            this.Controls.Add(this.BTN_Pret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_AddJoueur);
            this.Controls.Add(this.LBX_Joueur);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX_Alias);
            this.Controls.Add(this.TBX_Prenom);
            this.Controls.Add(this.TBX_Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreJoueur);
            this.Name = "Joueur";
            this.Text = "Joueur";
            this.Load += new System.EventHandler(this.Joueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NombreJoueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NombreJoueur;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.TextBox TBX_Prenom;
        private System.Windows.Forms.TextBox TBX_Alias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.ListBox LBX_Joueur;
        private System.Windows.Forms.Button BTN_AddJoueur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Pret;
        private System.Windows.Forms.ListBox LBX_Pret;
        private System.Windows.Forms.Button BTN_Retirer;
    }
}