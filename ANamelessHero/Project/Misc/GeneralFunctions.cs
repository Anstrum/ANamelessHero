using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace ANamelessHero
{

    internal static class GeneralFunctions
    {
        public static GraphicsDeviceManager Graphics;
        public static ContentManager Content;
        public static GameTime GameTime;
        public static GraphicsDevice GraphicsDevice;
        public static void Init(GraphicsDeviceManager _graphics, ContentManager _content, GraphicsDevice _graphicsDevice)
        {
            Graphics = _graphics;
            Content = _content;
            GraphicsDevice = _graphicsDevice;
        }
    }

}
