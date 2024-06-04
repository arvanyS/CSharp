namespace playtime
{
    partial class Playtime
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
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.finishLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.istartedButton = new System.Windows.Forms.Button();
            this.ifinishedButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerText = new System.Windows.Forms.TextBox();
            this.timerBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addGameText = new System.Windows.Forms.TextBox();
            this.yourGamesBox = new System.Windows.Forms.GroupBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.gamesCombo = new System.Windows.Forms.ComboBox();
            this.addGameBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.gamePathText = new System.Windows.Forms.TextBox();
            this.gamePAth = new System.Windows.Forms.OpenFileDialog();
            this.themeButton = new System.Windows.Forms.Button();
            this.darkButton = new System.Windows.Forms.Button();
            
            this.statusBox.SuspendLayout();
            this.timerBox.SuspendLayout();
            this.yourGamesBox.SuspendLayout();
            this.addGameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.Transparent;
            this.statusBox.Controls.Add(this.finishLabel);
            this.statusBox.Controls.Add(this.startLabel);
            this.statusBox.Controls.Add(this.istartedButton);
            this.statusBox.Controls.Add(this.ifinishedButton);
            this.statusBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.ForeColor = System.Drawing.Color.White;
            this.statusBox.Location = new System.Drawing.Point(709, 47);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(530, 176);
            this.statusBox.TabIndex = 2;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "STATUS";
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Location = new System.Drawing.Point(331, 48);
            this.finishLabel.MaximumSize = new System.Drawing.Size(150, 24);
            this.finishLabel.MinimumSize = new System.Drawing.Size(150, 24);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(150, 24);
            this.finishLabel.TabIndex = 3;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(72, 48);
            this.startLabel.MaximumSize = new System.Drawing.Size(150, 24);
            this.startLabel.MinimumSize = new System.Drawing.Size(150, 24);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(150, 24);
            this.startLabel.TabIndex = 2;
            // 
            // istartedButton
            // 
            this.istartedButton.BackColor = System.Drawing.Color.ForestGreen;
            this.istartedButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.istartedButton.ForeColor = System.Drawing.Color.White;
            this.istartedButton.Location = new System.Drawing.Point(76, 75);
            this.istartedButton.Name = "istartedButton";
            this.istartedButton.Size = new System.Drawing.Size(140, 50);
            this.istartedButton.TabIndex = 0;
            this.istartedButton.Text = "I STARTED";
            this.istartedButton.UseVisualStyleBackColor = false;
            this.istartedButton.Click += new System.EventHandler(this.istartedButton_Click);
            // 
            // ifinishedButton
            // 
            this.ifinishedButton.BackColor = System.Drawing.Color.Brown;
            this.ifinishedButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifinishedButton.ForeColor = System.Drawing.Color.White;
            this.ifinishedButton.Location = new System.Drawing.Point(335, 75);
            this.ifinishedButton.Name = "ifinishedButton";
            this.ifinishedButton.Size = new System.Drawing.Size(140, 50);
            this.ifinishedButton.TabIndex = 1;
            this.ifinishedButton.Text = "I FINISHED";
            this.ifinishedButton.UseVisualStyleBackColor = false;
            this.ifinishedButton.Click += new System.EventHandler(this.ifinishedButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerText
            // 
            this.timerText.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerText.Location = new System.Drawing.Point(184, 51);
            this.timerText.Name = "timerText";
            this.timerText.ReadOnly = true;
            this.timerText.Size = new System.Drawing.Size(175, 40);
            this.timerText.TabIndex = 2;
            this.timerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerBox
            // 
            this.timerBox.BackColor = System.Drawing.Color.Transparent;
            this.timerBox.Controls.Add(this.resetButton);
            this.timerBox.Controls.Add(this.saveButton);
            this.timerBox.Controls.Add(this.startButton);
            this.timerBox.Controls.Add(this.timerText);
            this.timerBox.Controls.Add(this.stopButton);
            this.timerBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.ForeColor = System.Drawing.Color.White;
            this.timerBox.Location = new System.Drawing.Point(709, 259);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(530, 232);
            this.timerBox.TabIndex = 3;
            this.timerBox.TabStop = false;
            this.timerBox.Text = "TIMER";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Khaki;
            this.resetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(37, 131);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(136, 41);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(378, 131);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 41);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.ForestGreen;
            this.startButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(205, 131);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 40);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(205, 131);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(136, 40);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.LightGray;
            this.loadButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Location = new System.Drawing.Point(50, 113);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(223, 50);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "SHOW INFO";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightGray;
            this.addButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(229, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(209, 40);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addGameText
            // 
            this.addGameText.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameText.Location = new System.Drawing.Point(26, 68);
            this.addGameText.Name = "addGameText";
            this.addGameText.Size = new System.Drawing.Size(554, 40);
            this.addGameText.TabIndex = 5;
            this.addGameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yourGamesBox
            // 
            this.yourGamesBox.BackColor = System.Drawing.Color.Transparent;
            this.yourGamesBox.Controls.Add(this.launchButton);
            this.yourGamesBox.Controls.Add(this.gamesCombo);
            this.yourGamesBox.Controls.Add(this.loadButton);
            this.yourGamesBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourGamesBox.ForeColor = System.Drawing.Color.White;
            this.yourGamesBox.Location = new System.Drawing.Point(37, 368);
            this.yourGamesBox.Name = "yourGamesBox";
            this.yourGamesBox.Size = new System.Drawing.Size(615, 191);
            this.yourGamesBox.TabIndex = 6;
            this.yourGamesBox.TabStop = false;
            this.yourGamesBox.Text = "YOUR GAMES";
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.LightGray;
            this.launchButton.Enabled = false;
            this.launchButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.Color.Black;
            this.launchButton.Location = new System.Drawing.Point(363, 113);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(189, 50);
            this.launchButton.TabIndex = 3;
            this.launchButton.Text = "LAUNCH";
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // gamesCombo
            // 
            this.gamesCombo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesCombo.FormattingEnabled = true;
            this.gamesCombo.Location = new System.Drawing.Point(50, 43);
            this.gamesCombo.Name = "gamesCombo";
            this.gamesCombo.Size = new System.Drawing.Size(502, 41);
            this.gamesCombo.TabIndex = 0;
            this.gamesCombo.SelectedIndexChanged += new System.EventHandler(this.gamesCombo_SelectedIndexChanged);
            // 
            // addGameBox
            // 
            this.addGameBox.BackColor = System.Drawing.Color.Transparent;
            this.addGameBox.Controls.Add(this.label2);
            this.addGameBox.Controls.Add(this.label1);
            this.addGameBox.Controls.Add(this.browseButton);
            this.addGameBox.Controls.Add(this.gamePathText);
            this.addGameBox.Controls.Add(this.addGameText);
            this.addGameBox.Controls.Add(this.addButton);
            this.addGameBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameBox.ForeColor = System.Drawing.Color.White;
            this.addGameBox.Location = new System.Drawing.Point(37, 47);
            this.addGameBox.Name = "addGameBox";
            this.addGameBox.Size = new System.Drawing.Size(615, 293);
            this.addGameBox.TabIndex = 7;
            this.addGameBox.TabStop = false;
            this.addGameBox.Text = "ADD A GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.MaximumSize = new System.Drawing.Size(150, 24);
            this.label2.MinimumSize = new System.Drawing.Size(150, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "GAME PATH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.MaximumSize = new System.Drawing.Size(150, 24);
            this.label1.MinimumSize = new System.Drawing.Size(150, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "GAME NAME";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.LightGray;
            this.browseButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(414, 158);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(165, 40);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "BROWSE";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gamePathText
            // 
            this.gamePathText.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePathText.Location = new System.Drawing.Point(25, 158);
            this.gamePathText.Name = "gamePathText";
            this.gamePathText.Size = new System.Drawing.Size(375, 40);
            this.gamePathText.TabIndex = 6;
            this.gamePathText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gamePAth
            // 
            this.gamePAth.FileName = "openFileDialog1";
            // 
            // themeButton
            // 
            this.themeButton.BackColor = System.Drawing.Color.LightGray;
            this.themeButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.themeButton.Location = new System.Drawing.Point(1166, 556);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(73, 30);
            this.themeButton.TabIndex = 9;
            this.themeButton.Text = "LIGHT";
            this.themeButton.UseVisualStyleBackColor = false;
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click_1);
            // 
            // darkButton
            // 
            this.darkButton.BackColor = System.Drawing.Color.LightGray;
            this.darkButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.darkButton.Location = new System.Drawing.Point(1166, 556);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(73, 30);
            this.darkButton.TabIndex = 10;
            this.darkButton.Text = "DARK";
            this.darkButton.UseVisualStyleBackColor = false;
            this.darkButton.Visible = false;
            this.darkButton.Click += new System.EventHandler(this.darkButton_Click_1);
            
            // 
            // Playtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1261, 605);
            
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.themeButton);
            this.Controls.Add(this.addGameBox);
            this.Controls.Add(this.yourGamesBox);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.statusBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Playtime";
            this.Text = "Playtime";
            this.Load += new System.EventHandler(this.Playtime_Load);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.timerBox.ResumeLayout(false);
            this.timerBox.PerformLayout();
            this.yourGamesBox.ResumeLayout(false);
            this.addGameBox.ResumeLayout(false);
            this.addGameBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Button ifinishedButton;
        private System.Windows.Forms.Button istartedButton;
        private System.Windows.Forms.TextBox timerText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox timerBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addGameText;
        private System.Windows.Forms.GroupBox yourGamesBox;
        private System.Windows.Forms.ComboBox gamesCombo;
        private System.Windows.Forms.GroupBox addGameBox;
        private System.Windows.Forms.Label finishLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.OpenFileDialog gamePAth;
        private System.Windows.Forms.TextBox gamePathText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Button themeButton;
        private System.Windows.Forms.Button darkButton;
        
    }
}

