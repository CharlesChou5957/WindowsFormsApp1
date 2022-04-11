
namespace WindowsFormsApp1._1.OverViews
{
    partial class Frm_Overview
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
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnected
            // 
            this.btnConnected.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnected.Location = new System.Drawing.Point(132, 113);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(118, 30);
            this.btnConnected.TabIndex = 0;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnected.Location = new System.Drawing.Point(497, 113);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(147, 30);
            this.btnDisconnected.TabIndex = 1;
            this.btnDisconnected.Text = "DisConnected";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            // 
            // Frm_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.btnConnected);
            this.Name = "Frm_Overview";
            this.Text = "Frm_Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
    }
}