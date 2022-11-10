using System.Xml.Linq;

namespace TowerDefense_TheRPG.code
{
    /// <summary>
    /// Class for power ups
    /// </summary>
    public class PowerUp
    {
        /// <summary>
        /// Visual representation of power-up
        /// </summary>
        public Control ControlPowerUp { get; private set; }

        /// <summary>
        /// Returns the power-up name for activation
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="name">Name of the power-up. Used to lookup an image in resource.</param>
        /// <param name="x">Initial x location</param>
        /// <param name="y">Initial y location</param>
        /// <param name="w">Desired width of the picturebox used to represent this power-up</param>
        /// <param name="h">Desired height of the picturebox used to represent this power-up</param>
        public PowerUp(string name, int x, int y)
        {
            Name = name;
            ControlPowerUp = new PictureBox()
            {
                BackgroundImage = ControlManager.ResMan.GetObject(name) as Bitmap,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 50,
                Height = 50,
                BackColor = Color.Transparent,
            };
            ControlPowerUp.Top = y;
            ControlPowerUp.Left = x;
            ControlManager.Form.Controls.Add(ControlPowerUp);
        }

        /// <summary>
        /// Determines if the power-up collided with a <see cref="Character">character</see> object
        /// </summary>
        /// <param name="chr">The <see cref="Character">character</see> object to check collision with</param>
        /// <returns>True if collided, false otherwise</returns>
        public bool DidCollide(Character chr)
        {
            return ControlPowerUp.Bounds.IntersectsWith(chr.ControlContainer.Bounds);
        }
    }
}