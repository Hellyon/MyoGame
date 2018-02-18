using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2.Entities
{
    class Sprite
    {
        private Texture2D _texture;

        public Vector2 Position { get; set; }

        public Sprite()
        {
            
        }

        public virtual void Initialize()

        {

            Position = Vector2.Zero;


        }

        public virtual void LoadContent(ContentManager content, string assetName)
        {
            _texture = content.Load<Texture2D>(assetName);
        }

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(_texture, Position, Color.White);
        }
    }
}
