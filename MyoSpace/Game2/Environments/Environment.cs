using Game2.Entities;
using Game2.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2.Environments
{
    abstract class Environment
    {
        private Controller _controller;
        private List<IControllable> _players = new List<IControllable>();

        public Environment(Controller controller)
        {
            _controller = controller;
        }

        public void AddPlayer(IControllable player)
        {
            _players.Add(player);
            
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach(IControllable player in _players)
                _controller.Move(player);
        }

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (Entity player in _players)
                player.Draw(spriteBatch, gameTime);
        }
    }
}
