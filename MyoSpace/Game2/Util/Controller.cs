using Game2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2.Util
{
    abstract class Controller
    {
        public abstract void Move(IControllable controllable);
    }
}
