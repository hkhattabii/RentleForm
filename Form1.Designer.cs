﻿
namespace RentleForm
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
            this.bt_occupantForm = new System.Windows.Forms.Button();
            this.bt_guarantorForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_occupantForm
            // 
            this.bt_occupantForm.Location = new System.Drawing.Point(125, 77);
            this.bt_occupantForm.Name = "bt_occupantForm";
            this.bt_occupantForm.Size = new System.Drawing.Size(106, 36);
            this.bt_occupantForm.TabIndex = 1;
            this.bt_occupantForm.Text = "Ajouter un locataire";
            this.bt_occupantForm.UseVisualStyleBackColor = true;
            // 
            // bt_guarantorForm
            // 
            this.bt_guarantorForm.Location = new System.Drawing.Point(125, 12);
            this.bt_guarantorForm.Name = "bt_guarantorForm";
            this.bt_guarantorForm.Size = new System.Drawing.Size(106, 36);
            this.bt_guarantorForm.TabIndex = 2;
            this.bt_guarantorForm.Text = "Ajouter un guarant";
            this.bt_guarantorForm.UseVisualStyleBackColor = true;
            this.bt_guarantorForm.Click += new System.EventHandler(this.onButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 125);
            this.Controls.Add(this.bt_guarantorForm);
            this.Controls.Add(this.bt_occupantForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_occupantForm;
        private System.Windows.Forms.Button bt_guarantorForm;
    }
}

