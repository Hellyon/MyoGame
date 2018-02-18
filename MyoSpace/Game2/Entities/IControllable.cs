using Game2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2.Entities
{
    interface IControllable
    {
        void ControlPosition(float intensity, Direction direction);
    }
}
