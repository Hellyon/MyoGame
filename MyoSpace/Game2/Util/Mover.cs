using Game2.Entities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2.Util
{
    static class Mover
    {
        public static void Move(Sprite sprite,float speed, Direction direction)
        {
            Vector2 newPos=sprite.Position; 
            if (direction == Direction.Up)
            {
                newPos.Y -= speed;
            }
            if (direction == Direction.Down)
            {
                newPos.Y += speed;
            }
            if (direction == Direction.Left)
            {
                newPos.X -= speed;
            }
            if (direction == Direction.Right)
            {
                newPos.X += speed;
            }
            sprite.Position = newPos;
        }
    }
}
