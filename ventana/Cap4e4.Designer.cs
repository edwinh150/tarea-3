namespace ventana
{
    partial class Cap4e4
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
            this.buttonMPri = new System.Windows.Forms.Button();
            this.richTextBoxPri = new System.Windows.Forms.RichTextBox();
            this.labelRPr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMPri
            // 
            this.buttonMPri.Location = new System.Drawing.Point(193, 25);
            this.buttonMPri.Name = "buttonMPri";
            this.buttonMPri.Size = new System.Drawing.Size(75, 23);
            this.buttonMPri.TabIndex = 2;
            this.buttonMPri.Text = "Mostrar";
            this.buttonMPri.UseVisualStyleBackColor = true;
            this.buttonMPri.Click += new System.EventHandler(this.buttonMPri_Click);
            // 
            // richTextBoxPri
            // 
            this.richTextBoxPri.Location = new System.Drawing.Point(25, 70);
            this.richTextBoxPri.Name = "richTextBoxPri";
            this.richTextBoxPri.Size = new System.Drawing.Size(228, 220);
            this.richTextBoxPri.TabIndex = 3;
            this.richTextBoxPri.Text = "";
            // 
            // labelRPr
            // 
            this.labelRPr.AutoSize = true;
            this.labelRPr.Location = new System.Drawing.Point(113, 54);
            this.labelRPr.Name = "labelRPr";
            this.labelRPr.Size = new System.Drawing.Size(55, 13);
            this.labelRPr.TabIndex = 4;
            this.labelRPr.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Todos los numero primo hasta 1000";
            // 
            // Cap4e4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRPr);
            this.Controls.Add(this.richTextBoxPri);
            this.Controls.Add(this.buttonMPri);
            this.Name = "Cap4e4";
            this.Text = "Numeros primo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMPri;
        private System.Windows.Forms.RichTextBox richTextBoxPri;
        private System.Windows.Forms.Label labelRPr;
        private System.Windows.Forms.Label label1;
    }
}