using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game2.Util;

namespace Game2.Entities
{
    class Entity : CollisionableSprite, IControllable
    {
        public virtual void ControlPosition(float intensity, Direction direction)
        {
            float speed;
            if (intensity < 0.5)
            {
                speed = 2.5F;
            }
            else
                speed = 5F;
            Mover.Move(this, speed, direction);
        }
    }
}
