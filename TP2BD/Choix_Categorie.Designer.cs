namespace TP2BD
{
    partial class Choix_Categorie
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
            this.BTN_Sport = new System.Windows.Forms.Button();
            this.BTN_Culture = new System.Windows.Forms.Button();
            this.BTN_Art = new System.Windows.Forms.Button();
            this.BTN_Jeux = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Sport
            // 
            this.BTN_Sport.BackColor = System.Drawing.Color.Lime;
            this.BTN_Sport.Location = new System.Drawing.Point(30, 46);
            this.BTN_Sport.Name = "BTN_Sport";
            this.BTN_Sport.Size = new System.Drawing.Size(191, 81);
            this.BTN_Sport.TabIndex = 0;
            this.BTN_Sport.Text = "Sport";
            this.BTN_Sport.UseVisualStyleBackColor = false;
            this.BTN_Sport.Click += new System.EventHandler(this.BTN_Sport_Click);
            // 
            // BTN_Culture
            // 
            this.BTN_Culture.BackColor = System.Drawing.Color.Red;
            this.BTN_Culture.Location = new System.Drawing.Point(226, 133);
            this.BTN_Culture.Name = "BTN_Culture";
            this.BTN_Culture.Size = new System.Drawing.Size(191, 81);
            this.BTN_Culture.TabIndex = 0;
            this.BTN_Culture.Text = "Culture";
            this.BTN_Culture.UseVisualStyleBackColor = false;
            this.BTN_Culture.Click += new System.EventHandler(this.BTN_Culture_Click);
            // 
            // BTN_Art
            // 
            this.BTN_Art.BackColor = System.Drawing.Color.Yellow;
            this.BTN_Art.Location = new System.Drawing.Point(29, 133);
            this.BTN_Art.Name = "BTN_Art";
            this.BTN_Art.Size = new System.Drawing.Size(191, 81);
            this.BTN_Art.TabIndex = 0;
            this.BTN_Art.Text = "Art";
            this.BTN_Art.UseVisualStyleBackColor = false;
            this.BTN_Art.Click += new System.EventHandler(this.BTN_Art_Click);
            // 
            // BTN_Jeux
            // 
            this.BTN_Jeux.BackColor = System.Drawing.Color.Blue;
            this.BTN_Jeux.Location = new System.Drawing.Point(226, 46);
            this.BTN_Jeux.Name = "BTN_Jeux";
            this.BTN_Jeux.Size = new System.Drawing.Size(191, 81);
            this.BTN_Jeux.TabIndex = 0;
            this.BTN_Jeux.Text = "Jeux Vidéo";
            this.BTN_Jeux.UseVisualStyleBackColor = false;
            this.BTN_Jeux.Click += new System.EventHandler(this.BTN_Jeux_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisissez la catégorie dans laquelle vous souhaiter progresser";
            // 
            // Choix_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Jeux);
            this.Controls.Add(this.BTN_Culture);
            this.Controls.Add(this.BTN_Art);
            this.Controls.Add(this.BTN_Sport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Choix_Categorie";
            this.Text = "Choix_Categorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Sport;
        private System.Windows.Forms.Button BTN_Culture;
        private System.Windows.Forms.Button BTN_Art;
        private System.Windows.Forms.Button BTN_Jeux;
        private System.Windows.Forms.Label label1;
    }
}