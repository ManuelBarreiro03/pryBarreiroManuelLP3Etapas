namespace pryBarreiroManuelLP3Etapas
{
    partial class frmFirma
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
            pictureBox1 = new PictureBox();
            cmdGrabar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseMove;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(12, 220);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(88, 29);
            cmdGrabar.TabIndex = 1;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // frmFirma
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(cmdGrabar);
            Controls.Add(pictureBox1);
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdGrabar;

        #endregion
        
    }
}