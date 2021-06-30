
namespace STE
{
    partial class TÉLÉTHON
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
            this.txtNomUtilisateur = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.AutoSize = true;
            this.txtNomUtilisateur.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomUtilisateur.CausesValidation = false;
            this.txtNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUtilisateur.Location = new System.Drawing.Point(36, 173);
            this.txtNomUtilisateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(147, 20);
            this.txtNomUtilisateur.TabIndex = 0;
            this.txtNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.AutoSize = true;
            this.txtMotDePasse.BackColor = System.Drawing.SystemColors.Info;
            this.txtMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotDePasse.Location = new System.Drawing.Point(36, 198);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(120, 18);
            this.txtMotDePasse.TabIndex = 1;
            this.txtMotDePasse.Text = "Mot de passe :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 174);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Gold;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(205, 221);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 31);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Gold;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(350, 222);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(83, 30);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // TÉLÉTHON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STE.Properties.Resources.parent_and_child_hands_handing_flowers_PWCMEY6_2_scaled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(523, 262);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtNomUtilisateur);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TÉLÉTHON";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNomUtilisateur;
        private System.Windows.Forms.Label txtMotDePasse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

