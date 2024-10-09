namespace pogoda3
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
            lblTemperatura = new Label();
            lblWilgotnosc = new Label();
            lblOpady = new Label();
            lblAktualizacja = new Label();
            SuspendLayout();
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(58, 76);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(72, 15);
            lblTemperatura.TabIndex = 0;
            lblTemperatura.Text = "temperatura";
            // 
            // lblWilgotnosc
            // 
            lblWilgotnosc.AutoSize = true;
            lblWilgotnosc.Location = new Point(170, 76);
            lblWilgotnosc.Name = "lblWilgotnosc";
            lblWilgotnosc.Size = new Size(67, 15);
            lblWilgotnosc.TabIndex = 1;
            lblWilgotnosc.Text = "Wilgotnosc";
            // 
            // lblOpady
            // 
            lblOpady.AutoSize = true;
            lblOpady.Location = new Point(315, 76);
            lblOpady.Name = "lblOpady";
            lblOpady.Size = new Size(42, 15);
            lblOpady.TabIndex = 2;
            lblOpady.Text = "Opady";
            // 
            // lblAktualizacja
            // 
            lblAktualizacja.AutoSize = true;
            lblAktualizacja.Location = new Point(545, 76);
            lblAktualizacja.Name = "lblAktualizacja";
            lblAktualizacja.Size = new Size(117, 15);
            lblAktualizacja.TabIndex = 3;
            lblAktualizacja.Text = "Ostatnia Aktualizacja";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAktualizacja);
            Controls.Add(lblOpady);
            Controls.Add(lblWilgotnosc);
            Controls.Add(lblTemperatura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemperatura;
        private Label lblWilgotnosc;
        private Label lblOpady;
        private Label lblAktualizacja;
    }
}
