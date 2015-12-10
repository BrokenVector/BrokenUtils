using UnityEngine;

namespace BrokenVector.BrokenUtils
{
    /// <summary>
    /// MonoBehaviour which follows an GameObject. (e.g. for Camera Movement)
    /// 
    /// Taken from UnityLabs project
    /// </summary>
    public class FollowObject : MonoBehaviour
    {
        public enum UpdateType { All, Update, LateUpdate, FixedUpdate }     // When the object should be updated.
        public enum FollowType { Both, Position, Rotation }                 // What about the object should be updated.


        public Transform target;                                            // The object to follow.
        public UpdateType updateType = UpdateType.All;                      // When the object is updated.
        public FollowType followType = FollowType.Position;                 // What about the object is updated.
        public float angularSmoothing = 10f;                                // The smoothing for rotation.
        public float linearSmoothing = 1000f;                               // The smoothing for position.


        private Vector3 m_Velocity;                                         // Reference velocity.


        void Update()
        {
            // Move and rotate the object in Update.
            MoveObject(UpdateType.Update);
            RotateObject(UpdateType.Update);
        }


        void LateUpdate()
        {
            // Move and rotate the object in LateUpdate.
            MoveObject(UpdateType.LateUpdate);
            RotateObject(UpdateType.LateUpdate);
        }


        void FixedUpdate()
        {
            // Move and rotate the object in FixedUpdate.
            MoveObject(UpdateType.FixedUpdate);
            RotateObject(UpdateType.FixedUpdate);
        }


        void MoveObject(UpdateType thisUpdate)
        {
            // If the object's position should be updated now, do so with smoothing.
            if (followType == FollowType.Position || followType == FollowType.Both)
                if (updateType == thisUpdate || updateType == UpdateType.All)
                    transform.position = Vector3.SmoothDamp(transform.position, target.position, ref m_Velocity, linearSmoothing);
        }


        void RotateObject(UpdateType thisUpdate)
        {
            // If the object's rotation should be updated now, do so with smoothing.
            if (followType == FollowType.Rotation || followType == FollowType.Both)
                if (updateType == thisUpdate || updateType == UpdateType.All)
                    transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, angularSmoothing * Time.deltaTime);
        }


        public void TeleportToTarget()
        {
            // Set the object's position and rotation based on the target's.
            transform.position = target.position;
            transform.rotation = target.rotation;
        }
    }
}