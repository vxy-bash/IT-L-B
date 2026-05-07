using System;

namespace FootballGame
{
  public class FieldPlayer : Player
  {
    public int ShootingQuality { get; set; }

    public int Shoot()
    {
      return ShootingQuality + Random.Shared.Next(-2, 2);
    }
  }
}