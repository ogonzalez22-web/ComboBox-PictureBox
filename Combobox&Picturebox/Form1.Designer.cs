namespace ComboBox_PictureBox
{
    partial class Form1
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
            LBdescripcion = new Label();
            piclogo = new PictureBox();
            combodistro = new ComboBox();
            linkdescarga = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // LBdescripcion
            // 
            LBdescripcion.AutoSize = true;
            LBdescripcion.Location = new Point(414, 76);
            LBdescripcion.Name = "LBdescripcion";
            LBdescripcion.Size = new Size(38, 15);
            LBdescripcion.TabIndex = 0;
            LBdescripcion.Text = "label1";
            LBdescripcion.Click += label1_Click;
            // 
            // piclogo
            // 
            piclogo.Location = new Point(12, 62);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(373, 372);
            piclogo.TabIndex = 1;
            piclogo.TabStop = false;
            // 
            // combodistro
            // 
            combodistro.FormattingEnabled = true;
            combodistro.Location = new Point(12, 23);
            combodistro.Name = "combodistro";
            combodistro.Size = new Size(787, 23);
            combodistro.TabIndex = 2;
            combodistro.SelectedIndexChanged += combodistro_SelectedIndexChanged;
            // 
            // linkdescarga
            // 
            linkdescarga.AutoSize = true;
            linkdescarga.Location = new Point(369, 500);
            linkdescarga.Name = "linkdescarga";
            linkdescarga.Size = new Size(60, 15);
            linkdescarga.TabIndex = 3;
            linkdescarga.TabStop = true;
            linkdescarga.Text = "linkLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 564);
            Controls.Add(linkdescarga);
            Controls.Add(combodistro);
            Controls.Add(piclogo);
            Controls.Add(LBdescripcion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBdescripcion;
        private PictureBox piclogo;
        private ComboBox combodistro;
        private LinkLabel linkdescarga;
    }
}
