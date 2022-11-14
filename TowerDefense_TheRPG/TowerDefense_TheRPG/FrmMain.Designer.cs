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
            this.tmrCheckPowerUpsCollected = new System.Windows.Forms.Timer(this.components);
            this.tmrPowerUpsDeactivate = new System.Windows.Forms.Timer(this.components);
            this.lblSpeedActivated = new System.Windows.Forms.Label();
            this.lblStrengthActivated = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblCountMoney = new System.Windows.Forms.Label();
            this.townHeal = new System.Windows.Forms.Button();
            this.playerHeal = new System.Windows.Forms.Button();
            this.shopLabel = new System.Windows.Forms.Label();
            this.playerHealCost = new System.Windows.Forms.Label();
            this.villageHealCost = new System.Windows.Forms.Label();
            this.arrowIncCost = new System.Windows.Forms.Label();
            this.arrowInc = new System.Windows.Forms.Button();
            this.arrowIncOmni = new System.Windows.Forms.Button();
            this.arrowIncOmniCost = new System.Windows.Forms.Label();
            this.EndlessMode = new System.Windows.Forms.Label();
            this.tmrEndlessTextHide = new System.Windows.Forms.Timer(this.components);
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblLevelValue = new System.Windows.Forms.Label();
            this.tmrPowerUpDecay = new System.Windows.Forms.Timer(this.components);
            this.btnTutorial = new System.Windows.Forms.Button();
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
            this.btnStart.Location = new System.Drawing.Point(538, 736);
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
            this.tmrSpawnEnemies.Interval = 15000;
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
            this.btnStoryLine.Location = new System.Drawing.Point(53, 736);
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
            this.tmrSpawnPowerUp.Interval = 10000;
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
            this.lblGameTime.Location = new System.Drawing.Point(1112, 40);
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
            this.lblKills.Location = new System.Drawing.Point(1123, 84);
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
            // tmrCheckPowerUpsCollected
            // 
            this.tmrCheckPowerUpsCollected.Tick += new System.EventHandler(this.tmrCheckPowerUpsCollected_Tick);
            // 
            // tmrPowerUpsDeactivate
            // 
            this.tmrPowerUpsDeactivate.Interval = 10000;
            this.tmrPowerUpsDeactivate.Tick += new System.EventHandler(this.tmrPowerUpsDeactivate_Tick);
            // 
            // lblSpeedActivated
            // 
            this.lblSpeedActivated.AutoSize = true;
            this.lblSpeedActivated.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeedActivated.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeedActivated.ForeColor = System.Drawing.Color.Blue;
            this.lblSpeedActivated.Location = new System.Drawing.Point(523, 12);
            this.lblSpeedActivated.Name = "lblSpeedActivated";
            this.lblSpeedActivated.Size = new System.Drawing.Size(278, 45);
            this.lblSpeedActivated.TabIndex = 10;
            this.lblSpeedActivated.Text = "2x Speed Active!";
            this.lblSpeedActivated.Visible = false;
            // 
            // lblStrengthActivated
            // 
            this.lblStrengthActivated.AutoSize = true;
            this.lblStrengthActivated.BackColor = System.Drawing.Color.Transparent;
            this.lblStrengthActivated.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStrengthActivated.ForeColor = System.Drawing.Color.Blue;
            this.lblStrengthActivated.Location = new System.Drawing.Point(514, 19);
            this.lblStrengthActivated.Name = "lblStrengthActivated";
            this.lblStrengthActivated.Size = new System.Drawing.Size(361, 45);
            this.lblStrengthActivated.TabIndex = 11;
            this.lblStrengthActivated.Text = "Extra Strength Active!";
            this.lblStrengthActivated.Visible = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(1167, 133);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(48, 45);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "$:";
            this.lblMoney.Visible = false;
            this.lblMoney.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblCountMoney
            // 
            this.lblCountMoney.AutoSize = true;
            this.lblCountMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblCountMoney.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountMoney.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCountMoney.Location = new System.Drawing.Point(1219, 133);
            this.lblCountMoney.Name = "lblCountMoney";
            this.lblCountMoney.Size = new System.Drawing.Size(39, 45);
            this.lblCountMoney.TabIndex = 13;
            this.lblCountMoney.Text = "0";
            this.lblCountMoney.Visible = false;
            // 
            // townHeal
            // 
            this.townHeal.Image = global::TowerDefense_TheRPG.Properties.Resources.heal_town_image;
            this.townHeal.Location = new System.Drawing.Point(101, 323);
            this.townHeal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.townHeal.Name = "townHeal";
            this.townHeal.Size = new System.Drawing.Size(79, 92);
            this.townHeal.TabIndex = 14;
            this.townHeal.TabStop = false;
            this.townHeal.UseVisualStyleBackColor = true;
            this.townHeal.Visible = false;
            this.townHeal.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerHeal
            // 
            this.playerHeal.Image = global::TowerDefense_TheRPG.Properties.Resources.heal_player_image;
            this.playerHeal.Location = new System.Drawing.Point(101, 423);
            this.playerHeal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerHeal.Name = "playerHeal";
            this.playerHeal.Size = new System.Drawing.Size(79, 92);
            this.playerHeal.TabIndex = 15;
            this.playerHeal.TabStop = false;
            this.playerHeal.UseVisualStyleBackColor = true;
            this.playerHeal.Visible = false;
            this.playerHeal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.BackColor = System.Drawing.Color.Transparent;
            this.shopLabel.Font = new System.Drawing.Font("Segoe UI", 24.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shopLabel.Location = new System.Drawing.Point(27, 257);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(137, 57);
            this.shopLabel.TabIndex = 16;
            this.shopLabel.Text = "Shop:";
            this.shopLabel.Visible = false;
            // 
            // playerHealCost
            // 
            this.playerHealCost.AutoSize = true;
            this.playerHealCost.BackColor = System.Drawing.Color.Transparent;
            this.playerHealCost.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerHealCost.ForeColor = System.Drawing.Color.DarkGreen;
            this.playerHealCost.Location = new System.Drawing.Point(9, 436);
            this.playerHealCost.Name = "playerHealCost";
            this.playerHealCost.Size = new System.Drawing.Size(67, 45);
            this.playerHealCost.TabIndex = 17;
            this.playerHealCost.Text = "$2:";
            this.playerHealCost.Visible = false;
            this.playerHealCost.Click += new System.EventHandler(this.label2_Click);
            // 
            // villageHealCost
            // 
            this.villageHealCost.AutoSize = true;
            this.villageHealCost.BackColor = System.Drawing.Color.Transparent;
            this.villageHealCost.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.villageHealCost.ForeColor = System.Drawing.Color.DarkGreen;
            this.villageHealCost.Location = new System.Drawing.Point(9, 336);
            this.villageHealCost.Name = "villageHealCost";
            this.villageHealCost.Size = new System.Drawing.Size(67, 45);
            this.villageHealCost.TabIndex = 18;
            this.villageHealCost.Text = "$3:";
            this.villageHealCost.Visible = false;
            this.villageHealCost.Click += new System.EventHandler(this.label3_Click);
            // 
            // arrowIncCost
            // 
            this.arrowIncCost.AutoSize = true;
            this.arrowIncCost.BackColor = System.Drawing.Color.Transparent;
            this.arrowIncCost.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrowIncCost.ForeColor = System.Drawing.Color.DarkGreen;
            this.arrowIncCost.Location = new System.Drawing.Point(9, 531);
            this.arrowIncCost.Name = "arrowIncCost";
            this.arrowIncCost.Size = new System.Drawing.Size(67, 45);
            this.arrowIncCost.TabIndex = 19;
            this.arrowIncCost.Text = "$8:";
            this.arrowIncCost.Visible = false;
            this.arrowIncCost.Click += new System.EventHandler(this.arrowIncCost_Click);
            // 
            // arrowInc
            // 
            this.arrowInc.Image = global::TowerDefense_TheRPG.Properties.Resources.vertical_arrows;
            this.arrowInc.Location = new System.Drawing.Point(101, 523);
            this.arrowInc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arrowInc.Name = "arrowInc";
            this.arrowInc.Size = new System.Drawing.Size(79, 92);
            this.arrowInc.TabIndex = 20;
            this.arrowInc.TabStop = false;
            this.arrowInc.UseVisualStyleBackColor = true;
            this.arrowInc.Visible = false;
            this.arrowInc.Click += new System.EventHandler(this.arrowInc_Click);
            // 
            // arrowIncOmni
            // 
            this.arrowIncOmni.Image = global::TowerDefense_TheRPG.Properties.Resources.omnidir_arrows;
            this.arrowIncOmni.Location = new System.Drawing.Point(101, 523);
            this.arrowIncOmni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arrowIncOmni.Name = "arrowIncOmni";
            this.arrowIncOmni.Size = new System.Drawing.Size(79, 92);
            this.arrowIncOmni.TabIndex = 21;
            this.arrowIncOmni.TabStop = false;
            this.arrowIncOmni.UseVisualStyleBackColor = true;
            this.arrowIncOmni.Visible = false;
            this.arrowIncOmni.Click += new System.EventHandler(this.arrowIncOmni_Click);
            // 
            // arrowIncOmniCost
            // 
            this.arrowIncOmniCost.AutoSize = true;
            this.arrowIncOmniCost.BackColor = System.Drawing.Color.Transparent;
            this.arrowIncOmniCost.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrowIncOmniCost.ForeColor = System.Drawing.Color.DarkGreen;
            this.arrowIncOmniCost.Location = new System.Drawing.Point(14, 536);
            this.arrowIncOmniCost.Name = "arrowIncOmniCost";
            this.arrowIncOmniCost.Size = new System.Drawing.Size(86, 45);
            this.arrowIncOmniCost.TabIndex = 22;
            this.arrowIncOmniCost.Text = "$15:";
            this.arrowIncOmniCost.Visible = false;
            // 
            // EndlessMode
            // 
            this.EndlessMode.AutoSize = true;
            this.EndlessMode.BackColor = System.Drawing.Color.Transparent;
            this.EndlessMode.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndlessMode.ForeColor = System.Drawing.Color.Blue;
            this.EndlessMode.Location = new System.Drawing.Point(435, 96);
            this.EndlessMode.Name = "EndlessMode";
            this.EndlessMode.Size = new System.Drawing.Size(533, 45);
            this.EndlessMode.TabIndex = 16;
            this.EndlessMode.Text = "Victory! Entering Endless Mode...";
            this.EndlessMode.Visible = false;
            // 
            // tmrEndlessTextHide
            // 
            this.tmrEndlessTextHide.Interval = 5000;
            this.tmrEndlessTextHide.Tick += new System.EventHandler(this.EndlessTextHideTick);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(1109, 183);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(109, 45);
            this.lblLevel.TabIndex = 18;
            this.lblLevel.Text = "Level:";
            this.lblLevel.Visible = false;
            // 
            // lblLevelValue
            // 
            this.lblLevelValue.AutoSize = true;
            this.lblLevelValue.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevelValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLevelValue.Location = new System.Drawing.Point(1219, 183);
            this.lblLevelValue.Name = "lblLevelValue";
            this.lblLevelValue.Size = new System.Drawing.Size(39, 45);
            this.lblLevelValue.TabIndex = 19;
            this.lblLevelValue.Text = "1";
            this.lblLevelValue.Visible = false;
            this.lblLevelValue.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // tmrPowerUpDecay
            // 
            this.tmrPowerUpDecay.Interval = 5000;
            this.tmrPowerUpDecay.Tick += new System.EventHandler(this.tmrPowerUpDecay_Tick);
            // 
            // btnTutorial
            // 
            this.btnTutorial.AutoSize = true;
            this.btnTutorial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTutorial.Location = new System.Drawing.Point(1007, 736);
            this.btnTutorial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(251, 93);
            this.btnTutorial.TabIndex = 23;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 845);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.arrowIncOmniCost);
            this.Controls.Add(this.arrowIncOmni);
            this.Controls.Add(this.arrowInc);
            this.Controls.Add(this.arrowIncCost);
            this.Controls.Add(this.villageHealCost);
            this.Controls.Add(this.playerHealCost);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.lblLevelValue);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.EndlessMode);
            this.Controls.Add(this.playerHeal);
            this.Controls.Add(this.townHeal);
            this.Controls.Add(this.lblCountMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblStrengthActivated);
            this.Controls.Add(this.lblSpeedActivated);
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
            this.Load += new System.EventHandler(this.FrmMain_Load);
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
        private System.Windows.Forms.Timer tmrCheckPowerUpsCollected;
        private System.Windows.Forms.Timer tmrPowerUpsDeactivate;
        private Label lblSpeedActivated;
        private Label lblStrengthActivated;
        private Label lblMoney;
        private Label lblCountMoney;
        private Button townHeal;
        private Button playerHeal;
        private Label shopLabel;
        private Label playerHealCost;
        private Label villageHealCost;
        private Label arrowIncCost;
        private Button arrowInc;
        private Button arrowIncOmni;
        private Label arrowIncOmniCost;
        private Label EndlessMode;
        private System.Windows.Forms.Timer tmrEndlessTextHide;
        private Label lblLevel;
        private Label lblLevelValue;
        private System.Windows.Forms.Timer tmrPowerUpDecay;
        private Button btnTutorial;
    }
}