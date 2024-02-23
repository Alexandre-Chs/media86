
namespace media
{
    partial class Media
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAddAbs = new System.Windows.Forms.Button();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();
            this.btnRetourPersonnel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.Size = new System.Drawing.Size(508, 236);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnAddAbs
            // 
            this.btnAddAbs.Location = new System.Drawing.Point(12, 254);
            this.btnAddAbs.Name = "btnAddAbs";
            this.btnAddAbs.Size = new System.Drawing.Size(109, 23);
            this.btnAddAbs.TabIndex = 1;
            this.btnAddAbs.Text = "Ajouter absence";
            this.btnAddAbs.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.Location = new System.Drawing.Point(127, 254);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(109, 23);
            this.btnModifierAbs.TabIndex = 2;
            this.btnModifierAbs.Text = "Modifier absence";
            this.btnModifierAbs.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbs
            // 
            this.btnSupprimerAbs.Location = new System.Drawing.Point(242, 254);
            this.btnSupprimerAbs.Name = "btnSupprimerAbs";
            this.btnSupprimerAbs.Size = new System.Drawing.Size(136, 23);
            this.btnSupprimerAbs.TabIndex = 3;
            this.btnSupprimerAbs.Text = "Supprimer absence";
            this.btnSupprimerAbs.UseVisualStyleBackColor = true;
            // 
            // btnRetourPersonnel
            // 
            this.btnRetourPersonnel.Location = new System.Drawing.Point(384, 254);
            this.btnRetourPersonnel.Name = "btnRetourPersonnel";
            this.btnRetourPersonnel.Size = new System.Drawing.Size(136, 23);
            this.btnRetourPersonnel.TabIndex = 4;
            this.btnRetourPersonnel.Text = "Retour liste du personnel";
            this.btnRetourPersonnel.UseVisualStyleBackColor = true;
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 288);
            this.Controls.Add(this.btnRetourPersonnel);
            this.Controls.Add(this.btnSupprimerAbs);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.btnAddAbs);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "Media";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnAddAbs;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnSupprimerAbs;
        private System.Windows.Forms.Button btnRetourPersonnel;
    }
}

