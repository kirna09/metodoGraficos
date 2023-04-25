namespace metodoGraficos
{
    partial class variablesAgregar
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtVy = new System.Windows.Forms.TextBox();
            this.txtVx = new System.Windows.Forms.TextBox();
            this.cmbMIM = new System.Windows.Forms.ComboBox();
            this.cmbSM = new System.Windows.Forms.ComboBox();
            this.ltboxVar = new System.Windows.Forms.ListBox();
            this.lblEc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(498, 225);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 0;
            // 
            // txtVy
            // 
            this.txtVy.Location = new System.Drawing.Point(35, 225);
            this.txtVy.Name = "txtVy";
            this.txtVy.Size = new System.Drawing.Size(100, 26);
            this.txtVy.TabIndex = 1;
            // 
            // txtVx
            // 
            this.txtVx.Location = new System.Drawing.Point(35, 107);
            this.txtVx.Name = "txtVx";
            this.txtVx.Size = new System.Drawing.Size(100, 26);
            this.txtVx.TabIndex = 2;
            // 
            // cmbMIM
            // 
            this.cmbMIM.FormattingEnabled = true;
            this.cmbMIM.Items.AddRange(new object[] {
            "≤",
            "≥"});
            this.cmbMIM.Location = new System.Drawing.Point(244, 223);
            this.cmbMIM.Name = "cmbMIM";
            this.cmbMIM.Size = new System.Drawing.Size(121, 28);
            this.cmbMIM.TabIndex = 3;
            // 
            // cmbSM
            // 
            this.cmbSM.FormattingEnabled = true;
            this.cmbSM.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbSM.Location = new System.Drawing.Point(244, 105);
            this.cmbSM.Name = "cmbSM";
            this.cmbSM.Size = new System.Drawing.Size(121, 28);
            this.cmbSM.TabIndex = 4;
            // 
            // ltboxVar
            // 
            this.ltboxVar.FormattingEnabled = true;
            this.ltboxVar.ItemHeight = 20;
            this.ltboxVar.Location = new System.Drawing.Point(35, 266);
            this.ltboxVar.Name = "ltboxVar";
            this.ltboxVar.Size = new System.Drawing.Size(152, 184);
            this.ltboxVar.TabIndex = 5;
            // 
            // lblEc
            // 
            this.lblEc.AutoSize = true;
            this.lblEc.Location = new System.Drawing.Point(531, 39);
            this.lblEc.Name = "lblEc";
            this.lblEc.Size = new System.Drawing.Size(51, 20);
            this.lblEc.TabIndex = 6;
            this.lblEc.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(458, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 47);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // variablesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEc);
            this.Controls.Add(this.ltboxVar);
            this.Controls.Add(this.cmbSM);
            this.Controls.Add(this.cmbMIM);
            this.Controls.Add(this.txtVx);
            this.Controls.Add(this.txtVy);
            this.Controls.Add(this.txtTotal);
            this.Name = "variablesAgregar";
            this.Text = "agregar variables";
            this.Load += new System.EventHandler(this.variablesAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtVy;
        private System.Windows.Forms.TextBox txtVx;
        private System.Windows.Forms.ComboBox cmbMIM;
        private System.Windows.Forms.ComboBox cmbSM;
        private System.Windows.Forms.ListBox ltboxVar;
        private System.Windows.Forms.Label lblEc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
    }
}