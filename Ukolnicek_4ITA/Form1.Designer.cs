namespace Ukolnicek_4ITA
{
    partial class Form1
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

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textLabel = new System.Windows.Forms.Label();
            this.casLabel = new System.Windows.Forms.Label();
            this.nadpisLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 903);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textLabel);
            this.panel1.Controls.Add(this.casLabel);
            this.panel1.Controls.Add(this.nadpisLabel);
            this.panel1.Location = new System.Drawing.Point(772, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 483);
            this.panel1.TabIndex = 1;
            // 
            // textLabel
            // 
            this.textLabel.AutoEllipsis = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLabel.Location = new System.Drawing.Point(26, 131);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(582, 332);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "kdjfskldfj kdjfskldfj kdjfskldfj kdjfskldfj kdjfskldfj kdjfskldfj kdjfskldfj kdjf" +
    "skldfj kdjfskldfj kdjfskl";
            // 
            // casLabel
            // 
            this.casLabel.AutoSize = true;
            this.casLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.casLabel.Location = new System.Drawing.Point(26, 75);
            this.casLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.casLabel.Name = "casLabel";
            this.casLabel.Size = new System.Drawing.Size(260, 29);
            this.casLabel.TabIndex = 1;
            this.casLabel.Text = "(čas přidání poznámky)";
            // 
            // nadpisLabel
            // 
            this.nadpisLabel.AutoSize = true;
            this.nadpisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisLabel.Location = new System.Drawing.Point(22, 25);
            this.nadpisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nadpisLabel.Name = "nadpisLabel";
            this.nadpisLabel.Size = new System.Drawing.Size(164, 52);
            this.nadpisLabel.TabIndex = 0;
            this.nadpisLabel.Text = "Nadpis";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(978, 826);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(423, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Přidat poznámku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 940);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label casLabel;
        private System.Windows.Forms.Label nadpisLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textLabel;
    }
}

