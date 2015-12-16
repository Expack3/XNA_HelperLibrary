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
    public class KeyboardHandler : Microsoft.Xna.Framework.GameComponent
    {
        KeyboardState prevKBState;
        KeyboardState currKBState;

        public KeyboardHandler(Game game)
            : base(game)
        {
            prevKBState = new KeyboardState();
            currKBState = new KeyboardState();
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            currKBState = Keyboard.GetState();
            prevKBState = currKBState;
            base.Initialize();
        }

        public Boolean isKeyPressed(Keys key)
        {
            Boolean isKeyPressed = false;
            if ((currKBState.IsKeyDown(key) == true) && (prevKBState.IsKeyDown(key) != true))
            {
                isKeyPressed = true;
            }
            return isKeyPressed;
        }

        public Boolean isKeyHeld(Keys key)
        {
            Boolean isKeyHeld = false;
            if ((currKBState.IsKeyDown(key) == true) && (prevKBState.IsKeyDown(key) == true))
            {
                isKeyHeld = true;
            }
            return isKeyHeld;
        }

        public Boolean isKeyReleased(Keys key)
        {
            Boolean isKeyReleased = false;
            if ((currKBState.IsKeyUp(key) == true) && (prevKBState.IsKeyDown(key) == true))
            {
                isKeyReleased = true;
            }
            return isKeyReleased;
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            prevKBState = currKBState;
            currKBState = Keyboard.GetState();
            base.Update(gameTime);
        }
    }
}
