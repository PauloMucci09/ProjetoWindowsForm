namespace WindowsForminc
{
    partial class Frminc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frminc));
            Logo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            txtpeso = new TextBox();
            txtaltura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 23);
            Logo.Name = "Logo";
            Logo.Size = new Size(87, 84);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 166);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Altura";
            // 
            // button3
            // 
            button3.Location = new Point(57, 284);
            button3.Name = "button3";
            button3.Size = new Size(117, 46);
            button3.TabIndex = 5;
            button3.Text = "Entrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btninc_Click;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(50, 163);
            txtpeso.Name = "txtpeso";
            txtpeso.PlaceholderText = "informe seu peso";
            txtpeso.Size = new Size(168, 23);
            txtpeso.TabIndex = 11;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(57, 221);
            txtaltura.Name = "txtaltura";
            txtaltura.PlaceholderText = "informe sua altura";
            txtaltura.Size = new Size(168, 23);
            txtaltura.TabIndex = 12;
            // 
            // Frminc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 373);
            Controls.Add(txtaltura);
            Controls.Add(txtpeso);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Logo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Frminc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INC";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox txtpeso;
        private TextBox txtaltura;
    }
}
