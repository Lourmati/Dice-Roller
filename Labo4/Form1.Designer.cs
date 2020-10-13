namespace Labo4
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.de3 = new Labo4.De();
            this.de2 = new Labo4.De();
            this.de1 = new Labo4.De();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn1.Location = new System.Drawing.Point(12, 125);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(328, 48);
            this.Btn1.TabIndex = 3;
            this.Btn1.Text = "Lancer tous les dés";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // de3
            // 
            this.de3.BackColor = System.Drawing.Color.White;
            this.de3.Location = new System.Drawing.Point(236, 12);
            this.de3.Name = "de3";
            this.de3.Size = new System.Drawing.Size(106, 106);
            this.de3.TabIndex = 2;
            this.de3.Text = "de3";
            this.de3.Click += new System.EventHandler(this.de3_Click);
            // 
            // de2
            // 
            this.de2.BackColor = System.Drawing.Color.White;
            this.de2.Location = new System.Drawing.Point(124, 12);
            this.de2.Name = "de2";
            this.de2.Size = new System.Drawing.Size(106, 106);
            this.de2.TabIndex = 1;
            this.de2.Text = "de2";
            this.de2.Click += new System.EventHandler(this.de2_Click);
            // 
            // de1
            // 
            this.de1.BackColor = System.Drawing.Color.White;
            this.de1.Location = new System.Drawing.Point(12, 12);
            this.de1.Name = "de1";
            this.de1.Size = new System.Drawing.Size(106, 106);
            this.de1.TabIndex = 0;
            this.de1.Text = "de1";
            this.de1.Click += new System.EventHandler(this.de1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 185);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.de3);
            this.Controls.Add(this.de2);
            this.Controls.Add(this.de1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratoire 4";
            this.ResumeLayout(false);

        }

        #endregion

        private De de1;
        private De de2;
        private De de3;
        private System.Windows.Forms.Button Btn1;
    }
}

