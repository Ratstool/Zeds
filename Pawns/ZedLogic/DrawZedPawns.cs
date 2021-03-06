﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zeds.Engine;

namespace Zeds.Pawns.ZedLogic
{
    public static class DrawZedPawns
    {
        public static void DrawZeds()
        {
            foreach (var pawn in EntityLists.ZedList)
                if (pawn.IsAlive)
                    Engine.Engine.SpriteBatch.Draw(pawn.Texture, pawn.Position, null, Color.White, pawn.Angle,
                        new Vector2(1.0f * pawn.Texture.Width / 2.0f, 1.0f * pawn.Texture.Height / 2.0f), 1, SpriteEffects.None, 0);
        }
    }
}
 