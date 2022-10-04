
using UnityEngine;
using UnityEditor;

namespace OSM.Utils.Inspector
{
    [CustomPropertyDrawer(typeof(ReadonlyFieldAttribute))]
    public class ReadonlyFieldPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label);
            GUI.enabled = true;
        }
    }
}