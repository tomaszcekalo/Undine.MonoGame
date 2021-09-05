using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.MonoGame
{
    public class KeyboardSystem : UnifiedSystem<KeyboardComponent>
    {
        private KeyboardState state;
        private KeyboardState previousState;

        public override void ProcessSingleEntity(int entityId, ref KeyboardComponent t)
        {
            foreach (var binding in t.Bindings)
            {
                binding.IsDown = state.IsKeyDown(binding.Key);
                binding.IsPressed = !binding.IsDown && previousState.IsKeyUp(binding.Key);
                binding.IsReleased = binding.IsDown && previousState.IsKeyDown(binding.Key);
            }
        }

        public override void PreProcess()
        {
            //save state
            previousState = state;
            //do work
            state = Keyboard.GetState();
        }
    }
}