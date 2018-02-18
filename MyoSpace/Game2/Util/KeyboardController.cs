using Game2.Entities;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2.Util
{
    class KeyboardController:Controller
    {
        KeyboardState _keyboardState;

        public override void Move(IControllable controllable)
        {
            _keyboardState = Keyboard.GetState();
            if (_keyboardState.IsKeyDown(Keys.Up)){
                controllable.ControlPosition(1, Direction.Up);
            }
            if (_keyboardState.IsKeyDown(Keys.Down))
            {
                controllable.ControlPosition(1, Direction.Down);
            }
            if (_keyboardState.IsKeyDown(Keys.Left))
            {
                controllable.ControlPosition(1, Direction.Left);
            }
            if (_keyboardState.IsKeyDown(Keys.Right))
            {
                controllable.ControlPosition(1, Direction.Right);
            }
        }
    }
}
