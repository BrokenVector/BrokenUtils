using UnityEngine;
using System.Collections;

namespace BrokenVector.BrokenUtils.Utils
{
    public class QuaternionUtils
    {
        public static Quaternion ClampAroundXAxis(Quaternion rotation, float min, float max)
        {
            rotation.x /= rotation.w;
            rotation.y /= rotation.w;
            rotation.z /= rotation.w;
            rotation.w = 1;

            float angle = 2f * Mathf.Rad2Deg * Mathf.Atan(rotation.x);
            angle = Mathf.Clamp(angle, min, max);
            rotation.x = Mathf.Tan(.5f * Mathf.Deg2Rad * angle);

            return rotation;
        }

        public static Quaternion ClampAroundYAxis(Quaternion rotation, float min, float max)
        {
            rotation.x /= rotation.w;
            rotation.y /= rotation.w;
            rotation.z /= rotation.w;
            rotation.w = 1;

            float angle = 2f * Mathf.Rad2Deg * Mathf.Atan(rotation.y);
            angle = Mathf.Clamp(angle, min, max);
            rotation.y = Mathf.Tan(.5f * Mathf.Deg2Rad * angle);

            return rotation;
        }

        public static Quaternion ClampAroundZAxis(Quaternion rotation, float min, float max)
        {
            rotation.x /= rotation.w;
            rotation.y /= rotation.w;
            rotation.z /= rotation.w;
            rotation.w = 1;

            float angle = 2f * Mathf.Rad2Deg * Mathf.Atan(rotation.z);
            angle = Mathf.Clamp(angle, min, max);
            rotation.z = Mathf.Tan(.5f * Mathf.Deg2Rad * angle);

            return rotation;
        }
    }
}