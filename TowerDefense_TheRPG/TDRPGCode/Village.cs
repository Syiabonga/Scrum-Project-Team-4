namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Represents our village, the thing we are trying to protect
  /// </summary>
  public class Village : Character {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="x">Initial X (aka left) position of village</param>
    /// <param name="y">Initial Y (aka top) position of village</param>
    public Village(int x, int y) : base("village", x, y, 165, 100) {
      SetMaxHealth(5.0f);
    }
    /// <summary>
    /// Upgrades the Village's Health, called by GainLevel.
    /// </summary>
    public void UpgradeVillage()
    {
      IncreaseHealth(1.0f);
    }
  }
}