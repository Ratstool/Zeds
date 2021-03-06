﻿using Microsoft.Xna.Framework;
using Zeds.Engine;
using Zeds.Pawns.HumanLogic;

namespace Zeds.UI.PawnInfoPanel
{
    class SelectedPawn
    {
        private static Vector2 pawnLocation;

        public static Human SelectedHuman;

        public static void SetSelectedPawn(Human pawn)
        {
            SelectedHuman = pawn;
        }

        public static void UpdateIndicator(Human pawn)
        {
            pawnLocation.X = pawn.Position.X;
            pawnLocation.Y = pawn.Position.Y - 25;
        }

        public static void DrawSelectedPawnIndicator()
        {
            foreach (var human in EntityLists.HumanList)
            {
                if (human.IsSelected && human.CurrentHealth > 0)
                    Engine.Engine.SpriteBatch.Draw(Textures.SelectedEntity, pawnLocation, Color.White);
            }
        }
    }
}
