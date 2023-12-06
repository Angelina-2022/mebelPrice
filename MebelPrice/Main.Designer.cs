namespace MebelPrice
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonRaschet = new System.Windows.Forms.Button();
            this.buttonInfoRazrabotchik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRaschet
            // 
            this.buttonRaschet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRaschet.Location = new System.Drawing.Point(177, 120);
            this.buttonRaschet.Name = "buttonRaschet";
            this.buttonRaschet.Size = new System.Drawing.Size(270, 63);
            this.buttonRaschet.TabIndex = 0;
            this.buttonRaschet.Text = "рассчет";
            this.buttonRaschet.UseVisualStyleBackColor = true;
            this.buttonRaschet.Click += new System.EventHandler(this.buttonRaschet_Click);
            // 
            // buttonInfoRazrabotchik
            // 
            this.buttonInfoRazrabotchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfoRazrabotchik.Location = new System.Drawing.Point(177, 203);
            this.buttonInfoRazrabotchik.Name = "buttonInfoRazrabotchik";
            this.buttonInfoRazrabotchik.Size = new System.Drawing.Size(270, 35);
            this.buttonInfoRazrabotchik.TabIndex = 5;
            this.buttonInfoRazrabotchik.Text = "о разработчике";
            this.buttonInfoRazrabotchik.UseVisualStyleBackColor = true;
            this.buttonInfoRazrabotchik.Click += new System.EventHandler(this.buttonInfoRazrabotchik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "v 1.0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInfoRazrabotchik);
            this.Controls.Add(this.buttonRaschet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MebelPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRaschet;
        private System.Windows.Forms.Button buttonInfoRazrabotchik;
        private System.Windows.Forms.Label label1;
    }
}