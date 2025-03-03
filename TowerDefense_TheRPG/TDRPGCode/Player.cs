﻿namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Class for our player
  /// </summary>
  public class Player : Character {
    /// <summary>
    /// Amount of money the player has. Currently this is not being
    /// used but you could add this as a feature.
    /// </summary>
    public int Money { get; private set; }

    /// <summary>
    /// Current amount of experience. You gain experience by defeating
    /// <see cref="Enemy"/> objects (e.g. balloons)
    /// </summary>
    public int XP { get; private set; }

        /// <summary>
        /// Current amount of experience required to advance a level.
        /// </summary>
        public int LevelXP { get; private set; }

        /// <summary>
        /// Current level player has.
        /// </summary>
        public int Level { get; private set; }

    /// <summary>
    /// If this is set to true, player will automatically shoot arrows
    /// every so often (the time interval is set as the Interval property
    /// of the tmrSpawnArrows object in FrmMain)
    /// </summary>
    public bool AutoShoot { get; private set; }

    /// <summary>
    /// Explicit constructor
    /// </summary>
    /// <param name="x">Initial x position of player</param>
    /// <param name="y">Initial y position of player</param>
    public Player(int x, int y) : base("player", x, y, 50, 100) {
      UpdateMaxHealth(3.0f);
      Money = 0;
      Attack = 0.15f;
      MoveSpeed = 10;
      Level = 1;
      XP = 0;
      ChangeCharacterPic("playerL" + Level);
    }

    /// <summary>
    /// Call this function whenever the player defeats an <see cref="Enemy"/>
    /// </summary>
    /// <param name="xpGained">How much experience the player should gain. 
    ///                        Use <see cref="Enemy.XPGiven"/> for this</param>
    public void GainXP(int xpGained)
        {
            LevelXP = 5 + (Level * (Level * 5));

            GainLevel();

            XP += xpGained;

            if (XP >= LevelXP)
            {
                GainLevel();
            }
        }

    /// <summary>
    /// Call this function whenever a player defeats an enemy.
    /// Made by Christian Evans.
    /// </summary>
    public void GainMoney(int moneyGained) {
      Money += moneyGained;
    }

    /// <summary>
    /// Internal function that is automatically called when 
    /// player gains a level (called from GainXP method)
    /// </summary>
    private void GainLevel() {
      Level++;
      Attack *= 1.5f;
      UpdateMaxHealth(0.5f);
      if (Level <= 3) {
        ChangeCharacterPic("playerL" + Level);
      }
      if (Level >= 3) {
        AutoShoot = true;
      }
    }
  }
}
