using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

// from http://answers.unity3d.com/questions/489942/how-to-make-a-readonly-property-in-inspector.html
namespace BrokenVector.BrokenUtils
{
    /// <summary>
    /// Use this attribute, to mark a value as read only.
    /// The variable will still be changeable by code, but not in the inspector.
    /// </summary>
    public class ReadOnlyAttribute : PropertyAttribute
    {

    }

#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label, true);
            GUI.enabled = true;
        }
    }
#endif
}