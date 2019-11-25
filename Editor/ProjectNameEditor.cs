using UnityEditor;

namespace Uma
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ProjectName))]
    public class ProjectNameEditor : Editor
    {
        SerializedProperty _mode;

        void OnEnable()
        {
            _mode = serializedObject.FindProperty("_mode");

        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_mode);
            serializedObject.ApplyModifiedProperties();
        }
    }
}

