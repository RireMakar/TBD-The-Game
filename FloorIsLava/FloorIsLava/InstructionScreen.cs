﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace FloorIsLava
{
    class InstructionScreen
    {
        #region Attributes
        //Attributes
        private SpriteFont font1;
        private Game1 game;
        private KeyboardState lastState;
        private GameState gameState;
        #endregion Attributes

        #region Constructor 
        //Constructor
        public InstructionScreen(Game1 game1)
        {
            game = game1; //assigns the game1 object to game attribute
            gameState = new GameState(game); // creates the gameState object and puts it into gamestate attribute
            font1 = game.Content.Load<SpriteFont>("Font1"); //loads the Font1 sprite font
        }
        #endregion Constructor

        #region Methods
        //Update Method
        public void Update(GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.S) && lastState.IsKeyDown(Keys.S))
            {
                gameState.CurrentScreen = Screen.StartScreen;
            }
            if (keyState.IsKeyDown(Keys.G) && lastState.IsKeyDown(Keys.G))
            {
                gameState.StartGame();
            }
            if (keyState.IsKeyDown(Keys.O) && lastState.IsKeyDown(Keys.O))
            {
                gameState.SwitchOption(game);
            }
            if (keyState.IsKeyDown(Keys.L) && lastState.IsKeyDown(Keys.L))
            {
                gameState.SwitchLevel(game);
            }
            if (keyState.IsKeyDown(Keys.C) && lastState.IsKeyDown(Keys.C))
            {
                gameState.SwitchCredit(game);
            }
            lastState = keyState;
        }

        //Draw Method
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font1, "this is instruction Screen", new Vector2(50f, 50f), Color.Black);
        }
        #endregion Methods
    }
}
