namespace PruebaGit.gg
{
    partial class gg
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
            this.btnPress = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(348, 146);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(97, 23);
            this.btnPress.TabIndex = 0;
            this.btnPress.Text = "Presione el botón";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(370, 90);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(44, 13);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Prueba:";
            // 
            // gg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnPress);
            this.Name = "gg";
            this.Text = "gg";
            this.Load += new System.EventHandler(this.gg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Label lblTest;
    }
}