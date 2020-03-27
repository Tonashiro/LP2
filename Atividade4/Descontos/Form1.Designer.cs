namespace Atividade4
{
    partial class Form1
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
            this.btnDesc = new System.Windows.Forms.Button();
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRRF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.checkCasado = new System.Windows.Forms.CheckBox();
            this.mTxtAliINSS = new System.Windows.Forms.MaskedTextBox();
            this.mTxtAliIRRF = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalFam = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mTxtFunc = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mTxtNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDesc
            // 
            this.btnDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.Location = new System.Drawing.Point(31, 180);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(199, 37);
            this.btnDesc.TabIndex = 0;
            this.btnDesc.Text = "Verificar descontos";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(22, 37);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(93, 13);
            this.lblFunc.TabIndex = 3;
            this.lblFunc.Text = "Nome Funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(25, 88);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalBruto.TabIndex = 4;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(28, 142);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblFilhos.TabIndex = 5;
            this.lblFilhos.Text = "Número de filhos";
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(34, 32);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(73, 17);
            this.radioM.TabIndex = 7;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(34, 67);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(67, 17);
            this.radioF.TabIndex = 8;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(382, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(25, 305);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(75, 13);
            this.lblINSS.TabIndex = 11;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblIRRF
            // 
            this.lblIRRF.AutoSize = true;
            this.lblIRRF.Location = new System.Drawing.Point(25, 356);
            this.lblIRRF.Name = "lblIRRF";
            this.lblIRRF.Size = new System.Drawing.Size(75, 13);
            this.lblIRRF.TabIndex = 12;
            this.lblIRRF.Text = "Alíquota IRRF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(28, 404);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalFamilia.TabIndex = 13;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(28, 449);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(78, 13);
            this.lblSalLiq.TabIndex = 14;
            this.lblSalLiq.Text = "Salário Líquido";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(397, 305);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescINSS.TabIndex = 15;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(397, 355);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescIRPF.TabIndex = 16;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(31, 241);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 23;
            // 
            // checkCasado
            // 
            this.checkCasado.AutoSize = true;
            this.checkCasado.Location = new System.Drawing.Point(400, 200);
            this.checkCasado.Name = "checkCasado";
            this.checkCasado.Size = new System.Drawing.Size(62, 17);
            this.checkCasado.TabIndex = 25;
            this.checkCasado.Text = "Casado";
            this.checkCasado.UseVisualStyleBackColor = true;
            // 
            // mTxtAliINSS
            // 
            this.mTxtAliINSS.Enabled = false;
            this.mTxtAliINSS.Location = new System.Drawing.Point(130, 298);
            this.mTxtAliINSS.Mask = "0.00%";
            this.mTxtAliINSS.Name = "mTxtAliINSS";
            this.mTxtAliINSS.Size = new System.Drawing.Size(100, 20);
            this.mTxtAliINSS.TabIndex = 26;
            // 
            // mTxtAliIRRF
            // 
            this.mTxtAliIRRF.Enabled = false;
            this.mTxtAliIRRF.Location = new System.Drawing.Point(130, 356);
            this.mTxtAliIRRF.Mask = "0.00%";
            this.mTxtAliIRRF.Name = "mTxtAliIRRF";
            this.mTxtAliIRRF.Size = new System.Drawing.Size(100, 20);
            this.mTxtAliIRRF.TabIndex = 27;
            // 
            // mTxtSalFam
            // 
            this.mTxtSalFam.Enabled = false;
            this.mTxtSalFam.Location = new System.Drawing.Point(130, 404);
            this.mTxtSalFam.Name = "mTxtSalFam";
            this.mTxtSalFam.Size = new System.Drawing.Size(100, 20);
            this.mTxtSalFam.TabIndex = 28;
            this.mTxtSalFam.Text = "R$ 0,00";
            // 
            // mTxtSalLiq
            // 
            this.mTxtSalLiq.Enabled = false;
            this.mTxtSalLiq.Location = new System.Drawing.Point(130, 446);
            this.mTxtSalLiq.Name = "mTxtSalLiq";
            this.mTxtSalLiq.Size = new System.Drawing.Size(100, 20);
            this.mTxtSalLiq.TabIndex = 29;
            this.mTxtSalLiq.Text = "R$ 0,00";
            // 
            // mTxtDescINSS
            // 
            this.mTxtDescINSS.Enabled = false;
            this.mTxtDescINSS.Location = new System.Drawing.Point(500, 305);
            this.mTxtDescINSS.Name = "mTxtDescINSS";
            this.mTxtDescINSS.Size = new System.Drawing.Size(100, 20);
            this.mTxtDescINSS.TabIndex = 30;
            this.mTxtDescINSS.Text = "R$ 0,00";
            // 
            // mTxtDescIRPF
            // 
            this.mTxtDescIRPF.Enabled = false;
            this.mTxtDescIRPF.Location = new System.Drawing.Point(500, 347);
            this.mTxtDescIRPF.Name = "mTxtDescIRPF";
            this.mTxtDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.mTxtDescIRPF.TabIndex = 31;
            this.mTxtDescIRPF.Text = "R$ 0,00";
            // 
            // mTxtFunc
            // 
            this.mTxtFunc.Location = new System.Drawing.Point(130, 37);
            this.mTxtFunc.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "";
            this.mTxtFunc.Name = "mTxtFunc";
            this.mTxtFunc.Size = new System.Drawing.Size(100, 20);
            this.mTxtFunc.TabIndex = 32;
            // 
            // mTxtSalBruto
            // 
            this.mTxtSalBruto.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mTxtSalBruto.Location = new System.Drawing.Point(130, 85);
            this.mTxtSalBruto.Mask = "00000.00";
            this.mTxtSalBruto.Name = "mTxtSalBruto";
            this.mTxtSalBruto.Size = new System.Drawing.Size(100, 20);
            this.mTxtSalBruto.TabIndex = 33;
            this.mTxtSalBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtSalBruto_MaskInputRejected);
            // 
            // mTxtNumFilhos
            // 
            this.mTxtNumFilhos.Location = new System.Drawing.Point(130, 139);
            this.mTxtNumFilhos.Mask = "00";
            this.mTxtNumFilhos.Name = "mTxtNumFilhos";
            this.mTxtNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mTxtNumFilhos.TabIndex = 34;
            this.mTxtNumFilhos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtNumFilhos_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 509);
            this.Controls.Add(this.mTxtNumFilhos);
            this.Controls.Add(this.mTxtSalBruto);
            this.Controls.Add(this.mTxtFunc);
            this.Controls.Add(this.mTxtDescIRPF);
            this.Controls.Add(this.mTxtDescINSS);
            this.Controls.Add(this.mTxtSalLiq);
            this.Controls.Add(this.mTxtSalFam);
            this.Controls.Add(this.mTxtAliIRRF);
            this.Controls.Add(this.mTxtAliINSS);
            this.Controls.Add(this.checkCasado);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblIRRF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRRF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.CheckBox checkCasado;
        private System.Windows.Forms.MaskedTextBox mTxtAliINSS;
        private System.Windows.Forms.MaskedTextBox mTxtAliIRRF;
        private System.Windows.Forms.MaskedTextBox mTxtSalFam;
        private System.Windows.Forms.MaskedTextBox mTxtSalLiq;
        private System.Windows.Forms.MaskedTextBox mTxtDescINSS;
        private System.Windows.Forms.MaskedTextBox mTxtDescIRPF;
        private System.Windows.Forms.MaskedTextBox mTxtFunc;
        private System.Windows.Forms.MaskedTextBox mTxtNumFilhos;
        private System.Windows.Forms.MaskedTextBox mTxtSalBruto;
    }
}

