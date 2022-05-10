namespace CountDownTimer
{
    partial class CountDownTimer
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
            this.topLabel = new System.Windows.Forms.Label();
            this.minutLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(193, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(394, 70);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Count Down Timer";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutLabel
            // 
            this.minutLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutLabel.Location = new System.Drawing.Point(209, 93);
            this.minutLabel.Name = "minutLabel";
            this.minutLabel.Size = new System.Drawing.Size(394, 70);
            this.minutLabel.TabIndex = 0;
            this.minutLabel.Text = "60 Seconds";
            this.minutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Gray;
            this.resetButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(258, 229);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(130, 53);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset ";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gray;
            this.startButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(258, 307);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(271, 56);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Gray;
            this.stopButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopButton.Location = new System.Drawing.Point(399, 229);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(130, 53);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.Gray;
            this.MinusButton.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinusButton.Location = new System.Drawing.Point(399, 375);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(129, 63);
            this.MinusButton.TabIndex = 2;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.Gray;
            this.PlusButton.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlusButton.Location = new System.Drawing.Point(258, 375);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(130, 63);
            this.PlusButton.TabIndex = 2;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // CountDownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.minutLabel);
            this.Controls.Add(this.topLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CountDownTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count Down Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label minutLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
    }
}

