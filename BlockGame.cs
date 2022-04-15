using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameProject5
{
    public class BlockGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Block[] blocks;

        public BlockGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            blocks = new Block[] {
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, 5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, 3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, 1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, 7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -9)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -11)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -13)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -15)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -17)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -19)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(4, 0, -21)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, 5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, 3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, 1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, 7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -9)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -11)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -13)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -15)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -17)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -19)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(2, 0, -21)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, 5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, 3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, 1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, 7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -9)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -11)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -13)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -15)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -17)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -19)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(0, 0, -21)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, 5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, 3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, 1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, 7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, -1)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, -3)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, -5)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, -7)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, -9)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, -11)),
                new Block(this, BlockType.Dirt, Matrix.CreateTranslation(6, 0, -13)),
                        new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, 5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, 3)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, 1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, 7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -3)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -9)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -11)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -13)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -15)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -17)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -19)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 0, -21)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, 5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, 3)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, 1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, 7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -3)),
                new Block(this, BlockType.GoldOre, Matrix.CreateTranslation(-2, 2, -5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -9)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -11)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -13)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -15)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -17)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -19)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-2, 2, -21)),
                new Block(this, BlockType.WhiteOre, Matrix.CreateTranslation(-4, 4, 5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, 3)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, 1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, 7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -3)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -9)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -11)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -13)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -15)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -17)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -19)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 4, -21)),
               new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, 5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, 3)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, 1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, 7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -1)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -3)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -5)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -9)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -11)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -13)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -15)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -17)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -19)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 6, -21)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 0, 7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-4, 2, 7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-6, 0, 7)),
                new Block(this, BlockType.Stone, Matrix.CreateTranslation(-6, 2, 7)),
            };
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            foreach (Block block in blocks)
            {
                block.Draw();
            }


            base.Draw(gameTime);
        }
    }
}
