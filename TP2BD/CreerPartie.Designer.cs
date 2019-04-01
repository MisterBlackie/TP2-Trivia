namespace TP2BD
{
    partial class CreerPartie
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
            this.LBX_AvailablePlayer = new System.Windows.Forms.ListBox();
            this.LBX_AddedPlayer = new System.Windows.Forms.ListBox();
            this.BTN_AddPlayer = new System.Windows.Forms.Button();
            this.BTN_RemovePlayer = new System.Windows.Forms.Button();
            this.BTN_CreateGame = new System.Windows.Forms.Button();
            this.BTN_CreatePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBX_AvailablePlayer
            // 
            this.LBX_AvailablePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBX_AvailablePlayer.FormattingEnabled = true;
            this.LBX_AvailablePlayer.Location = new System.Drawing.Point(12, 12);
            this.LBX_AvailablePlayer.Name = "LBX_AvailablePlayer";
            this.LBX_AvailablePlayer.Size = new System.Drawing.Size(165, 186);
            this.LBX_AvailablePlayer.TabIndex = 0;
            this.LBX_AvailablePlayer.SelectedIndexChanged += new System.EventHandler(this.LBX_AvailablePlayer_SelectedIndexChanged);
            // 
            // LBX_AddedPlayer
            // 
            this.LBX_AddedPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_AddedPlayer.FormattingEnabled = true;
            this.LBX_AddedPlayer.Location = new System.Drawing.Point(239, 12);
            this.LBX_AddedPlayer.Name = "LBX_AddedPlayer";
            this.LBX_AddedPlayer.Size = new System.Drawing.Size(165, 186);
            this.LBX_AddedPlayer.TabIndex = 1;
            this.LBX_AddedPlayer.SelectedIndexChanged += new System.EventHandler(this.LBX_AddedPlayer_SelectedIndexChanged);
            // 
            // BTN_AddPlayer
            // 
            this.BTN_AddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AddPlayer.Location = new System.Drawing.Point(183, 38);
            this.BTN_AddPlayer.Name = "BTN_AddPlayer";
            this.BTN_AddPlayer.Size = new System.Drawing.Size(50, 50);
            this.BTN_AddPlayer.TabIndex = 2;
            this.BTN_AddPlayer.Text = ">>";
            this.BTN_AddPlayer.UseVisualStyleBackColor = true;
            this.BTN_AddPlayer.Click += new System.EventHandler(this.BTN_AddPlayer_Click);
            // 
            // BTN_RemovePlayer
            // 
            this.BTN_RemovePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RemovePlayer.Enabled = false;
            this.BTN_RemovePlayer.Location = new System.Drawing.Point(183, 120);
            this.BTN_RemovePlayer.Name = "BTN_RemovePlayer";
            this.BTN_RemovePlayer.Size = new System.Drawing.Size(50, 50);
            this.BTN_RemovePlayer.TabIndex = 3;
            this.BTN_RemovePlayer.Text = "<<";
            this.BTN_RemovePlayer.UseVisualStyleBackColor = true;
            this.BTN_RemovePlayer.Click += new System.EventHandler(this.BTN_RemovePlayer_Click);
            // 
            // BTN_CreateGame
            // 
            this.BTN_CreateGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CreateGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_CreateGame.Enabled = false;
            this.BTN_CreateGame.Location = new System.Drawing.Point(239, 213);
            this.BTN_CreateGame.Name = "BTN_CreateGame";
            this.BTN_CreateGame.Size = new System.Drawing.Size(165, 44);
            this.BTN_CreateGame.TabIndex = 4;
            this.BTN_CreateGame.Text = "Créer une partie";
            this.BTN_CreateGame.UseVisualStyleBackColor = true;
            this.BTN_CreateGame.Click += new System.EventHandler(this.BTN_CreateGame_Click);
            // 
            // BTN_CreatePlayer
            // 
            this.BTN_CreatePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_CreatePlayer.Location = new System.Drawing.Point(12, 213);
            this.BTN_CreatePlayer.Name = "BTN_CreatePlayer";
            this.BTN_CreatePlayer.Size = new System.Drawing.Size(165, 44);
            this.BTN_CreatePlayer.TabIndex = 5;
            this.BTN_CreatePlayer.Text = "Ajouter un joueur";
            this.BTN_CreatePlayer.UseVisualStyleBackColor = true;
            this.BTN_CreatePlayer.Click += new System.EventHandler(this.BTN_CreatePlayer_Click);
            // 
            // CreerPartie
            // 
            this.AcceptButton = this.BTN_CreateGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 273);
            this.Controls.Add(this.BTN_CreatePlayer);
            this.Controls.Add(this.BTN_CreateGame);
            this.Controls.Add(this.BTN_RemovePlayer);
            this.Controls.Add(this.BTN_AddPlayer);
            this.Controls.Add(this.LBX_AddedPlayer);
            this.Controls.Add(this.LBX_AvailablePlayer);
            this.Name = "CreerPartie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle partie";
            this.Load += new System.EventHandler(this.CreerPartie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBX_AvailablePlayer;
        private System.Windows.Forms.ListBox LBX_AddedPlayer;
        private System.Windows.Forms.Button BTN_AddPlayer;
        private System.Windows.Forms.Button BTN_RemovePlayer;
        private System.Windows.Forms.Button BTN_CreateGame;
        private System.Windows.Forms.Button BTN_CreatePlayer;
    }
}