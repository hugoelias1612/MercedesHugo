using System.Windows.Forms;

namespace ArimaERP.EmpleadoProducto
{
    public partial class MDIProductos : Form
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PContent = new System.Windows.Forms.Panel();
            this.TLPBody = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.TLPBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // PContent
            // 
            this.PContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContent.Location = new System.Drawing.Point(0, 97);
            this.PContent.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.PContent.Name = "PContent";
            this.PContent.Size = new System.Drawing.Size(1264, 584);
            this.PContent.TabIndex = 1;
            // 
            // TLPBody
            // 
            this.TLPBody.BackColor = System.Drawing.Color.White;
            this.TLPBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TLPBody.ColumnCount = 1;
            this.TLPBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBody.Controls.Add(this.PContent, 0, 1);
            this.TLPBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBody.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLPBody.Location = new System.Drawing.Point(0, 0);
            this.TLPBody.Margin = new System.Windows.Forms.Padding(0);
            this.TLPBody.Name = "TLPBody";
            this.TLPBody.RowCount = 2;
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06902F));
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.93098F));
            this.TLPBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPBody.Size = new System.Drawing.Size(1264, 681);
            this.TLPBody.TabIndex = 0;
            this.TLPBody.Paint += new System.Windows.Forms.PaintEventHandler(this.TLPBody_Paint);
            // 
            // MDIProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TLPBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MDIProductos";
            this.Text = "Arima ERP - Empleado Productos";
            this.Load += new System.EventHandler(this.MDIProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.TLPBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private Timer timer1;
        private Panel PContent;
        private TableLayoutPanel TLPBody;
    }
}