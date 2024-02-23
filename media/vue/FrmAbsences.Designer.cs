
namespace media
{
    partial class FrmAbsences
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
            this.btnRetourPersonnel = new System.Windows.Forms.Button();
            this.btnSuppAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourPersonnel
            // 
            this.btnRetourPersonnel.Location = new System.Drawing.Point(424, 234);
            this.btnRetourPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetourPersonnel.Name = "btnRetourPersonnel";
            this.btnRetourPersonnel.Size = new System.Drawing.Size(133, 29);
            this.btnRetourPersonnel.TabIndex = 9;
            this.btnRetourPersonnel.Text = "Retour liste personnel";
            this.btnRetourPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSuppAbsence
            // 
            this.btnSuppAbsence.Location = new System.Drawing.Point(286, 234);
            this.btnSuppAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuppAbsence.Name = "btnSuppAbsence";
            this.btnSuppAbsence.Size = new System.Drawing.Size(133, 29);
            this.btnSuppAbsence.TabIndex = 8;
            this.btnSuppAbsence.Text = "Supprimer absence";
            this.btnSuppAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(149, 234);
            this.btnModifAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(133, 29);
            this.btnModifAbsence.TabIndex = 7;
            this.btnModifAbsence.Text = "Modifier absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(12, 234);
            this.btnAjoutAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(133, 29);
            this.btnAjoutAbsence.TabIndex = 6;
            this.btnAjoutAbsence.Text = "Ajouter absence";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(11, 11);
            this.dgvAbsences.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 62;
            this.dgvAbsences.RowTemplate.Height = 28;
            this.dgvAbsences.Size = new System.Drawing.Size(546, 219);
            this.dgvAbsences.TabIndex = 5;
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 275);
            this.Controls.Add(this.btnRetourPersonnel);
            this.Controls.Add(this.btnSuppAbsence);
            this.Controls.Add(this.btnModifAbsence);
            this.Controls.Add(this.btnAjoutAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "FrmAbsences";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetourPersonnel;
        private System.Windows.Forms.Button btnSuppAbsence;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.DataGridView dgvAbsences;
    }
}

