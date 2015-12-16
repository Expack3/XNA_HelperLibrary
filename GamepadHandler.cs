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
    public class GamepadHandler : Microsoft.Xna.Framework.GameComponent
    {
        GamePadState prevGPState;
        GamePadState currGPState;

        public GamepadHandler(Game game)
            : base(game)
        {
            prevGPState = GamePad.GetState(PlayerIndex.One);
            currGPState = GamePad.GetState(PlayerIndex.One);
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            currGPState = GamePad.GetState(PlayerIndex.One);
            prevGPState = currGPState;
            base.Initialize();
        }

        public Boolean isButtonPressed(Buttons button)
        {
            Boolean isButtonPressed = false;
            if ((currGPState.IsButtonDown(button) == true) && (prevGPState.IsButtonDown(button) != true))
            {
                isButtonPressed = true;
            }
            return isButtonPressed;
        }

        public Boolean isButtonHeld(Buttons button)
        {
            Boolean isButtonHeld = false;
            if ((currGPState.IsButtonDown(button) == true) && (prevGPState.IsButtonDown(button) == true))
            {
                isButtonHeld = true;
            }
            return isButtonHeld;
        }

        public Boolean isButtonReleased(Buttons button)
        {
            Boolean isButtonReleased = false;
            if ((currGPState.IsButtonUp(button) == true) && (prevGPState.IsButtonDown(button) == true))
            {
                isButtonReleased = true;
            }
            return isButtonReleased;
        }

        public Boolean isControllerDisconnected()
        {
            if (currGPState.IsConnected && prevGPState.IsConnected)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            prevGPState = currGPState;
            currGPState = GamePad.GetState(PlayerIndex.One);
            base.Update(gameTime);
        }
    }
}
