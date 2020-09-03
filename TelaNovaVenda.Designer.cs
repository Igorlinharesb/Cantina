namespace Cantina
{
    partial class TelaNovaVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.qp = new System.Windows.Forms.NumericUpDown();
            this.fechapedido = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qm = new System.Windows.Forms.NumericUpDown();
            this.qg = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.qp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // qp
            // 
            this.qp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qp.Location = new System.Drawing.Point(434, 59);
            this.qp.Name = "qp";
            this.qp.Size = new System.Drawing.Size(103, 26);
            this.qp.TabIndex = 1;
            // 
            // fechapedido
            // 
            this.fechapedido.Location = new System.Drawing.Point(404, 103);
            this.fechapedido.Name = "fechapedido";
            this.fechapedido.Size = new System.Drawing.Size(133, 33);
            this.fechapedido.TabIndex = 2;
            this.fechapedido.Text = "Fechar Pedido";
            this.fechapedido.UseVisualStyleBackColor = true;
            // 
            // cliente
            // 
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(30, 59);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(100, 26);
            this.cliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quentinhas G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quentinhas M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quentinhas P";
            // 
            // qm
            // 
            this.qm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qm.Location = new System.Drawing.Point(292, 59);
            this.qm.Name = "qm";
            this.qm.Size = new System.Drawing.Size(103, 26);
            this.qm.TabIndex = 7;
            // 
            // qg
            // 
            this.qg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qg.Location = new System.Drawing.Point(150, 59);
            this.qg.Name = "qg";
            this.qg.Size = new System.Drawing.Size(103, 26);
            this.qg.TabIndex = 8;
            // 
            // TelaNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 159);
            this.Controls.Add(this.qg);
            this.Controls.Add(this.qm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.fechapedido);
            this.Controls.Add(this.qp);
            this.Controls.Add(this.label1);
            this.Name = "TelaNovaVenda";
            this.Text = "Cadastrar Nova Venda";
            ((System.ComponentModel.ISupportInitialize)(this.qp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qp;
        private System.Windows.Forms.Button fechapedido;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown qm;
        private System.Windows.Forms.NumericUpDown qg;
    }
}