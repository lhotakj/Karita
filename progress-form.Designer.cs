namespace GpxHeatmap
{
    partial class ProgressForm
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
            this.logtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logtext
            // 
            this.logtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logtext.BackColor = System.Drawing.Color.Black;
            this.logtext.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtext.ForeColor = System.Drawing.Color.White;
            this.logtext.Location = new System.Drawing.Point(12, 12);
            this.logtext.Multiline = true;
            this.logtext.Name = "logtext";
            this.logtext.ReadOnly = true;
            this.logtext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtext.Size = new System.Drawing.Size(535, 786);
            this.logtext.TabIndex = 0;
            this.logtext.VisibleChanged += new System.EventHandler(this.logtext_VisibleChanged);
            this.logtext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logtext_MouseMove);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 810);
            this.Controls.Add(this.logtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProgressForm";
            this.Text = "Log";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgressForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox logtext;
    }
}