namespace ICE3_Bug_Squishing_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spawnTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bug = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bug)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spawnTimer
            // 
            this.spawnTimer.Enabled = true;
            this.spawnTimer.Interval = 2000;
            this.spawnTimer.Tick += new System.EventHandler(this.spawnBug);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.scoreLabel.Location = new System.Drawing.Point(3, 11);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(367, 47);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Squished 0 Bugs";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bug
            // 
            this.bug.BackColor = System.Drawing.Color.Transparent;
            this.bug.Image = global::ICE3_Bug_Squishing_Game.Properties.Resources.bug1;
            this.bug.Location = new System.Drawing.Point(355, 157);
            this.bug.Name = "bug";
            this.bug.Size = new System.Drawing.Size(46, 43);
            this.bug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bug.TabIndex = 1;
            this.bug.TabStop = false;
            this.bug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.timeLabel.Location = new System.Drawing.Point(376, 11);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(426, 47);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time Left: XX";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 60);
            this.panel1.TabIndex = 4;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.RestartGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICE3_Bug_Squishing_Game.Properties.Resources.stone1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bug);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bug)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox bug;
        private System.Windows.Forms.Timer spawnTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button button1;
    }
}

