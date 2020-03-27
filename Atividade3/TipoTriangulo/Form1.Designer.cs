namespace Atividade3
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(104, 289);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 46);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(51, 66);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(53, 20);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Lado_a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(51, 117);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(54, 20);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "Lado_b";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(51, 170);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(53, 20);
            this.lblc.TabIndex = 3;
            this.lblc.Text = "Lado_c";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(259, 212);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(127, 66);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(127, 119);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(127, 170);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(262, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 46);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 365);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnClear;
    }
}

