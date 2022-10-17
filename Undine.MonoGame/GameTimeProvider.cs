using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.MonoGame
{
    public interface IGameTimeProvider
    {
        GameTime GameTime { get; set; }
    }

    public class GameTimeProvider : IGameTimeProvider
    {
        public GameTime GameTime { get; set; }
    }
}