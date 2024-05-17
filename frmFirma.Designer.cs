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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 202);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 252);
            label1.Name = "label1";
            label1.Size = new Size(298, 40);
            label1.TabIndex = 2;
            label1.Text = "Abrir el archivo .zip del la carpeta resources\r\nahi esta el proyecto completo\r\n";
            // 
            // frmFirma
            // 
            ClientSize = new Size(323, 300);
            Controls.Add(label1);
            Controls.Add(cmdGrabar);
            Controls.Add(pictureBox1);
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdGrabar;

        #endregion

        private Label label1;
    }
}