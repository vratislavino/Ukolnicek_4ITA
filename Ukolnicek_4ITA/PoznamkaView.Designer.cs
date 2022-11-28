namespace Ukolnicek_4ITA
{
    partial class PoznamkaView
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.nadpisLabel = new System.Windows.Forms.Label();
            this.casLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nadpisLabel
            // 
            this.nadpisLabel.AutoSize = true;
            this.nadpisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisLabel.Location = new System.Drawing.Point(30, 28);
            this.nadpisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nadpisLabel.Name = "nadpisLabel";
            this.nadpisLabel.Size = new System.Drawing.Size(124, 37);
            this.nadpisLabel.TabIndex = 0;
            this.nadpisLabel.Text = "Nadpis";
            this.nadpisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nadpisLabel.Click += new System.EventHandler(this.PoznamkaView_Click);
            // 
            // casLabel
            // 
            this.casLabel.AutoSize = true;
            this.casLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.casLabel.Location = new System.Drawing.Point(30, 80);
            this.casLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.casLabel.Name = "casLabel";
            this.casLabel.Size = new System.Drawing.Size(319, 33);
            this.casLabel.TabIndex = 1;
            this.casLabel.Text = "(čas přidání poznámky)";
            this.casLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.casLabel.Click += new System.EventHandler(this.PoznamkaView_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(556, 29);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 88);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Odstranit";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // PoznamkaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.casLabel);
            this.Controls.Add(this.nadpisLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PoznamkaView";
            this.Size = new System.Drawing.Size(690, 151);
            this.Click += new System.EventHandler(this.PoznamkaView_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nadpisLabel;
        private System.Windows.Forms.Label casLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}
