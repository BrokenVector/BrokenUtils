using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BrokenVector.BrokenUtils
{
	public static class MathUtils 
	{
        /// <summary>
        /// Clamps an angle between the given values.
        /// </summary>
        /// Taken from wydoidoit's code on Unity Answers http://answers.unity3d.com/questions/659932/how-do-i-clamp-my-rotation.html
        public static float ClampAngle(float angle, float min, float max)
        {
            angle = Mathf.Repeat(angle, 360);
            min = Mathf.Repeat(min, 360);
            max = Mathf.Repeat(max, 360);
            bool inverse = false;
            float tmin = min;
            float tangle = angle;
            if (min > 180)
            {
                inverse = !inverse;
                tmin -= 180;
            }
            if (angle > 180)
            {
                inverse = !inverse;
                tangle -= 180;
            }
            bool result = !inverse ? tangle > tmin : tangle < tmin;
            if (!result) angle = min;

            inverse = false;
            tangle = angle;
            float tmax = max;
            if (angle > 180)
            {
                inverse = !inverse;
                tangle -= 180;
            }
            if (max > 180)
            {
                inverse = !inverse;
                tmax -= 180;
            }

            result = !inverse ? tangle < tmax : tangle > tmax;
            if (!result) angle = max;
            return angle;
        }
    }
}