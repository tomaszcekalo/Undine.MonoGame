using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.MonoGame
{
    public class KeyBinding
    {
        public string KeyAction { get; set; }
        public Keys Key { get; set; }
        public bool IsDown { get; set; }
        public bool IsPressed { get; set; }
        public bool IsReleased { get; set; }
    }
}