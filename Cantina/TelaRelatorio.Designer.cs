namespace Cantina
{
    partial class TelaRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantinaDBDataSet = new Cantina.cantinaDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cantinaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantinaDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Cantina.cantinaDBDataSetTableAdapters.pedidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.cantinaDBDataSet;
            // 
            // cantinaDBDataSet
            // 
            this.cantinaDBDataSet.DataSetName = "cantinaDBDataSet";
            this.cantinaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.pedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cantina.Relatorios.Vendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.MaximumSize = new System.Drawing.Size(747, 464);
            this.reportViewer1.MinimumSize = new System.Drawing.Size(747, 464);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(747, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // cantinaDBDataSetBindingSource
            // 
            this.cantinaDBDataSetBindingSource.DataSource = this.cantinaDBDataSet;
            this.cantinaDBDataSetBindingSource.Position = 0;
            // 
            // cantinaDBDataSetBindingSource1
            // 
            this.cantinaDBDataSetBindingSource1.DataSource = this.cantinaDBDataSet;
            this.cantinaDBDataSetBindingSource1.Position = 0;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(747, 464);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(763, 503);
            this.MinimumSize = new System.Drawing.Size(763, 503);
            this.Name = "TelaRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.TelaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cantinaDBDataSetBindingSource;
        private cantinaDBDataSet cantinaDBDataSet;
        private System.Windows.Forms.BindingSource cantinaDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private cantinaDBDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
    }
}