namespace mediatek86.vue
{
    partial class FrmAbsences
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
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(102, 12);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(416, 242);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(102, 278);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterAbsence.TabIndex = 1;
            this.btnAjouterAbsence.Text = "ajouter";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(273, 278);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnModifierAbsence.TabIndex = 2;
            this.btnModifierAbsence.Text = "modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(443, 278);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerAbsence.TabIndex = 3;
            this.btnSupprimerAbsence.Text = "supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "FrmAbsences";
            this.Text = "FrmAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
    }
}