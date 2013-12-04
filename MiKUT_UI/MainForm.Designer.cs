namespace MiKUT_UI
{
    partial class MainForm
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
            this.bestTarrifButton = new System.Windows.Forms.Button();
            this.readBillingButton = new System.Windows.Forms.Button();
            this.tarrifsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bestTarrifButton
            // 
            this.bestTarrifButton.Location = new System.Drawing.Point(12, 12);
            this.bestTarrifButton.Name = "bestTarrifButton";
            this.bestTarrifButton.Size = new System.Drawing.Size(260, 74);
            this.bestTarrifButton.TabIndex = 0;
            this.bestTarrifButton.Text = "Znajdź najlepszą ofertę";
            this.bestTarrifButton.UseVisualStyleBackColor = true;
            this.bestTarrifButton.Click += new System.EventHandler(this.bestTarrifButton_Click);
            // 
            // readBillingButton
            // 
            this.readBillingButton.Location = new System.Drawing.Point(12, 92);
            this.readBillingButton.Name = "readBillingButton";
            this.readBillingButton.Size = new System.Drawing.Size(124, 40);
            this.readBillingButton.TabIndex = 1;
            this.readBillingButton.Text = "Wczytaj swój billing";
            this.readBillingButton.UseVisualStyleBackColor = true;
            this.readBillingButton.Click += new System.EventHandler(this.readBillingButton_Click);
            // 
            // tarrifsButton
            // 
            this.tarrifsButton.Location = new System.Drawing.Point(142, 92);
            this.tarrifsButton.Name = "tarrifsButton";
            this.tarrifsButton.Size = new System.Drawing.Size(130, 40);
            this.tarrifsButton.TabIndex = 2;
            this.tarrifsButton.Text = "Taryfy operatorów";
            this.tarrifsButton.UseVisualStyleBackColor = true;
            this.tarrifsButton.Click += new System.EventHandler(this.tarrifsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.tarrifsButton);
            this.Controls.Add(this.readBillingButton);
            this.Controls.Add(this.bestTarrifButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bestTarrifButton;
        private System.Windows.Forms.Button readBillingButton;
        private System.Windows.Forms.Button tarrifsButton;
    }
}

