using UnityEngine;
using System.Collections;
using BrokenVector.BrokenUtils.Extensions;

namespace BrokenVector.BrokenUtils
{
    /// <summary>
    /// Changes the particlesystem color, to the color of a texture. (Useful for creating mud particles)
    /// </summary>
    [RequireComponent(typeof(ParticleSystem)), DisallowMultipleComponent]
    public class ParticleColorPicker : MonoBehaviour
    {

        public Vector3 RayDirection = Vector3.zero;
        public float MaxRayDistance = 5f;
        public LayerMask Mask;

        private ParticleSystem particleSystem;

        void Start()
        {
            particleSystem = this.GetComponent<ParticleSystem>();
        }

        void Update()
        {
            var ray = new Ray(this.transform.position, RayDirection);
            var result = new RaycastHit();

            Physics.Raycast(ray, out result, MaxRayDistance, Mask.value);
            if (result.collider == null)
                return;

            var go = result.collider.gameObject;

            var renderer = go.GetComponent<MeshRenderer>();
            if (renderer == null || renderer.material == null || renderer.material.mainTexture == null)
                return;

            Texture2D tex = (Texture2D)renderer.material.mainTexture;
            Color color = tex.GetPixelBilinear(result.textureCoord.IntX(), result.textureCoord.IntY());
            if (color == null)
                return;

            particleSystem.startColor = color;
        }
    }
}