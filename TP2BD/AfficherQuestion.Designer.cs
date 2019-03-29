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
            this.reponseButton1 = new TP2BD.ReponseButton();
            this.reponseButton2 = new TP2BD.ReponseButton();
            this.reponseButton3 = new TP2BD.ReponseButton();
            this.reponseButton4 = new TP2BD.ReponseButton();
            this.LB_Question = new System.Windows.Forms.Label();
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
            // reponseButton1
            // 
            this.reponseButton1.AutoSize = true;
            this.reponseButton1.IDReponse = 0;
            this.reponseButton1.Location = new System.Drawing.Point(46, 86);
            this.reponseButton1.Name = "reponseButton1";
            this.reponseButton1.Size = new System.Drawing.Size(100, 17);
            this.reponseButton1.TabIndex = 1;
            this.reponseButton1.TabStop = true;
            this.reponseButton1.Text = "reponseButton1";
            this.reponseButton1.UseVisualStyleBackColor = true;
            this.reponseButton1.CheckedChanged += new System.EventHandler(this.reponseButton1_CheckedChanged);
            // 
            // reponseButton2
            // 
            this.reponseButton2.AutoSize = true;
            this.reponseButton2.IDReponse = 0;
            this.reponseButton2.Location = new System.Drawing.Point(46, 109);
            this.reponseButton2.Name = "reponseButton2";
            this.reponseButton2.Size = new System.Drawing.Size(100, 17);
            this.reponseButton2.TabIndex = 2;
            this.reponseButton2.TabStop = true;
            this.reponseButton2.Text = "reponseButton2";
            this.reponseButton2.UseVisualStyleBackColor = true;
            // 
            // reponseButton3
            // 
            this.reponseButton3.AutoSize = true;
            this.reponseButton3.IDReponse = 0;
            this.reponseButton3.Location = new System.Drawing.Point(46, 132);
            this.reponseButton3.Name = "reponseButton3";
            this.reponseButton3.Size = new System.Drawing.Size(100, 17);
            this.reponseButton3.TabIndex = 3;
            this.reponseButton3.TabStop = true;
            this.reponseButton3.Text = "reponseButton3";
            this.reponseButton3.UseVisualStyleBackColor = true;
            // 
            // reponseButton4
            // 
            this.reponseButton4.AutoSize = true;
            this.reponseButton4.IDReponse = 0;
            this.reponseButton4.Location = new System.Drawing.Point(46, 155);
            this.reponseButton4.Name = "reponseButton4";
            this.reponseButton4.Size = new System.Drawing.Size(100, 17);
            this.reponseButton4.TabIndex = 4;
            this.reponseButton4.TabStop = true;
            this.reponseButton4.Text = "reponseButton4";
            this.reponseButton4.UseVisualStyleBackColor = true;
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
            // AfficherQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 180);
            this.Controls.Add(this.LB_Question);
            this.Controls.Add(this.reponseButton4);
            this.Controls.Add(this.reponseButton3);
            this.Controls.Add(this.reponseButton2);
            this.Controls.Add(this.reponseButton1);
            this.Controls.Add(this.label1);
            this.Name = "AfficherQuestion";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ReponseButton reponseButton1;
        private ReponseButton reponseButton2;
        private ReponseButton reponseButton3;
        private ReponseButton reponseButton4;
        private System.Windows.Forms.Label LB_Question;
    }
}