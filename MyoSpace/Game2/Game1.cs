using Game2.Entities;
using Game2.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MyoLib;
using MyoSharp;
using System;
using System.Diagnostics;

namespace Game2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        static MyoManager mgr;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Environments.Environment mainLevel;

        //private static double x { get; set; }
        //private static double y { get; set; }
        //private static double z { get; set; }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            graphics.ToggleFullScreen();
            //mgr = new MyoManager();
            //mgr.Init();
            //mgr.MyoConnected += Mgr_MyoConnected;
            //mgr.MyoLocked += Mgr_MyoLocked;
            //mgr.MyoUnlocked += Mgr_MyoUnlocked;
            //mgr.PoseChanged += Mgr_PoseChanged;
            //mgr.HeldPoseTriggered += Mgr_HeldPoseTriggered;
            //mgr.PoseSequenceCompleted += Mgr_PoseSequenceCompleted;
            //mgr.MyoConnected += Mgr_MyoConnected1;
            //mgr.StartListening();
            
            
        }

        private static void Mgr_MyoConnected1(object sender, MyoSharp.Device.MyoEventArgs e)
        {
            //mgr.SubscribeToOrientationData(0, (source, args) => WriteLine($"{args.Yaw:0.00} ; {args.Pitch:0.00} ; {args.Roll:0.00}"));
            //mgr.SubscribeToGyroscopeData(0, (source, args) => WriteLine($"{args.Gyroscope.X:00.00} ; {args.Gyroscope.Y:00.00} ; {args.Gyroscope.Z:00.00}"));
            //mgr.SubscribeToOrientationData(0, (source, args) => {x = args.Yaw; y = args.Pitch; z=args.Roll;});
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
            mainLevel = new Environments.Level(new KeyboardController());

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
            Entity playerShip = new Entity();
            playerShip.LoadContent(Content, "Assets/Sprites/playerShip1_blue");
            mainLevel.AddPlayer(playerShip);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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

            //Debug.WriteLine("x = " + x.ToString() + " ; y = " + y.ToString() + " ; z = " + z.ToString() + "\n");
            mainLevel.Update(gameTime);
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
            mainLevel.Draw(spriteBatch, gameTime);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
