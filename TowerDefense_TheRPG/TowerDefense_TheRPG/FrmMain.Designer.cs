namespace TowerDefense_TheRPG
{
    partial class FrmMain : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStoryLine = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTextCrawl = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnEnemies = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveEnemies = new System.Windows.Forms.Timer(this.components);
            this.btnStoryLine = new System.Windows.Forms.Button();
            this.tmrMoveArrows = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnArrows = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnPowerUp = new System.Windows.Forms.Timer(this.components);
            this.tmrMovePlayer = new System.Windows.Forms.Timer(this.components);
            this.tmrFiredArrow = new System.Windows.Forms.Timer(this.components);
            this.tmrFiringArrows = new System.Windows.Forms.Timer(this.components);
            this.lblGameTime = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblCountTime = new System.Windows.Forms.Label();
            this.lblCountKills = new System.Windows.Forms.Label();
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblStoryLine
            // 
            this.lblStoryLine.BackColor = System.Drawing.Color.Transparent;
            this.lblStoryLine.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStoryLine.ForeColor = System.Drawing.Color.White;
            this.lblStoryLine.Location = new System.Drawing.Point(14, 12);
            this.lblStoryLine.Name = "lblStoryLine";
            this.lblStoryLine.Size = new System.Drawing.Size(1286, 825);
            this.lblStoryLine.TabIndex = 0;
            this.lblStoryLine.Click += new System.EventHandler(this.lblStoryLine_Click);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(363, 736);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(251, 93);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTextCrawl
            // 
            this.tmrTextCrawl.Interval = 20;
            this.tmrTextCrawl.Tick += new System.EventHandler(this.tmrTextCrawl_Tick);
            // 
            // tmrSpawnEnemies
            // 
            this.tmrSpawnEnemies.Interval = 5000;
            this.tmrSpawnEnemies.Tick += new System.EventHandler(this.tmrSpawnEnemies_Tick);
            // 
            // tmrMoveEnemies
            // 
            this.tmrMoveEnemies.Tick += new System.EventHandler(this.tmrMoveEnemies_Tick);
            // 
            // btnStoryLine
            // 
            this.btnStoryLine.AutoSize = true;
            this.btnStoryLine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoryLine.Location = new System.Drawing.Point(723, 736);
            this.btnStoryLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStoryLine.Name = "btnStoryLine";
            this.btnStoryLine.Size = new System.Drawing.Size(251, 93);
            this.btnStoryLine.TabIndex = 3;
            this.btnStoryLine.Text = "Show Storyline";
            this.btnStoryLine.UseVisualStyleBackColor = true;
            this.btnStoryLine.Click += new System.EventHandler(this.btnStoryLine_Click);
            // 
            // tmrMoveArrows
            // 
            this.tmrMoveArrows.Interval = 20;
            this.tmrMoveArrows.Tick += new System.EventHandler(this.tmrMoveArrows_Tick);
            // 
            // tmrSpawnArrows
            // 
            this.tmrSpawnArrows.Interval = 5000;
            this.tmrSpawnArrows.Tick += new System.EventHandler(this.tmrSpawnArrows_Tick);
            // 
            // tmrSpawnPowerUp
            // 
            this.tmrSpawnPowerUp.Interval = 45000;
            this.tmrSpawnPowerUp.Tick += new System.EventHandler(this.tmrSpawnPowerUp_Tick);
            // 
            // tmrMovePlayer
            // 
            this.tmrMovePlayer.Enabled = true;
            this.tmrMovePlayer.Interval = 17;
            this.tmrMovePlayer.Tick += new System.EventHandler(this.tmrMovePlayer_Tick);
            // 
            // tmrFiredArrow
            // 
            this.tmrFiredArrow.Interval = 1000;
            this.tmrFiredArrow.Tick += new System.EventHandler(this.FiredArrow_Tick);
            // 
            // tmrFiringArrows
            // 
            this.tmrFiringArrows.Interval = 1000;
            this.tmrFiringArrows.Tick += new System.EventHandler(this.tmrFiringArrows_Tick);
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTime.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameTime.ForeColor = System.Drawing.Color.White;
            this.lblGameTime.Location = new System.Drawing.Point(1123, 39);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(105, 45);
            this.lblGameTime.TabIndex = 4;
            this.lblGameTime.Text = "Time:";
            this.lblGameTime.Visible = false;
            this.lblGameTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.BackColor = System.Drawing.Color.Transparent;
            this.lblKills.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKills.ForeColor = System.Drawing.Color.White;
            this.lblKills.Location = new System.Drawing.Point(1123, 85);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(101, 45);
            this.lblKills.TabIndex = 5;
            this.lblKills.Text = "Kills: ";
            this.lblKills.Visible = false;
            // 
            // lblCountTime
            // 
            this.lblCountTime.AutoSize = true;
            this.lblCountTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCountTime.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountTime.ForeColor = System.Drawing.Color.Red;
            this.lblCountTime.Location = new System.Drawing.Point(1219, 40);
            this.lblCountTime.Name = "lblCountTime";
            this.lblCountTime.Size = new System.Drawing.Size(39, 45);
            this.lblCountTime.TabIndex = 6;
            this.lblCountTime.Text = "0";
            this.lblCountTime.Visible = false;
            // 
            // lblCountKills
            // 
            this.lblCountKills.AutoSize = true;
            this.lblCountKills.BackColor = System.Drawing.Color.Transparent;
            this.lblCountKills.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountKills.ForeColor = System.Drawing.Color.Gold;
            this.lblCountKills.Location = new System.Drawing.Point(1219, 84);
            this.lblCountKills.Name = "lblCountKills";
            this.lblCountKills.Size = new System.Drawing.Size(39, 45);
            this.lblCountKills.TabIndex = 7;
            this.lblCountKills.Text = "0";
            this.lblCountKills.Visible = false;
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Interval = 1000;
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 

            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 845);
            this.Controls.Add(this.lblCountKills);
            this.Controls.Add(this.lblCountTime);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblGameTime);
            this.Controls.Add(this.btnStoryLine);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStoryLine);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower Defense The RPG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStoryLine;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrTextCrawl;
        private System.Windows.Forms.Timer tmrSpawnEnemies;
        private System.Windows.Forms.Timer tmrMoveEnemies;
        private Button btnStoryLine;
        private System.Windows.Forms.Timer tmrMoveArrows;
        private System.Windows.Forms.Timer tmrSpawnArrows;
        private System.Windows.Forms.Timer tmrSpawnPowerUp;
        private System.Windows.Forms.Timer tmrMovePlayer;
        private System.Windows.Forms.Timer tmrFiredArrow;
        private System.Windows.Forms.Timer tmrFiringArrows;
        private Label lblGameTime;
        private Label lblKills;
        private Label lblCountTime;
        private Label lblCountKills;
        private System.Windows.Forms.Timer tmrGameTime;
    }
}