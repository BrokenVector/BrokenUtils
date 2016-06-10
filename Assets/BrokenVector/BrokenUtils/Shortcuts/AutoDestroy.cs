using UnityEngine;
using System.Collections;

namespace BrokenVector.BrokenUtils.Shortcuts
{
    /// <summary>
    /// Destroys the GameObject after a certain time (in seconds)
    /// </summary>
    public class AutoDestroy : MonoBehaviour
    {
        public float Time;

        void Start()
        {
            Destroy(this.gameObject, Time);
        }

    }
}