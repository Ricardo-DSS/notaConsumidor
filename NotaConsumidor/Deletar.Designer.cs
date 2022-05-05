namespace NotaConsumidor
{
    partial class Deletar
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
            this.lblDeletar = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDeletar
            // 
            this.lblDeletar.AutoSize = true;
            this.lblDeletar.Location = new System.Drawing.Point(363, 35);
            this.lblDeletar.Name = "lblDeletar";
            this.lblDeletar.Size = new System.Drawing.Size(41, 13);
            this.lblDeletar.TabIndex = 0;
            this.lblDeletar.Text = "Deletar";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(42, 114);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(82, 111);
            this.mtbCNPJ.Mask = "00.000.000/0009-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(107, 20);
            this.mtbCNPJ.TabIndex = 3;
            // 
            // Deletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblDeletar);
            this.Name = "Deletar";
            this.Text = "Deletar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeletar;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
    }
}