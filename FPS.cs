using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace XNA_Library
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class FPS : Microsoft.Xna.Framework.DrawableGameComponent
    {
        public float elapsedTime; //Total number of ms
        int frameCount;
        public FPS(Game game)
            : base(game)
        {
            elapsedTime = 0.0f;
            frameCount = 0;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            elapsedTime += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            frameCount++;

            if (elapsedTime > 1000)
            {
                elapsedTime = 0.0f;
                Game.Window.Title = String.Format("FPS: {0}", frameCount);
                frameCount = 0;
            }
            base.Draw(gameTime);
        }
    }
}
