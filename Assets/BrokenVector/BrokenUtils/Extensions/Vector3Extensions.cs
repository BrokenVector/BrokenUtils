using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BrokenVector.BrokenUtils.Extensions
{
	public static class Vector3Extensions
	{

        public static Vector3 Clamp(this Vector3 vector, Vector3 min, Vector3 max)
        {
            var x = vector.x;
            x = (x < min.x) ? min.x : x;
            x = (x > max.x) ? max.x : x;

            var y = vector.y;
            y = (y < min.y) ? min.y : y;
            y = (y > max.y) ? max.y : y;

            var z = vector.z;
            z = (z < min.z) ? min.z : z;
            z = (z > max.z) ? max.z : z;

            return new Vector3(x, y, z);
        }

    }
}