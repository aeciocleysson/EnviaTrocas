
namespace EnviaTrocas.Relat
{
    partial class FrmRelatorioTrocas
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
            this.reportViewerTrocas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerTrocas
            // 
            this.reportViewerTrocas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerTrocas.LocalReport.ReportEmbeddedResource = "EnviaTrocas.Relat.ReportTrocas.rdlc";
            this.reportViewerTrocas.Location = new System.Drawing.Point(0, 0);
            this.reportViewerTrocas.Name = "reportViewerTrocas";
            this.reportViewerTrocas.ServerReport.BearerToken = null;
            this.reportViewerTrocas.Size = new System.Drawing.Size(642, 450);
            this.reportViewerTrocas.TabIndex = 0;
            // 
            // FrmRelatorioTrocas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.reportViewerTrocas);
            this.Name = "FrmRelatorioTrocas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Trocas";
            this.Load += new System.EventHandler(this.FrmRelatorioTrocas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTrocas;
    }
}