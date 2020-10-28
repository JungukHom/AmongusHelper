namespace Marucorp.AmongusHelper
{
    // C#
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    // Unity
    using UnityEngine;
    using UnityEngine.UI;

    // Project
    // Alias

    public class ImageHolder : MonoBehaviour
    {
        // Empty Image
        [Header("Empty Image")]
        public Sprite empty;

        // Crewmate Images
        [Header("Crewmate Images")]
        public Sprite red;
        public Sprite yellow;
        public Sprite orange;

        public Sprite green;
        public Sprite blue;
        public Sprite purple;

        public Sprite black;
        public Sprite brown;
        public Sprite cyan;

        public Sprite lime;
        public Sprite pink;
        public Sprite white;


        // Map Images
        [Header("Map Images")]
        public Sprite skeld;
        public Sprite miraHq;
        public Sprite polus;


        // Identifier Images
        [Header("Identifier Imges")]
        public Sprite questionMark;
        public Sprite safeMark;
        public Sprite deadMark;


        // Class Instance
        public static ImageHolder instance;

        private void Awake()
        {
            instance = this;
        }


        public Sprite GetEmptyImage()
        {
            return empty;
        }


        public Sprite GetCrewmateImageWithEnum(PlayerColor color)
        {
            switch (color)
            {
                case PlayerColor.Red:
                    return red;
                case PlayerColor.Yellow:
                    return yellow;
                case PlayerColor.Orange:
                    return orange;

                case PlayerColor.Green:
                    return green;
                case PlayerColor.Blue:
                    return blue;
                case PlayerColor.Purple:
                    return purple;

                case PlayerColor.Black:
                    return black;
                case PlayerColor.Brown:
                    return brown;
                case PlayerColor.Cyan:
                    return cyan;

                case PlayerColor.Lime:
                    return lime;
                case PlayerColor.Pink:
                    return pink;
                case PlayerColor.White:
                    return white;

                default:
                    return empty;
            }
        }

        public Sprite GetMapImageWithEnum(MapName name)
        {
            switch (name)
            {
                case MapName.THE_SKELD:
                    return skeld;
                case MapName.MIRA_HQ:
                    return miraHq;
                case MapName.POLUS:
                    return polus;

                default:
                    return empty;
            }
        }

        public Sprite GetQuestionImage()
        {
            return questionMark;
        }

        public Sprite GetSafeImage()
        {
            return safeMark;
        }

        public Sprite GetDeadImage()
        {
            return deadMark;
        }
    }
}