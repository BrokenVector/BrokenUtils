using UnityEngine;
using System.Collections;

namespace BrokenVector.BrokenUtils.Shortcuts
{
    /// <summary>
    /// Copys the transform values from one transform to another
    /// </summary>
    public class CopyTransform : MonoBehaviour
    {

        public bool Position;
        public bool Rotation;
        public bool Size;

        public Transform Source;

        void Update()
        {
            if (Position)
                this.transform.position = Source.position;

            if (Rotation)
                this.transform.rotation = Source.rotation;

            if (Size)
                this.transform.localScale = Source.localScale;
        }

    }
}