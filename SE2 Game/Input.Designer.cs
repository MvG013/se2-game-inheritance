namespace SE2_Game
{
    partial class Input
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
            this.LblVraag = new System.Windows.Forms.Label();
            this.TbAantal = new System.Windows.Forms.TextBox();
            this.BtnOke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblVraag
            // 
            this.LblVraag.Location = new System.Drawing.Point(55, 5);
            this.LblVraag.Name = "LblVraag";
            this.LblVraag.Size = new System.Drawing.Size(79, 16);
            this.LblVraag.TabIndex = 3;
            this.LblVraag.Text = "Aantal enemies";
            // 
            // TbAantal
            // 
            this.TbAantal.Location = new System.Drawing.Point(12, 24);
            this.TbAantal.Name = "TbAantal";
            this.TbAantal.Size = new System.Drawing.Size(166, 20);
            this.TbAantal.TabIndex = 6;
            // 
            // BtnOke
            // 
            this.BtnOke.Location = new System.Drawing.Point(59, 51);
            this.BtnOke.Name = "BtnOke";
            this.BtnOke.Size = new System.Drawing.Size(75, 23);
            this.BtnOke.TabIndex = 4;
            this.BtnOke.Text = "Oke";
            this.BtnOke.UseVisualStyleBackColor = true;
            this.BtnOke.Click += new System.EventHandler(this.BtnOke_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 86);
            this.Controls.Add(this.LblVraag);
            this.Controls.Add(this.TbAantal);
            this.Controls.Add(this.BtnOke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Input";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVraag;
        private System.Windows.Forms.TextBox TbAantal;
        private System.Windows.Forms.Button BtnOke;
    }
}