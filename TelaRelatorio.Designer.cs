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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cantinaDBDataSet = new Cantina.cantinaDBDataSet();
            this.cantinaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantinaDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Cantina.cantinaDBDataSetTableAdapters.pedidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cantina.Relatorios.Vendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(646, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // cantinaDBDataSet
            // 
            this.cantinaDBDataSet.DataSetName = "cantinaDBDataSet";
            this.cantinaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.cantinaDBDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 464);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TelaRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.TelaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
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