using System;
using System.Diagnostics;
using TowerDefense_TheRPG.code;
using TowerDefense_TheRPG.Properties;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TowerDefense_TheRPG
{
    public partial class FrmMain : Form
    {
        #region Fields
        private Player player;
        private Village village;
        private List<Enemy> enemies;
        private List<Arrow> arrows;
        private List<PowerUp> powerups = new List<PowerUp>();
        private string storyLine;
        private int curStoryLineIndex;
        private Random rand;
        private int PlayerDirX = 0, PlayerDirY = 0;
        private bool FiringArrows = false;
        public static int kills;
        public static int counter;
        public static string storeTimePlayed = "";
        #endregion

        #region Methods
        #region Ctor
        public FrmMain()
        {
            InitializeComponent();
            FormManager.PushToFormStack(this);
            DoubleBuffered = true;
            ControlManager.ResMan = Resources.ResourceManager;
            ControlManager.Form = this;
            rand = new Random();
        }
        #endregion

        #region Event functions
        // timers
        private void tmrTextCrawl_Tick(object sender, EventArgs e)
        {
            if (curStoryLineIndex < storyLine.Length)
            {
                lblStoryLine.Text += storyLine[curStoryLineIndex++];
                lblStoryLine.Refresh();
            }
            else
            {
                tmrTextCrawl.Enabled = false;
            }
        }
        private void tmrGameTime_Tick(object sender, EventArgs e)
        {

            counter++;
            //format timer
            TimeSpan time = TimeSpan.FromSeconds(counter);
            lblCountTime.Text = time.ToString(@"mm\:ss");
            storeTimePlayed = time.ToString(@"mm\:ss");
            //generate boss balloon every 60 minute
            GenEnemyPos(out int x, out int y);
            Enemy bossBalloon;
            if (counter % 60 == 0)
            {
                bossBalloon = Enemy.MakeBossBalloon(x, y);
                enemies.Add(bossBalloon);
            }
        }
        private void tmrSpawnEnemies_Tick(object sender, EventArgs e)
        {
            GenEnemyPos(out int x, out int y);
            int enemyType = rand.Next(4);
            Enemy balloon;
            switch (enemyType)
            {
                case 0:
                    balloon = Enemy.MakeRedBalloon(x, y);
                    break;
                case 1:
                    balloon = Enemy.MakePurpleBalloon(x, y);
                    break;
                case 2:
                    balloon = Enemy.MakeGrayBalloon(x, y);
                    break;
                default:
                    balloon = Enemy.MakeOrangeBalloon(x, y);
                    break;

            }
            enemies.Add(balloon);
        }

        private void tmrMoveEnemies_Tick(object sender, EventArgs e)
        {
            MoveEnemies();
            CheckPowerUps();
        }
        private void tmrSpawnArrows_Tick(object sender, EventArgs e)
        {
            FireArrows();
        }
        private void tmrSpawnPowerUp_Tick(object sender, EventArgs e)
        {
            SpawnPowerUps();
        }
        private void tmrMoveArrows_Tick(object sender, EventArgs e)
        {
            MoveArrows();
        }
        private void FiredArrow_Tick(object sender, EventArgs e)
        {
            tmrFiredArrow.Enabled = false;
        }

        // form
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == 'e' && tmrFiredArrow.Enabled == false)
                {
                    FireArrows();
                    tmrFiredArrow.Enabled = true;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    PlayerDirY = -1;
                    break;
                case Keys.Down:
                case Keys.S:
                    PlayerDirY = +1;
                    break;
                case Keys.Left:
                case Keys.A:
                    PlayerDirX = -1;
                    break;
                case Keys.Right:
                case Keys.D:
                    PlayerDirX = +1;
                    break;
                case Keys.E:
                    FiringArrows = true;
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    PlayerDirY = 0;
                    break;
                case Keys.Down:
                case Keys.S:
                    PlayerDirY = 0;
                    break;
                case Keys.Left:
                case Keys.A:
                    PlayerDirX = 0;
                    break;
                case Keys.Right:
                case Keys.D:
                    PlayerDirX = 0;
                    break;
                case Keys:
                    FiringArrows = false;
                    break;
            }
        }
        // buttons
        private void btnStart_Click(object sender, EventArgs e)
        {
            GameStart(sender, e);
        }

        /// <summary>
        /// Initializes game logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameStart(object sender, EventArgs e)
        {
            BackgroundImage = null;
            btnStart.Visible = false;
            btnStart.Enabled = false;
            btnStoryLine.Visible = false;
            btnStart.Enabled = false;
            lblStoryLine.Visible = false;



            //start game timer
            tmrGameTime.Start();

            //make time and kills visible
            lblCountKills.Visible = true;
            lblCountTime.Visible = true;
            lblKills.Visible = true;
            lblGameTime.Visible = true;

            enemies = new List<Enemy>();
            arrows = new List<Arrow>();
            player = new Player(Width / 2, Height / 2 + 100);
            village = new Village(Width / 2 - 80, Height / 2 - 50);
            village.ControlContainer.SendToBack();
            tmrSpawnEnemies.Enabled = true;
            tmrMoveEnemies.Enabled = true;
            tmrMoveArrows.Enabled = true;
            if (player.Level == 1) {
                tmrSpawnArrows.Interval = 2000;
                tmrSpawnArrows.Enabled = false;
                //FireArrows();
            }
            tmrTextCrawl.Enabled = false;

            // TODO: setting the background image here causes visual defects as enemies and player move
            //       around the screen. Consider either fixing these defects or setting BackgroundImage to null
            BackgroundImage = Resources.ground;

            // important, keep this call to Focus()!
            // otherwise, for whatever reason, the start button retains focus (even when enabled = false)
            // and arrow key presses are ignored and won't move player.
            Focus();
        }
        /// <summary>
        /// Runs when an Enemy dies, handles all XP logic
        /// </summary>
        /// <param name="enemy"></param>
        private void EnemyKilled(Enemy enemy)
        {
            kills += 1;
            lblCountKills.Text = kills.ToString();
            enemy.Hide();
            player.GainXP(enemy.XPGiven);
            int level = player.Level;
            if (level > 1) {
            //    tmrSpawnArrows.Enabled = true;
            //    tmrMoveArrows.Enabled = true;
                tmrSpawnPowerUp.Enabled = true;
            //    FireArrows();
            }
            //else if (levelBefore == 2 && levelAfter == 3)
            //{
            //    tmrSpawnArrows.Interval = 2500;
            //    tmrSpawnArrows.Enabled = true;
            //    FireArrows();
            //}

        }

        private void btnStoryLine_Click(object sender, EventArgs e)
        {
            if (btnStoryLine.Text.StartsWith("Show"))
            {
                Storyline();
                BackgroundImage = null;
                btnStart.Visible = false;
                btnStoryLine.Text = "Hide Storyline";
                lblStoryLine.Visible = true;

                tmrSpawnEnemies.Enabled = false;
                tmrMoveEnemies.Enabled = false;
                tmrMoveArrows.Enabled = false;
                tmrTextCrawl.Enabled = true;
            }
            else
            {
                BackgroundImage = Resources.title;
                btnStart.Visible = true;
                btnStoryLine.Text = "Show Storyline";
                lblStoryLine.Visible = false;

                tmrTextCrawl.Enabled = false;
            }
        }
        #endregion

        #region Helper functions
        private void Storyline()
        {
            // TODO: probably should be read from a resource text file
            storyLine = "Ok, you want a story line, here it is. Once upon a time, there was this village. ";
            storyLine += "In this village were towers. These were great times where towers could roam around, ";
            storyLine += "free of their nature predator..... the balloon! One day, dark clouds appeared in the sky. ";
            storyLine += "It looked like M Night Shamaleon was creating another movie. Then, something strange happened! ";
            storyLine += "Evil balloons started entering the village. 1 balloon, then 2 balloons, then several more. The towers became afraid. ";
            storyLine += "As everyone knows, if a balloon hits a tower and pops, the tower loses health (and it hurts the tower's feelings). ";
            storyLine += "Well, one of the towers was having none of this and decided to take action! Wearing the only balloon proof vest in the entire town, ";
            storyLine += "Peaches the tower stood guard against the balloons. ";
            storyLine += "Your role in this game is to play as Peaches and defeat the evil balloons thereby defending the village (and the towers within).";
            lblStoryLine.Text = "";
            tmrTextCrawl.Enabled = true;
            curStoryLineIndex = 0;
        }
        public void GenEnemyPos(out int x, out int y)
        {
            int enterDir = rand.Next(4);
            const int offscreen = -5;
            switch (enterDir)
            {
                case 0: // left
                    y = rand.Next(0, Height);
                    x = -offscreen;
                    break;
                case 1: // bottom
                    x = rand.Next(0, Width);
                    y = Height + offscreen;
                    break;
                case 2: // right
                    y = rand.Next(0, Height);
                    x = Width + offscreen;
                    break;
                default: // top
                    x = rand.Next(0, Width);
                    y = -offscreen;
                    break;
            }
        }
        private void MoveEnemies()
        {
            foreach (var enemy in enemies)
            {
                if (enemy.CurHealth <= 0)
                {
                    continue;
                }
                int xDir = 0;
                int yDir = 0;
                if (enemy.ControlContainer.Left < Width / 2)
                {
                    xDir = 1;
                }
                else
                {
                    xDir = -1;
                }
                if (enemy.ControlContainer.Top < Height / 2)
                {
                    yDir = 1;
                }
                else
                {
                    yDir = -1;
                }
                enemy.Move(xDir, yDir, true, Width, Height);
                if (enemy.DidCollide(player))
                {
                    enemy.TakeDamageFrom(player);
                    player.TakeDamageFrom(enemy);
                    if(player.CurHealth <= 0)
                    {
                        village.Hide(); // defeated
                        Form frmStat = new FrmStats();
                        Form frmGO = new FrmGameOver();
                        frmStat.Show();                        
                        this.Hide();
                        FormManager.PushToFormStack(frmStat);

                        // disable timers
                        tmrMoveArrows.Enabled = false;
                        tmrMoveEnemies.Enabled = false;
                        tmrSpawnArrows.Enabled = false;

                        tmrSpawnEnemies.Enabled = false;
                        tmrSpawnPowerUp.Enabled = false;
                    }

                    if (enemy.CurHealth <= 0)
                    {
                        EnemyKilled(enemy);
                    }
                    else
                    {
                        enemy.KnockBack();
                    }
                }
                else if (enemy.DidCollide(village))
                {
                    village.TakeDamageFrom(enemy);
                    if (village.CurHealth <= 0)
                    {
                        village.Hide(); // defeated
                        Form frmGO = new FrmGameOver();
                        frmGO.Show();
                        this.Hide();
                        FormManager.PushToFormStack(frmGO);

                        // disable timers
                        tmrMoveArrows.Enabled = false;
                        tmrMoveEnemies.Enabled = false;
                        tmrSpawnArrows.Enabled = false;

                        tmrSpawnEnemies.Enabled = false;
                        tmrSpawnPowerUp.Enabled = false;
                    }
                    else
                    {
                        enemy.KnockBack();
                    }
                }
            }

            List<Enemy> enemiesToRemove = new List<Enemy>();
            foreach (Enemy enemy in enemies)
            {
                if (enemy.CurHealth <= 0)
                {
                    enemiesToRemove.Add(enemy);
                }
            }

            foreach (Enemy enemy in enemiesToRemove)
            {
                enemies.Remove(enemy);
            }
        }
        private void MoveArrows()
        {
            List<Arrow> arrowsToRemove = new List<Arrow>();
            foreach (Arrow arrow in arrows)
            {
                arrow.Move();
                foreach (Enemy enemy in enemies)
                {
                    if (arrow.ArrowCollide(enemy))
                    {
                        enemy.TakeDamage(0.1f);
                        if (enemy.CurHealth <= 0)
                        {
                            EnemyKilled(enemy);
                        }
                        else
                        {
                            enemy.KnockBack();
                        }
                        arrowsToRemove.Add(arrow);
                    }
                }
            }
            foreach (Arrow arrow in arrowsToRemove)
            {
                arrows.Remove(arrow);
                Controls.Remove(arrow.ControlCharacter);
            }
        }
        private void FireArrows()
        {
            Arrow arrowLeft = new Arrow(player.X, player.Y, -1, 0);
            Arrow arrowRight = new Arrow(player.X, player.Y, +1, 0);
            Arrow arrowUp = new Arrow(player.X, player.Y, 0, +1);
            Arrow arrowDown = new Arrow(player.X, player.Y, 0, -1);
            Arrow arrowTopRight = new Arrow(player.X, player.Y, +1, +1);
            Arrow arrowBotRight = new Arrow(player.X, player.Y, +1, -1);
            Arrow arrowTopLeft = new Arrow(player.X, player.Y, -1, +1);
            Arrow arrowBotLeft = new Arrow(player.X, player.Y, -1, -1);
            arrows.Add(arrowLeft);
            arrows.Add(arrowRight);
      
            arrowLeft.ControlCharacter.BringToFront();
            arrowRight.ControlCharacter.BringToFront();
           
            if (player.Level >= 2) {
                arrows.Add(arrowUp);
                arrows.Add(arrowDown);

                arrowLeft.ControlCharacter.BringToFront();
                arrowRight.ControlCharacter.BringToFront();
                arrowUp.ControlCharacter.BringToFront();
                arrowDown.ControlCharacter.BringToFront();
            }
            if (player.Level >= 3) {
                arrows.Add(arrowTopRight);
                arrows.Add(arrowBotRight);
                arrows.Add(arrowTopLeft);
                arrows.Add(arrowBotLeft);

                arrowLeft.ControlCharacter.BringToFront();
                arrowRight.ControlCharacter.BringToFront();
                arrowUp.ControlCharacter.BringToFront();
                arrowDown.ControlCharacter.BringToFront();
                arrowTopRight.ControlCharacter.BringToFront();
                arrowBotRight.ControlCharacter.BringToFront();
                arrowTopLeft.ControlCharacter.BringToFront();
                arrowBotLeft.ControlCharacter.BringToFront();
            }
        }
        public void SpawnPowerUps()
        {
            int y = rand.Next(0, Height);
            int x = rand.Next(0, Width);
            int PowerUpType = rand.Next(3);
            PowerUp powerup;
            switch (PowerUpType)
            {
                case 0:
                    powerup = new PowerUp("healing", x, y);
                    break;
                case 1:
                    powerup = new PowerUp("speed", x, y);
                    break;
                default:
                    powerup = new PowerUp("strength", x, y);
                    break;
            }
            powerups.Add(powerup);
            powerup.ControlPowerUp.BringToFront();
        }
        public void CheckPowerUps()
        {
            List<PowerUp> PowerUpsToRemove = new List<PowerUp>();
            foreach (PowerUp powerup in powerups)
            {
                if (powerup.DidCollide(player))
                {
                    PowerUpsToRemove.Add(powerup);
                }
            }
            foreach (PowerUp power in PowerUpsToRemove)
            {
                powerups.Remove(power);
                Controls.Remove(power.ControlPowerUp);
            }
        }
        private void PlayerMove(int DirX, int DirY)
        {
            if(DirX !=0 || DirY != 0)
            {
                player.Move(DirX, DirY, true, Width, Height);
            }
        }

        #endregion

        #endregion

        private void tmrFiringArrows_Tick(object sender, EventArgs e)
        {
            if (FiringArrows || tmrFiredArrow.Enabled == false)
            {
                FireArrows();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblStoryLine_Click(object sender, EventArgs e)
        {

        }

      

        private void tmrMovePlayer_Tick(object sender, EventArgs e)
        {
            PlayerMove(PlayerDirX, PlayerDirY);
        }
    }
}