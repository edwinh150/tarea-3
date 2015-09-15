namespace ventana
{
    partial class Cap3e5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagec = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMP = new System.Windows.Forms.Button();
            this.textBoxNP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMA = new System.Windows.Forms.Button();
            this.textBoxPA = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPagec.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagec);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 305);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPagec
            // 
            this.tabPagec.Controls.Add(this.label3);
            this.tabPagec.Controls.Add(this.textBoxLP);
            this.tabPagec.Controls.Add(this.label2);
            this.tabPagec.Controls.Add(this.textBoxR);
            this.tabPagec.Controls.Add(this.label1);
            this.tabPagec.Controls.Add(this.buttonMP);
            this.tabPagec.Controls.Add(this.textBoxNP);
            this.tabPagec.Location = new System.Drawing.Point(4, 22);
            this.tabPagec.Name = "tabPagec";
            this.tabPagec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagec.Size = new System.Drawing.Size(317, 279);
            this.tabPagec.TabIndex = 0;
            this.tabPagec.Text = "Perimetro";
            this.tabPagec.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxLA);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxR2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonMA);
            this.tabPage2.Controls.Add(this.textBoxPA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Area";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresar longitud";
            // 
            // textBoxLP
            // 
            this.textBoxLP.Location = new System.Drawing.Point(168, 95);
            this.textBoxLP.Name = "textBoxLP";
            this.textBoxLP.Size = new System.Drawing.Size(113, 20);
            this.textBoxLP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resultado";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(107, 170);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(120, 20);
            this.textBoxR.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingresar n de lados";
            // 
            // buttonMP
            // 
            this.buttonMP.Location = new System.Drawing.Point(206, 141);
            this.buttonMP.Name = "buttonMP";
            this.buttonMP.Size = new System.Drawing.Size(75, 23);
            this.buttonMP.TabIndex = 9;
            this.buttonMP.Text = "Mostrar";
            this.buttonMP.UseVisualStyleBackColor = true;
            this.buttonMP.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // textBoxNP
            // 
            this.textBoxNP.Location = new System.Drawing.Point(33, 95);
            this.textBoxNP.Name = "textBoxNP";
            this.textBoxNP.Size = new System.Drawing.Size(111, 20);
            this.textBoxNP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingresar la Apotema";
            // 
            // textBoxLA
            // 
            this.textBoxLA.Location = new System.Drawing.Point(165, 95);
            this.textBoxLA.Name = "textBoxLA";
            this.textBoxLA.Size = new System.Drawing.Size(113, 20);
            this.textBoxLA.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resultado";
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(104, 170);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.ReadOnly = true;
            this.textBoxR2.Size = new System.Drawing.Size(120, 20);
            this.textBoxR2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingresar el Perimetro";
            // 
            // buttonMA
            // 
            this.buttonMA.Location = new System.Drawing.Point(203, 141);
            this.buttonMA.Name = "buttonMA";
            this.buttonMA.Size = new System.Drawing.Size(75, 23);
            this.buttonMA.TabIndex = 9;
            this.buttonMA.Text = "Mostrar";
            this.buttonMA.UseVisualStyleBackColor = true;
            this.buttonMA.Click += new System.EventHandler(this.buttonMA_Click);
            // 
            // textBoxPA
            // 
            this.textBoxPA.Location = new System.Drawing.Point(30, 95);
            this.textBoxPA.Name = "textBoxPA";
            this.textBoxPA.Size = new System.Drawing.Size(111, 20);
            this.textBoxPA.TabIndex = 7;
            // 
            // Cap3e5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cap3e5";
            this.Text = "Calculo de un poligono regular";
            this.tabControl1.ResumeLayout(false);
            this.tabPagec.ResumeLayout(false);
            this.tabPagec.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagec;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMP;
        private System.Windows.Forms.TextBox textBoxNP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonMA;
        private System.Windows.Forms.TextBox textBoxPA;
    }
}