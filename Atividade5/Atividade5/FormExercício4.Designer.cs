namespace frmPrincipal
{
    partial class FormExercício4
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
            this.rchText = new System.Windows.Forms.RichTextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchText
            // 
            this.rchText.Location = new System.Drawing.Point(66, 21);
            this.rchText.Name = "rchText";
            this.rchText.Size = new System.Drawing.Size(651, 393);
            this.rchText.TabIndex = 0;
            this.rchText.Text = "";
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(66, 492);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(119, 53);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Caracteres Numéricos";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(324, 492);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(119, 53);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfa
            // 
            this.btnAlfa.Location = new System.Drawing.Point(598, 492);
            this.btnAlfa.Name = "btnAlfa";
            this.btnAlfa.Size = new System.Drawing.Size(119, 53);
            this.btnAlfa.TabIndex = 3;
            this.btnAlfa.Text = "Carácteres Alfabéticos";
            this.btnAlfa.UseVisualStyleBackColor = true;
            this.btnAlfa.Click += new System.EventHandler(this.btnAlfa_Click);
            // 
            // FormExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 599);
            this.Controls.Add(this.btnAlfa);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.rchText);
            this.Name = "FormExercício4";
            this.Text = "FormExercício4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchText;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfa;
    }
}