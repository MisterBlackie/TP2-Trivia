namespace TP2BD
{
    partial class AfficherQuestion
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
            this.LB_Question = new System.Windows.Forms.Label();
            this.RB_Rep4 = new TP2BD.ReponseButton();
            this.RB_Rep3 = new TP2BD.ReponseButton();
            this.RB_Rep2 = new TP2BD.ReponseButton();
            this.RB_Rep1 = new TP2BD.ReponseButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question: ";
            // 
            // LB_Question
            // 
            this.LB_Question.AutoSize = true;
            this.LB_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Question.Location = new System.Drawing.Point(111, 29);
            this.LB_Question.Name = "LB_Question";
            this.LB_Question.Size = new System.Drawing.Size(51, 20);
            this.LB_Question.TabIndex = 5;
            this.LB_Question.Text = "label2";
            // 
            // RB_Rep4
            // 
            this.RB_Rep4.AutoSize = true;
            this.RB_Rep4.IDReponse = 0;
            this.RB_Rep4.Location = new System.Drawing.Point(46, 155);
            this.RB_Rep4.Name = "RB_Rep4";
            this.RB_Rep4.Size = new System.Drawing.Size(100, 17);
            this.RB_Rep4.TabIndex = 4;
            this.RB_Rep4.TabStop = true;
            this.RB_Rep4.Text = "reponseButton4";
            this.RB_Rep4.UseVisualStyleBackColor = true;
            // 
            // RB_Rep3
            // 
            this.RB_Rep3.AutoSize = true;
            this.RB_Rep3.IDReponse = 0;
            this.RB_Rep3.Location = new System.Drawing.Point(46, 132);
            this.RB_Rep3.Name = "RB_Rep3";
            this.RB_Rep3.Size = new System.Drawing.Size(100, 17);
            this.RB_Rep3.TabIndex = 3;
            this.RB_Rep3.TabStop = true;
            this.RB_Rep3.Text = "reponseButton3";
            this.RB_Rep3.UseVisualStyleBackColor = true;
            // 
            // RB_Rep2
            // 
            this.RB_Rep2.AutoSize = true;
            this.RB_Rep2.IDReponse = 0;
            this.RB_Rep2.Location = new System.Drawing.Point(46, 109);
            this.RB_Rep2.Name = "RB_Rep2";
            this.RB_Rep2.Size = new System.Drawing.Size(100, 17);
            this.RB_Rep2.TabIndex = 2;
            this.RB_Rep2.TabStop = true;
            this.RB_Rep2.Text = "reponseButton2";
            this.RB_Rep2.UseVisualStyleBackColor = true;
            // 
            // RB_Rep1
            // 
            this.RB_Rep1.AutoSize = true;
            this.RB_Rep1.IDReponse = 0;
            this.RB_Rep1.Location = new System.Drawing.Point(46, 86);
            this.RB_Rep1.Name = "RB_Rep1";
            this.RB_Rep1.Size = new System.Drawing.Size(100, 17);
            this.RB_Rep1.TabIndex = 1;
            this.RB_Rep1.TabStop = true;
            this.RB_Rep1.Text = "reponseButton1";
            this.RB_Rep1.UseVisualStyleBackColor = true;
            this.RB_Rep1.CheckedChanged += new System.EventHandler(this.reponseButton1_CheckedChanged);
            // 
            // AfficherQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 180);
            this.Controls.Add(this.LB_Question);
            this.Controls.Add(this.RB_Rep4);
            this.Controls.Add(this.RB_Rep3);
            this.Controls.Add(this.RB_Rep2);
            this.Controls.Add(this.RB_Rep1);
            this.Controls.Add(this.label1);
            this.Name = "AfficherQuestion";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ReponseButton RB_Rep1;
        private ReponseButton RB_Rep2;
        private ReponseButton RB_Rep3;
        private ReponseButton RB_Rep4;
        private System.Windows.Forms.Label LB_Question;
    }
}