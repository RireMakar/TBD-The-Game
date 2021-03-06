﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace FloorIsLava
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private GameState gameState;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            gameState = new GameState(this);
            gameState.StartScreen = new StartScreen(this);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            switch (gameState.CurrentScreen)
            {
                case Screen.StartScreen:
                    if (gameState.StartScreen != null)
                    {
                        gameState.StartScreen.Update();
                    }
                    break;

                case Screen.GameScreen:
                    if (gameState.GameScreen != null)
                    {
                        gameState.GameScreen.Update(gameTime);
                    }
                    break;

                case Screen.InstructionScreen:
                    if (gameState.InstructionScreen != null)
                    {
                        gameState.InstructionScreen.Update(gameTime);
                    }
                    break;

                case Screen.OptionScreen:
                    if (gameState.OptionScreen != null)
                    {
                        gameState.OptionScreen.Update(gameTime);
                    }
                    break;

                case Screen.CreditScreen:
                    if (gameState.CreditScreen != null)
                    {
                        gameState.CreditScreen.Update(gameTime);
                    }
                    break;

                case Screen.LevelScreen:
                    if (gameState.LevelScreen != null)
                    {
                        gameState.LevelScreen.Update(gameTime);
                    }
                    break;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            switch(gameState.CurrentScreen)
            {
                case Screen.StartScreen:
                    if (gameState.StartScreen != null)
                    {
                        GraphicsDevice.Clear(Color.Green);
                        gameState.StartScreen.Draw(spriteBatch);
                    }
                    break;

                case Screen.GameScreen:
                    if (gameState.GameScreen != null)
                    {
                        GraphicsDevice.Clear(Color.SteelBlue);
                        gameState.GameScreen.Draw(spriteBatch);
                    }
                    break;

                case Screen.InstructionScreen:
                    if(gameState.InstructionScreen != null)
                    {
                        GraphicsDevice.Clear(Color.Red);
                        gameState.InstructionScreen.Draw(spriteBatch);
                    }
                    break;

                case Screen.OptionScreen:
                    if(gameState.OptionScreen != null)
                    {
                        GraphicsDevice.Clear(Color.Gold);
                        gameState.OptionScreen.Draw(spriteBatch);
                    }
                    break;

                case Screen.CreditScreen:
                    if (gameState.CreditScreen != null)
                    {
                        GraphicsDevice.Clear(Color.Black);
                        gameState.CreditScreen.Draw(spriteBatch);
                    }
                    break;

                case Screen.LevelScreen:
                    if (gameState.LevelScreen != null)
                    {
                        GraphicsDevice.Clear(Color.Gray);
                        gameState.LevelScreen.Draw(spriteBatch);
                    }
                    break;
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}
