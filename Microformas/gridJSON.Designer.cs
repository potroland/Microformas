namespace Microformas
{
    partial class gridJSON
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
            this.grdJson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdJson)).BeginInit();
            this.SuspendLayout();
            // 
            // grdJson
            // 
            this.grdJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJson.Location = new System.Drawing.Point(12, 26);
            this.grdJson.Name = "grdJson";
            this.grdJson.Size = new System.Drawing.Size(416, 150);
            this.grdJson.TabIndex = 0;
            // 
            // gridJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 186);
            this.Controls.Add(this.grdJson);
            this.Name = "gridJSON";
            this.Text = "gridJSON";
            this.Load += new System.EventHandler(this.gridJSON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdJson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdJson;
    }
}