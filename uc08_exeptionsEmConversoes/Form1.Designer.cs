namespace uc08_exeptionsEmConversoes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            txtParcelas = new TextBox();
            txtValorTotal = new TextBox();
            btnCalcular = new Button();
            txtTotalAcumulado = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 15);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Parcelas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 128);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor Total";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(78, 15);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 3;
            // 
            // txtParcelas
            // 
            txtParcelas.Location = new Point(78, 49);
            txtParcelas.Name = "txtParcelas";
            txtParcelas.Size = new Size(100, 23);
            txtParcelas.TabIndex = 4;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Enabled = false;
            txtValorTotal.Location = new Point(78, 125);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(100, 23);
            txtValorTotal.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(103, 87);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtTotalAcumulado
            // 
            txtTotalAcumulado.Enabled = false;
            txtTotalAcumulado.Location = new Point(114, 163);
            txtTotalAcumulado.Name = "txtTotalAcumulado";
            txtTotalAcumulado.Size = new Size(100, 23);
            txtTotalAcumulado.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 166);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 7;
            label4.Text = "Total Acumulado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 284);
            Controls.Add(txtTotalAcumulado);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(txtValorTotal);
            Controls.Add(txtParcelas);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValor;
        private TextBox txtParcelas;
        private TextBox txtValorTotal;
        private Button btnCalcular;
        private TextBox txtTotalAcumulado;
        private Label label4;
    }
}
