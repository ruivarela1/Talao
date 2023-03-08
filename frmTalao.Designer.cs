namespace Talao
{
    partial class frmTalao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTalao));
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownQtd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTalao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(22, 45);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(141, 24);
            this.comboBoxProduto.TabIndex = 0;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // numericUpDownQtd
            // 
            this.numericUpDownQtd.Location = new System.Drawing.Point(196, 47);
            this.numericUpDownQtd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQtd.Name = "numericUpDownQtd";
            this.numericUpDownQtd.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownQtd.TabIndex = 2;
            this.numericUpDownQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQtd.ValueChanged += new System.EventHandler(this.numericUpDownQtd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade:";
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(341, 47);
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxPreco.TabIndex = 4;
            this.maskedTextBoxPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(401, 96);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(245, 41);
            this.buttonImprimir.TabIndex = 6;
            this.buttonImprimir.Text = "Imprimir Talão";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(460, 47);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(186, 22);
            this.textBoxTotal.TabIndex = 7;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // textBoxTalao
            // 
            this.textBoxTalao.Location = new System.Drawing.Point(23, 161);
            this.textBoxTalao.Multiline = true;
            this.textBoxTalao.Name = "textBoxTalao";
            this.textBoxTalao.Size = new System.Drawing.Size(624, 194);
            this.textBoxTalao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Talão:";
            // 
            // textBoxPagar
            // 
            this.textBoxPagar.Enabled = false;
            this.textBoxPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPagar.Location = new System.Drawing.Point(460, 376);
            this.textBoxPagar.Name = "textBoxPagar";
            this.textBoxPagar.ReadOnly = true;
            this.textBoxPagar.Size = new System.Drawing.Size(185, 26);
            this.textBoxPagar.TabIndex = 11;
            this.textBoxPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pagar:";
            // 
            // frmTalao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTalao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownQtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTalao";
            this.Text = "Talão";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTalao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPagar;
        private System.Windows.Forms.Label label6;
    }
}

