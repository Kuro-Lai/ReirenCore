using System;
using UnityEngine;

namespace Reiren.Core.Icons
{
    using ExtensionMethods;
    /// <summary>
    /// Bilder welche keine ohne Asset generiert werden können
    /// </summary>
    static public partial class StringIcons
    {
        /// <summary>
        /// Generiert ein Sprite anhand eines Base64String
        /// </summary>
        /// <param name="Base64String"></param>
        /// <returns></returns>
        public static Sprite GetSprite(string Base64String)
        {
            Texture2D Tex = new Texture2D(16, 16);
            Tex.LoadImage(Convert.FromBase64String(Base64String));
            return Tex.ToSprite();
        }
    }



}

