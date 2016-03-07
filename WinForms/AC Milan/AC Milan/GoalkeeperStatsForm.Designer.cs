namespace AC_Milan
{
    partial class GoalkeeperStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalkeeperStatsForm));
            this.playerstatssmallpictureButton = new System.Windows.Forms.Button();
            this.playerstatsfullnametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerstatssmallpictureButton
            // 
            this.playerstatssmallpictureButton.Location = new System.Drawing.Point(0, 0);
            this.playerstatssmallpictureButton.Name = "playerstatssmallpictureButton";
            this.playerstatssmallpictureButton.Size = new System.Drawing.Size(150, 200);
            this.playerstatssmallpictureButton.TabIndex = 0;
            this.playerstatssmallpictureButton.UseVisualStyleBackColor = true;
            this.playerstatssmallpictureButton.Click += new System.EventHandler(this.goalkeeper_Click);
            // 
            // playerstatsfullnametextBox
            // 
            this.playerstatsfullnametextBox.BackColor = System.Drawing.Color.White;
            this.playerstatsfullnametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerstatsfullnametextBox.Location = new System.Drawing.Point(0, 220);
            this.playerstatsfullnametextBox.Multiline = true;
            this.playerstatsfullnametextBox.Name = "playerstatsfullnametextBox";
            this.playerstatsfullnametextBox.ReadOnly = true;
            this.playerstatsfullnametextBox.Size = new System.Drawing.Size(150, 40);
            this.playerstatsfullnametextBox.TabIndex = 1;
            this.playerstatsfullnametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoalkeeperStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 689);
            this.Controls.Add(this.playerstatsfullnametextBox);
            this.Controls.Add(this.playerstatssmallpictureButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoalkeeperStatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button playerstatssmallpictureButton;
        public System.Windows.Forms.TextBox playerstatsfullnametextBox;

    }
}