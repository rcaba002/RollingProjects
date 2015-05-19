namespace ButtonPosition
{
    partial class EndOfGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeList = new System.Windows.Forms.ListBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeList
            // 
            this.timeList.FormattingEnabled = true;
            this.timeList.ItemHeight = 31;
            this.timeList.Location = new System.Drawing.Point(43, 61);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(341, 438);
            this.timeList.TabIndex = 3;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(75, 529);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(247, 97);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // EndOfGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeList);
            this.Controls.Add(this.restartButton);
            this.Name = "EndOfGame";
            this.Size = new System.Drawing.Size(427, 664);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox timeList;
        private System.Windows.Forms.Button restartButton;
    }
}
