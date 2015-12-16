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
    class GamepadDetection : Microsoft.Xna.Framework.GameComponent
    {
        GamePadState GPstate;
        KeyboardState KBState;
        Boolean KBusage;
        public GamepadDetection(Game game)
            : base(game)
        {
            GPstate = GamePad.GetState(PlayerIndex.One);
            KBState = Keyboard.GetState();
        }

        public Boolean isKeyboardUsed()
        {
            return KBusage;
        }

        public override void Update(GameTime gameTime)
        {
            if (KBState.GetPressedKeys().Length > 0 && GPstate.IsConnected == true)
                KBusage = true;
            else
                KBusage = false;
            base.Update(gameTime);
        }
    }
}
