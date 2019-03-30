namespace TP2BD
{
    partial class Form1
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Roulette = new TP2BD.ColorRoulette();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_JouerTour = new System.Windows.Forms.Button();
            this.LB_NomJoueur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Roulette)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Roulette
            // 
            this.Roulette.BackColor = System.Drawing.Color.White;
            this.Roulette.Location = new System.Drawing.Point(252, 12);
            this.Roulette.Name = "Roulette";
            this.Roulette.Size = new System.Drawing.Size(330, 426);
            this.Roulette.TabIndex = 5;
            this.Roulette.TabStop = false;
        
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_JouerTour);
            this.groupBox1.Controls.Add(this.LB_NomJoueur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 426);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu joueur";
            // 
            // BTN_JouerTour
            // 
            this.BTN_JouerTour.Location = new System.Drawing.Point(6, 132);
            this.BTN_JouerTour.Name = "BTN_JouerTour";
            this.BTN_JouerTour.Size = new System.Drawing.Size(222, 41);
            this.BTN_JouerTour.TabIndex = 2;
            this.BTN_JouerTour.Text = "Tourner la roulette";
            this.BTN_JouerTour.UseVisualStyleBackColor = true;
            this.BTN_JouerTour.Click += new System.EventHandler(this.BTN_JouerTour_Click);
            // 
            // LB_NomJoueur
            // 
            this.LB_NomJoueur.AutoSize = true;
            this.LB_NomJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NomJoueur.Location = new System.Drawing.Point(74, 72);
            this.LB_NomJoueur.Name = "LB_NomJoueur";
            this.LB_NomJoueur.Size = new System.Drawing.Size(70, 25);
            this.LB_NomJoueur.TabIndex = 1;
            this.LB_NomJoueur.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "C\'est au tour de";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(588, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Roulette);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Roulette)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private ColorRoulette Roulette;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_JouerTour;
        private System.Windows.Forms.Label LB_NomJoueur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

