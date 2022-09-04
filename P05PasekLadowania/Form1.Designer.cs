namespace P05PasekLadowania
{
    partial class Form1
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
            this.btnStrat = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.pbPasekPostepu = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnStrat
            // 
            this.btnStrat.Location = new System.Drawing.Point(12, 11);
            this.btnStrat.Name = "btnStrat";
            this.btnStrat.Size = new System.Drawing.Size(75, 23);
            this.btnStrat.TabIndex = 0;
            this.btnStrat.Text = "Start";
            this.btnStrat.UseVisualStyleBackColor = true;
            this.btnStrat.Click += new System.EventHandler(this.btnStrat_Click);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 40);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(356, 290);
            this.lbDane.TabIndex = 1;
            // 
            // pbPasekPostepu
            // 
            this.pbPasekPostepu.Location = new System.Drawing.Point(12, 336);
            this.pbPasekPostepu.Name = "pbPasekPostepu";
            this.pbPasekPostepu.Size = new System.Drawing.Size(356, 23);
            this.pbPasekPostepu.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 367);
            this.Controls.Add(this.pbPasekPostepu);
            this.Controls.Add(this.lbDane);
            this.Controls.Add(this.btnStrat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStrat;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.ProgressBar pbPasekPostepu;
    }
}

