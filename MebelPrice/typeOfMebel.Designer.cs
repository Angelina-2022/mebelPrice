namespace MebelPrice
{
    partial class typeOfMebel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(typeOfMebel));
            this.button_kitchen = new System.Windows.Forms.Button();
            this.button_closet = new System.Windows.Forms.Button();
            this.button_table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_kitchen
            // 
            this.button_kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_kitchen.Location = new System.Drawing.Point(159, 98);
            this.button_kitchen.Name = "button_kitchen";
            this.button_kitchen.Size = new System.Drawing.Size(333, 59);
            this.button_kitchen.TabIndex = 0;
            this.button_kitchen.Text = "кухня";
            this.button_kitchen.UseVisualStyleBackColor = true;
            this.button_kitchen.Click += new System.EventHandler(this.buttonClick_kitchen);
            // 
            // button_closet
            // 
            this.button_closet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_closet.Location = new System.Drawing.Point(159, 174);
            this.button_closet.Name = "button_closet";
            this.button_closet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_closet.Size = new System.Drawing.Size(333, 59);
            this.button_closet.TabIndex = 1;
            this.button_closet.Text = "шкаф";
            this.button_closet.UseVisualStyleBackColor = true;
            this.button_closet.Click += new System.EventHandler(this.buttonClick_shkaf);
            // 
            // button_table
            // 
            this.button_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_table.Location = new System.Drawing.Point(159, 252);
            this.button_table.Name = "button_table";
            this.button_table.Size = new System.Drawing.Size(333, 59);
            this.button_table.TabIndex = 2;
            this.button_table.Text = "стол";
            this.button_table.UseVisualStyleBackColor = true;
            this.button_table.Click += new System.EventHandler(this.buttonClick_stol);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(236, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "выберите вид мебели:";
            // 
            // typeOfMebel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(652, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_table);
            this.Controls.Add(this.button_closet);
            this.Controls.Add(this.button_kitchen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "typeOfMebel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "вид мебели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kitchen;
        private System.Windows.Forms.Button button_closet;
        private System.Windows.Forms.Button button_table;
        private System.Windows.Forms.Label label1;
    }
}