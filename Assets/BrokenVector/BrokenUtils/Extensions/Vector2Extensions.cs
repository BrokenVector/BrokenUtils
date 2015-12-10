using UnityEngine;
using System.Collections;

namespace BrokenVector.BrokenUtils.Extensions
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Adds the IntX-method to Vector2 which returns the x-value as integer.
        /// </summary>
        public static int IntX(this Vector2 vec)
        {
            return (int)vec.x;
        }

        /// <summary>
        /// Adds the IntX-method to Vector2 which returns the y-value as integer.
        /// </summary>
        public static int IntY(this Vector2 vec)
        {
            return (int)vec.y;
        }
    }
}