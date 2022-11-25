namespace Ukolnicek_4ITA
{
    partial class PridaniPoznamky
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
            this.nadpisTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTextbox = new System.Windows.Forms.RichTextBox();
            this.pridatButton = new System.Windows.Forms.Button();
            this.stornoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nadpisTextbox
            // 
            this.nadpisTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisTextbox.Location = new System.Drawing.Point(97, 12);
            this.nadpisTextbox.Name = "nadpisTextbox";
            this.nadpisTextbox.Size = new System.Drawing.Size(451, 44);
            this.nadpisTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nadpis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text";
            // 
            // textTextbox
            // 
            this.textTextbox.Location = new System.Drawing.Point(97, 79);
            this.textTextbox.Name = "textTextbox";
            this.textTextbox.Size = new System.Drawing.Size(451, 342);
            this.textTextbox.TabIndex = 3;
            this.textTextbox.Text = "";
            // 
            // pridatButton
            // 
            this.pridatButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pridatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.Location = new System.Drawing.Point(417, 436);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(131, 57);
            this.pridatButton.TabIndex = 4;
            this.pridatButton.Text = "Přidat";
            this.pridatButton.UseVisualStyleBackColor = true;
            // 
            // stornoButton
            // 
            this.stornoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stornoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stornoButton.Location = new System.Drawing.Point(12, 436);
            this.stornoButton.Name = "stornoButton";
            this.stornoButton.Size = new System.Drawing.Size(131, 57);
            this.stornoButton.TabIndex = 5;
            this.stornoButton.Text = "Storno";
            this.stornoButton.UseVisualStyleBackColor = true;
            // 
            // PridaniPoznamky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 505);
            this.Controls.Add(this.stornoButton);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.textTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nadpisTextbox);
            this.Name = "PridaniPoznamky";
            this.Text = "PridaniPoznamky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nadpisTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textTextbox;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.Button stornoButton;
    }
}