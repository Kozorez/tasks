namespace AC_Milan
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.forwardsButton = new System.Windows.Forms.Button();
            this.midfieldersButton = new System.Windows.Forms.Button();
            this.defendersButton = new System.Windows.Forms.Button();
            this.goalkeepersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forwardsButton
            // 
            this.forwardsButton.BackgroundImage = global::AC_Milan.Properties.Resources.forwards;
            this.forwardsButton.Location = new System.Drawing.Point(675, 345);
            this.forwardsButton.Name = "forwardsButton";
            this.forwardsButton.Size = new System.Drawing.Size(675, 344);
            this.forwardsButton.TabIndex = 3;
            this.forwardsButton.UseVisualStyleBackColor = true;
            this.forwardsButton.Click += new System.EventHandler(this.forwardsButton_Click);
            // 
            // midfieldersButton
            // 
            this.midfieldersButton.BackgroundImage = global::AC_Milan.Properties.Resources.midfielders;
            this.midfieldersButton.Location = new System.Drawing.Point(0, 345);
            this.midfieldersButton.Name = "midfieldersButton";
            this.midfieldersButton.Size = new System.Drawing.Size(675, 344);
            this.midfieldersButton.TabIndex = 2;
            this.midfieldersButton.UseVisualStyleBackColor = true;
            this.midfieldersButton.Click += new System.EventHandler(this.midfieldersButton_Click);
            // 
            // defendersButton
            // 
            this.defendersButton.BackgroundImage = global::AC_Milan.Properties.Resources.defenders;
            this.defendersButton.Location = new System.Drawing.Point(675, 0);
            this.defendersButton.Name = "defendersButton";
            this.defendersButton.Size = new System.Drawing.Size(675, 344);
            this.defendersButton.TabIndex = 1;
            this.defendersButton.UseVisualStyleBackColor = true;
            this.defendersButton.Click += new System.EventHandler(this.defendersButton_Click);
            // 
            // goalkeepersButton
            // 
            this.goalkeepersButton.BackgroundImage = global::AC_Milan.Properties.Resources.goalkeepers;
            this.goalkeepersButton.Location = new System.Drawing.Point(0, 0);
            this.goalkeepersButton.Name = "goalkeepersButton";
            this.goalkeepersButton.Size = new System.Drawing.Size(675, 344);
            this.goalkeepersButton.TabIndex = 0;
            this.goalkeepersButton.UseVisualStyleBackColor = true;
            this.goalkeepersButton.Click += new System.EventHandler(this.goalkeepersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 689);
            this.Controls.Add(this.forwardsButton);
            this.Controls.Add(this.midfieldersButton);
            this.Controls.Add(this.defendersButton);
            this.Controls.Add(this.goalkeepersButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AC Milan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goalkeepersButton;
        private System.Windows.Forms.Button defendersButton;
        private System.Windows.Forms.Button midfieldersButton;
        private System.Windows.Forms.Button forwardsButton;
    }
}

