namespace ventana
{
    partial class Cap3e3
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
            this.labelRP = new System.Windows.Forms.Label();
            this.textBoxRPro = new System.Windows.Forms.TextBox();
            this.labelP = new System.Windows.Forms.Label();
            this.buttonM3 = new System.Windows.Forms.Button();
            this.textBoxPro = new System.Windows.Forms.TextBox();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonO = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelRP
            // 
            this.labelRP.AutoSize = true;
            this.labelRP.Location = new System.Drawing.Point(26, 172);
            this.labelRP.Name = "labelRP";
            this.labelRP.Size = new System.Drawing.Size(55, 13);
            this.labelRP.TabIndex = 22;
            this.labelRP.Text = "Resultado";
            // 
            // textBoxRPro
            // 
            this.textBoxRPro.Location = new System.Drawing.Point(100, 169);
            this.textBoxRPro.Name = "textBoxRPro";
            this.textBoxRPro.ReadOnly = true;
            this.textBoxRPro.Size = new System.Drawing.Size(120, 20);
            this.textBoxRPro.TabIndex = 20;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(26, 55);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(91, 13);
            this.labelP.TabIndex = 21;
            this.labelP.Text = "Ingresar Producto";
            // 
            // buttonM3
            // 
            this.buttonM3.Location = new System.Drawing.Point(175, 71);
            this.buttonM3.Name = "buttonM3";
            this.buttonM3.Size = new System.Drawing.Size(75, 23);
            this.buttonM3.TabIndex = 19;
            this.buttonM3.Text = "Mostrar";
            this.buttonM3.UseVisualStyleBackColor = true;
            this.buttonM3.Click += new System.EventHandler(this.buttonM3_Click);
            // 
            // textBoxPro
            // 
            this.textBoxPro.Location = new System.Drawing.Point(29, 73);
            this.textBoxPro.Name = "textBoxPro";
            this.textBoxPro.Size = new System.Drawing.Size(128, 20);
            this.textBoxPro.TabIndex = 18;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(29, 109);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(128, 17);
            this.radioButtonM.TabIndex = 23;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Producto de medicina";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonO
            // 
            this.radioButtonO.AutoSize = true;
            this.radioButtonO.Location = new System.Drawing.Point(29, 132);
            this.radioButtonO.Name = "radioButtonO";
            this.radioButtonO.Size = new System.Drawing.Size(100, 17);
            this.radioButtonO.TabIndex = 24;
            this.radioButtonO.TabStop = true;
            this.radioButtonO.Text = "Otros productos";
            this.radioButtonO.UseVisualStyleBackColor = true;
            // 
            // Cap3e3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radioButtonO);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.labelRP);
            this.Controls.Add(this.textBoxRPro);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.buttonM3);
            this.Controls.Add(this.textBoxPro);
            this.Name = "Cap3e3";
            this.Text = "Impuesto de un producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRP;
        private System.Windows.Forms.TextBox textBoxRPro;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Button buttonM3;
        private System.Windows.Forms.TextBox textBoxPro;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonO;
    }
}