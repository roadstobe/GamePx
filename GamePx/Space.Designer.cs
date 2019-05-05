namespace GamePx
{
    partial class Space
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
            this.components = new System.ComponentModel.Container();
            this.labelHead = new System.Windows.Forms.Label();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.labelEnemy2 = new System.Windows.Forms.Label();
            this.TimeEnemy = new System.Windows.Forms.Timer(this.components);
            this.labelTrap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHead.ForeColor = System.Drawing.Color.Red;
            this.labelHead.Location = new System.Drawing.Point(280, 155);
            this.labelHead.MaximumSize = new System.Drawing.Size(40, 40);
            this.labelHead.MinimumSize = new System.Drawing.Size(35, 25);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(35, 25);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Head";
            this.labelHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.Location = new System.Drawing.Point(0, 0);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(39, 13);
            this.labelEnemy.TabIndex = 1;
            this.labelEnemy.Text = "Enemy";
            // 
            // labelEnemy2
            // 
            this.labelEnemy2.AutoSize = true;
            this.labelEnemy2.Location = new System.Drawing.Point(950, 0);
            this.labelEnemy2.Name = "labelEnemy2";
            this.labelEnemy2.Size = new System.Drawing.Size(39, 13);
            this.labelEnemy2.TabIndex = 2;
            this.labelEnemy2.Text = "Enemy";
            // 
            // TimeEnemy
            // 
            this.TimeEnemy.Enabled = true;
            this.TimeEnemy.Tick += new System.EventHandler(this.Timer);
            // 
            // labelTrap
            // 
            this.labelTrap.AutoSize = true;
            this.labelTrap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrap.Location = new System.Drawing.Point(275, 90);
            this.labelTrap.MaximumSize = new System.Drawing.Size(40, 40);
            this.labelTrap.MinimumSize = new System.Drawing.Size(40, 40);
            this.labelTrap.Name = "labelTrap";
            this.labelTrap.Size = new System.Drawing.Size(40, 40);
            this.labelTrap.TabIndex = 3;
            this.labelTrap.Text = "Trap";
            this.labelTrap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Space
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 293);
            this.Controls.Add(this.labelTrap);
            this.Controls.Add(this.labelEnemy2);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.labelHead);
            this.MaximumSize = new System.Drawing.Size(1400, 1400);
            this.Name = "Space";
            this.Text = "Squere";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Label labelEnemy2;
        private System.Windows.Forms.Timer TimeEnemy;
        private System.Windows.Forms.Label labelTrap;
    }
}

