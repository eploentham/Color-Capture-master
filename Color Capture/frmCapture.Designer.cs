namespace Color_Capture
{
    partial class frmCapture
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapture));
            this.txtHtmlColor = new System.Windows.Forms.TextBox();
            this.ntfColorCapture = new System.Windows.Forms.NotifyIcon(this.components);
            this.tblColors = new System.Windows.Forms.TableLayoutPanel();
            this.picSelColor = new System.Windows.Forms.PictureBox();
            this.picBtnShowHide = new System.Windows.Forms.PictureBox();
            this.picBtnCopy = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSelColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnShowHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHtmlColor
            // 
            this.txtHtmlColor.HideSelection = false;
            this.txtHtmlColor.Location = new System.Drawing.Point(75, 15);
            this.txtHtmlColor.Name = "txtHtmlColor";
            this.txtHtmlColor.ReadOnly = true;
            this.txtHtmlColor.Size = new System.Drawing.Size(148, 20);
            this.txtHtmlColor.TabIndex = 1;
            this.txtHtmlColor.TabStop = false;
            // 
            // ntfColorCapture
            // 
            this.ntfColorCapture.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfColorCapture.Icon")));
            this.ntfColorCapture.Text = "Color Capture";
            this.ntfColorCapture.Visible = true;
            this.ntfColorCapture.Click += new System.EventHandler(this.ntfColorCapture_Click);
            this.ntfColorCapture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfColorCapture_MouseDoubleClick);
            // 
            // tblColors
            // 
            this.tblColors.AutoScroll = true;
            this.tblColors.ColumnCount = 4;
            this.tblColors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblColors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblColors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblColors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblColors.Location = new System.Drawing.Point(15, 51);
            this.tblColors.Name = "tblColors";
            this.tblColors.RowCount = 1;
            this.tblColors.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblColors.Size = new System.Drawing.Size(267, 190);
            this.tblColors.TabIndex = 6;
            // 
            // picSelColor
            // 
            this.picSelColor.BackColor = System.Drawing.Color.White;
            this.picSelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelColor.Location = new System.Drawing.Point(48, 15);
            this.picSelColor.Name = "picSelColor";
            this.picSelColor.Size = new System.Drawing.Size(21, 20);
            this.picSelColor.TabIndex = 7;
            this.picSelColor.TabStop = false;
            // 
            // picBtnShowHide
            // 
            this.picBtnShowHide.Image = global::Color_Capture.Properties.Resources.down1;
            this.picBtnShowHide.Location = new System.Drawing.Point(251, 15);
            this.picBtnShowHide.Name = "picBtnShowHide";
            this.picBtnShowHide.Size = new System.Drawing.Size(21, 20);
            this.picBtnShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBtnShowHide.TabIndex = 5;
            this.picBtnShowHide.TabStop = false;
            this.picBtnShowHide.Click += new System.EventHandler(this.picBtnShowHide_Click);
            this.picBtnShowHide.MouseHover += new System.EventHandler(this.picBtnShowHide_MouseHover);
            // 
            // picBtnCopy
            // 
            this.picBtnCopy.Image = global::Color_Capture.Properties.Resources.copy1_32;
            this.picBtnCopy.Location = new System.Drawing.Point(228, 15);
            this.picBtnCopy.Name = "picBtnCopy";
            this.picBtnCopy.Size = new System.Drawing.Size(21, 20);
            this.picBtnCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBtnCopy.TabIndex = 4;
            this.picBtnCopy.TabStop = false;
            this.picBtnCopy.Click += new System.EventHandler(this.picBtnCopy_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackgroundImage = global::Color_Capture.Properties.Resources.drop6;
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Location = new System.Drawing.Point(12, 15);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(24, 20);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // frmCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 46);
            this.Controls.Add(this.picSelColor);
            this.Controls.Add(this.tblColors);
            this.Controls.Add(this.picBtnShowHide);
            this.Controls.Add(this.picBtnCopy);
            this.Controls.Add(this.txtHtmlColor);
            this.Controls.Add(this.btnCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCapture";
            this.Text = "Color Capture";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCapture_Load);
            this.Resize += new System.EventHandler(this.frmCapture_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picSelColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnShowHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox txtHtmlColor;
        private System.Windows.Forms.NotifyIcon ntfColorCapture;
        private System.Windows.Forms.PictureBox picBtnCopy;
        private System.Windows.Forms.PictureBox picBtnShowHide;
        private System.Windows.Forms.TableLayoutPanel tblColors;
        private System.Windows.Forms.PictureBox picSelColor;
    }
}

