
namespace media
{
    partial class FrmPersonnel
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
            this.btnAddPers = new System.Windows.Forms.Button();
            this.btnModifierPers = new System.Windows.Forms.Button();
            this.btnSupprimerPers = new System.Windows.Forms.Button();
            this.btnAfficherAbs = new System.Windows.Forms.Button();
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
            // btnAddPers
            // 
            this.btnAddPers.Location = new System.Drawing.Point(12, 254);
            this.btnAddPers.Name = "btnAddPers";
            this.btnAddPers.Size = new System.Drawing.Size(109, 23);
            this.btnAddPers.TabIndex = 1;
            this.btnAddPers.Text = "Ajouter personnel";
            this.btnAddPers.UseVisualStyleBackColor = true;
            this.btnAddPers.Click += new System.EventHandler(this.btnAddPers_Click);
            // 
            // btnModifierPers
            // 
            this.btnModifierPers.Location = new System.Drawing.Point(127, 254);
            this.btnModifierPers.Name = "btnModifierPers";
            this.btnModifierPers.Size = new System.Drawing.Size(109, 23);
            this.btnModifierPers.TabIndex = 2;
            this.btnModifierPers.Text = "Modifier personnel";
            this.btnModifierPers.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPers
            // 
            this.btnSupprimerPers.Location = new System.Drawing.Point(242, 254);
            this.btnSupprimerPers.Name = "btnSupprimerPers";
            this.btnSupprimerPers.Size = new System.Drawing.Size(136, 23);
            this.btnSupprimerPers.TabIndex = 3;
            this.btnSupprimerPers.Text = "Supprimer personnel";
            this.btnSupprimerPers.UseVisualStyleBackColor = true;
            // 
            // btnAfficherAbs
            // 
            this.btnAfficherAbs.Location = new System.Drawing.Point(384, 254);
            this.btnAfficherAbs.Name = "btnAfficherAbs";
            this.btnAfficherAbs.Size = new System.Drawing.Size(136, 23);
            this.btnAfficherAbs.TabIndex = 4;
            this.btnAfficherAbs.Text = "Afficher absences";
            this.btnAfficherAbs.UseVisualStyleBackColor = true;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 288);
            this.Controls.Add(this.btnAfficherAbs);
            this.Controls.Add(this.btnSupprimerPers);
            this.Controls.Add(this.btnModifierPers);
            this.Controls.Add(this.btnAddPers);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "Liste du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnAddPers;
        private System.Windows.Forms.Button btnModifierPers;
        private System.Windows.Forms.Button btnSupprimerPers;
        private System.Windows.Forms.Button btnAfficherAbs;
    }
}

