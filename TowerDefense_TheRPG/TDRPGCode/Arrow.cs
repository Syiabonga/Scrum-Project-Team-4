﻿using System.Diagnostics.Eventing.Reader;

namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Basic ranged attack for our player
  /// </summary>
  public class Arrow {
    private int dirX;
    private int dirY;
    private int moveSpeed;

    /// <summary>
    /// Current X position of arrow
    /// </summary>
    public int X { get; private set; }

    /// <summary>
    /// Current Y position of arrow
    /// </summary>
    public int Y { get; private set; }

    /// <summary>
    /// Visual representation of arrow as a picture box
    /// </summary>
    public Control ControlCharacter { get; private set; }

    /// <summary>
    /// Explicit constructor
    /// </summary>
    /// <param name="x">Initial x position</param>
    /// <param name="y">Initial y position</param>
    /// <param name="dirX">Direction along x axis it should travel everytime it moves. Value should be -1, 0 or +1. This is multiplied by moveSpeed when moving</param>
    /// <param name="dirY">Direction along y axis it should travel everytime it moves. Value should be -1, 0 or +1. This is multiplied by moveSpeed when moving</param>
    public Arrow(int x, int y, int dirX, int dirY) {
      X = x;
      Y = y;
      this.dirX = dirX;
      this.dirY = dirY;
      moveSpeed = 10;
      string name = "arrowhead";
            // Arrows are currently supported for cardianl and intercardinal firing. Created images for instances made by Christian Evans.
            if (dirY == 0) {
                if (dirX > 0) {
                    name = "arrow_right";
                }
                else {
                    name = "arrow_left";
                }
            }
            else if (dirX == 0) {
                if (dirY < 0) {
                    name = "arrow_up";
                }
                else {
                    name = "arrow_down";
                }
            }
            else if (dirY > 0) {
                if (dirX < 0) {
                    name = "arrow_botleft";
                }
                else {
                    name = "arrow_botright";
                }
            }
            else if (dirY < 0) {
                if (dirX > 0) {
                    name = "arrow_topright";
                }
                else {
                    name = "arrow_topleft";
                }
            }
      ControlCharacter = new PictureBox() {
        BackgroundImage = ControlManager.ResMan.GetObject(name) as Bitmap,
        BackgroundImageLayout = ImageLayout.Stretch,
        Width = 30,
        Height = 30,
        BackColor = Color.Transparent,
      };
      ControlManager.Form.Controls.Add(ControlCharacter);
    }

    /// <summary>
    /// Moves the arrow. This takes the arrow's direction (dirX, dirY) and multiplies it by
    /// moveSpeed to get a new X and Y location. This then updates the picture box's location
    /// </summary>
    public virtual void Move() {
      Y += dirY * moveSpeed;
      X += dirX * moveSpeed;
      ControlCharacter.Top = Y;
      ControlCharacter.Left = X;
    }

    /// <summary>
    /// Determines if the arrow collided with a <see cref="Character">character</see> object
    /// </summary>
    /// <param name="chr">The <see cref="Character">character</see> object to check collision with</param>
    /// <returns>True if collided, false otherwise</returns>
    public bool ArrowCollide(Character chr) {
      return ControlCharacter.Bounds.IntersectsWith(chr.ControlContainer.Bounds);
    }
  }
}
