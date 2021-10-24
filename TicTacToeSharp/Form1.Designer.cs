namespace TicTacToeSharp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.x1y1 = new System.Windows.Forms.PictureBox();
            this.x2y1 = new System.Windows.Forms.PictureBox();
            this.x3y1 = new System.Windows.Forms.PictureBox();
            this.x1y2 = new System.Windows.Forms.PictureBox();
            this.x2y2 = new System.Windows.Forms.PictureBox();
            this.x3y2 = new System.Windows.Forms.PictureBox();
            this.x1y3 = new System.Windows.Forms.PictureBox();
            this.x2y3 = new System.Windows.Forms.PictureBox();
            this.x3y3 = new System.Windows.Forms.PictureBox();
            this.pnlJeu = new System.Windows.Forms.Panel();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.x1y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3y3)).BeginInit();
            this.pnlJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(109, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 364);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(241, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 364);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(3, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 20);
            this.panel4.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(3, 238);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(365, 20);
            this.panel8.TabIndex = 9;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(12, 414);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(100, 23);
            this.btnNouveau.TabIndex = 13;
            this.btnNouveau.Text = "Nouvelle partie";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(301, 414);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 14;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(13, 395);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(0, 13);
            this.lblJoueur.TabIndex = 15;
            // 
            // x1y1
            // 
            this.x1y1.Location = new System.Drawing.Point(3, 3);
            this.x1y1.Name = "x1y1";
            this.x1y1.Size = new System.Drawing.Size(100, 100);
            this.x1y1.TabIndex = 16;
            this.x1y1.TabStop = false;
            this.x1y1.Click += new System.EventHandler(this.pct_Click);
            // 
            // x2y1
            // 
            this.x2y1.Location = new System.Drawing.Point(135, 3);
            this.x2y1.Name = "x2y1";
            this.x2y1.Size = new System.Drawing.Size(100, 100);
            this.x2y1.TabIndex = 17;
            this.x2y1.TabStop = false;
            this.x2y1.Click += new System.EventHandler(this.pct_Click);
            // 
            // x3y1
            // 
            this.x3y1.Location = new System.Drawing.Point(267, 3);
            this.x3y1.Name = "x3y1";
            this.x3y1.Size = new System.Drawing.Size(100, 100);
            this.x3y1.TabIndex = 18;
            this.x3y1.TabStop = false;
            this.x3y1.Click += new System.EventHandler(this.pct_Click);
            // 
            // x1y2
            // 
            this.x1y2.Location = new System.Drawing.Point(3, 132);
            this.x1y2.Name = "x1y2";
            this.x1y2.Size = new System.Drawing.Size(100, 100);
            this.x1y2.TabIndex = 19;
            this.x1y2.TabStop = false;
            this.x1y2.Click += new System.EventHandler(this.pct_Click);
            // 
            // x2y2
            // 
            this.x2y2.Location = new System.Drawing.Point(135, 132);
            this.x2y2.Name = "x2y2";
            this.x2y2.Size = new System.Drawing.Size(100, 100);
            this.x2y2.TabIndex = 20;
            this.x2y2.TabStop = false;
            this.x2y2.Click += new System.EventHandler(this.pct_Click);
            // 
            // x3y2
            // 
            this.x3y2.Location = new System.Drawing.Point(267, 132);
            this.x3y2.Name = "x3y2";
            this.x3y2.Size = new System.Drawing.Size(100, 100);
            this.x3y2.TabIndex = 21;
            this.x3y2.TabStop = false;
            this.x3y2.Click += new System.EventHandler(this.pct_Click);
            // 
            // x1y3
            // 
            this.x1y3.Location = new System.Drawing.Point(3, 264);
            this.x1y3.Name = "x1y3";
            this.x1y3.Size = new System.Drawing.Size(100, 100);
            this.x1y3.TabIndex = 22;
            this.x1y3.TabStop = false;
            this.x1y3.Click += new System.EventHandler(this.pct_Click);
            // 
            // x2y3
            // 
            this.x2y3.Location = new System.Drawing.Point(135, 264);
            this.x2y3.Name = "x2y3";
            this.x2y3.Size = new System.Drawing.Size(100, 100);
            this.x2y3.TabIndex = 23;
            this.x2y3.TabStop = false;
            this.x2y3.Click += new System.EventHandler(this.pct_Click);
            // 
            // x3y3
            // 
            this.x3y3.Location = new System.Drawing.Point(267, 264);
            this.x3y3.Name = "x3y3";
            this.x3y3.Size = new System.Drawing.Size(100, 100);
            this.x3y3.TabIndex = 24;
            this.x3y3.TabStop = false;
            this.x3y3.Click += new System.EventHandler(this.pct_Click);
            // 
            // pnlJeu
            // 
            this.pnlJeu.Controls.Add(this.x3y3);
            this.pnlJeu.Controls.Add(this.x1y1);
            this.pnlJeu.Controls.Add(this.x3y2);
            this.pnlJeu.Controls.Add(this.x2y3);
            this.pnlJeu.Controls.Add(this.panel4);
            this.pnlJeu.Controls.Add(this.x3y1);
            this.pnlJeu.Controls.Add(this.x1y3);
            this.pnlJeu.Controls.Add(this.x2y2);
            this.pnlJeu.Controls.Add(this.x1y2);
            this.pnlJeu.Controls.Add(this.panel8);
            this.pnlJeu.Controls.Add(this.panel2);
            this.pnlJeu.Controls.Add(this.x2y1);
            this.pnlJeu.Controls.Add(this.panel1);
            this.pnlJeu.Location = new System.Drawing.Point(16, 4);
            this.pnlJeu.Name = "pnlJeu";
            this.pnlJeu.Size = new System.Drawing.Size(380, 373);
            this.pnlJeu.TabIndex = 25;
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ1.Location = new System.Drawing.Point(148, 417);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(20, 24);
            this.lblJ1.TabIndex = 26;
            this.lblJ1.Text = "0";
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ2.Location = new System.Drawing.Point(231, 417);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(20, 24);
            this.lblJ2.TabIndex = 27;
            this.lblJ2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 467);
            this.Controls.Add(this.lblJ2);
            this.Controls.Add(this.lblJ1);
            this.Controls.Add(this.pnlJeu);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnNouveau);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.x1y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3y3)).EndInit();
            this.pnlJeu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.PictureBox x1y1;
        private System.Windows.Forms.PictureBox x2y1;
        private System.Windows.Forms.PictureBox x3y1;
        private System.Windows.Forms.PictureBox x1y2;
        private System.Windows.Forms.PictureBox x2y2;
        private System.Windows.Forms.PictureBox x3y2;
        private System.Windows.Forms.PictureBox x1y3;
        private System.Windows.Forms.PictureBox x2y3;
        private System.Windows.Forms.PictureBox x3y3;
        private System.Windows.Forms.Panel pnlJeu;
        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.Label lblJ2;
    }
}

