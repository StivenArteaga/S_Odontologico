namespace Oclusoft_Prueba_Material_Design
{
    partial class Reporte
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
            this.DataSetReporte = new Oclusoft_Prueba_Material_Design.DataSetReporte();
            this.reporte1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte1TableAdapter = new Oclusoft_Prueba_Material_Design.DataSetReporteTableAdapters.reporte1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Oclusoft_Prueba_Material_Design.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(665, 317);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReporte
            // 
            this.DataSetReporte.DataSetName = "DataSetReporte";
            this.DataSetReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte1BindingSource
            // 
            this.reporte1BindingSource.DataMember = "reporte1";
            this.reporte1BindingSource.DataSource = this.DataSetReporte;
            // 
            // reporte1TableAdapter
            // 
            this.reporte1TableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 317);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte1BindingSource;
        private DataSetReporte DataSetReporte;
        private DataSetReporteTableAdapters.reporte1TableAdapter reporte1TableAdapter;
    }
}