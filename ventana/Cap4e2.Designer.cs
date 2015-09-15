namespace ventana
{
    partial class Cap4e2
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEl = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.textBoxREl = new System.Windows.Forms.TextBox();
            this.labelNu = new System.Windows.Forms.Label();
            this.buttonMEl = new System.Windows.Forms.Button();
            this.textBoxNu1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingresar la Potencia";
            // 
            // textBoxEl
            // 
            this.textBoxEl.Location = new System.Drawing.Point(147, 88);
            this.textBoxEl.Name = "textBoxEl";
            this.textBoxEl.Size = new System.Drawing.Size(113, 20);
            this.textBoxEl.TabIndex = 15;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(12, 166);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(55, 13);
            this.labelR.TabIndex = 19;
            this.labelR.Text = "Resultado";
            // 
            // textBoxREl
            // 
            this.textBoxREl.Location = new System.Drawing.Point(73, 163);
            this.textBoxREl.Name = "textBoxREl";
            this.textBoxREl.ReadOnly = true;
            this.textBoxREl.Size = new System.Drawing.Size(110, 20);
            this.textBoxREl.TabIndex = 17;
            // 
            // labelNu
            // 
            this.labelNu.AutoSize = true;
            this.labelNu.Location = new System.Drawing.Point(9, 72);
            this.labelNu.Name = "labelNu";
            this.labelNu.Size = new System.Drawing.Size(96, 13);
            this.labelNu.TabIndex = 18;
            this.labelNu.Text = "Ingresar el Numero";
            // 
            // buttonMEl
            // 
            this.buttonMEl.Location = new System.Drawing.Point(189, 161);
            this.buttonMEl.Name = "buttonMEl";
            this.buttonMEl.Size = new System.Drawing.Size(75, 23);
            this.buttonMEl.TabIndex = 16;
            this.buttonMEl.Text = "Mostrar";
            this.buttonMEl.UseVisualStyleBackColor = true;
            this.buttonMEl.Click += new System.EventHandler(this.buttonMEl_Click);
            // 
            // textBoxNu1
            // 
            this.textBoxNu1.Location = new System.Drawing.Point(12, 88);
            this.textBoxNu1.Name = "textBoxNu1";
            this.textBoxNu1.Size = new System.Drawing.Size(111, 20);
            this.textBoxNu1.TabIndex = 14;
            // 
            // Cap4e2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEl);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxREl);
            this.Controls.Add(this.labelNu);
            this.Controls.Add(this.buttonMEl);
            this.Controls.Add(this.textBoxNu1);
            this.Name = "Cap4e2";
            this.Text = "Cap4e2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEl;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxREl;
        private System.Windows.Forms.Label labelNu;
        private System.Windows.Forms.Button buttonMEl;
        private System.Windows.Forms.TextBox textBoxNu1;
    }
}