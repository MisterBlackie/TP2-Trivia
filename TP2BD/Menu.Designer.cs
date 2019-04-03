namespace TP2BD
{
    partial class Menu
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
            this.BTN_CreerPartie = new System.Windows.Forms.Button();
            this.BTN_CreerQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CreerPartie
            // 
            this.BTN_CreerPartie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CreerPartie.Location = new System.Drawing.Point(12, 12);
            this.BTN_CreerPartie.Name = "BTN_CreerPartie";
            this.BTN_CreerPartie.Size = new System.Drawing.Size(325, 90);
            this.BTN_CreerPartie.TabIndex = 0;
            this.BTN_CreerPartie.Text = "Créer une partie";
            this.BTN_CreerPartie.UseVisualStyleBackColor = true;
            this.BTN_CreerPartie.Click += new System.EventHandler(this.BTN_CreerPartie_Click);
            // 
            // BTN_CreerQuestion
            // 
            this.BTN_CreerQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CreerQuestion.Location = new System.Drawing.Point(12, 108);
            this.BTN_CreerQuestion.Name = "BTN_CreerQuestion";
            this.BTN_CreerQuestion.Size = new System.Drawing.Size(325, 90);
            this.BTN_CreerQuestion.TabIndex = 1;
            this.BTN_CreerQuestion.Text = "Ajouter des questions";
            this.BTN_CreerQuestion.UseVisualStyleBackColor = true;
            this.BTN_CreerQuestion.Click += new System.EventHandler(this.BTN_CreerQuestion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 212);
            this.Controls.Add(this.BTN_CreerQuestion);
            this.Controls.Add(this.BTN_CreerPartie);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CreerPartie;
        private System.Windows.Forms.Button BTN_CreerQuestion;
    }
}