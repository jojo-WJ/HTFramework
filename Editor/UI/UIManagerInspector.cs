﻿using UnityEditor;
using UnityEngine;

namespace HT.Framework
{
    [CustomEditor(typeof(UIManager))]
    public sealed class UIManagerInspector : Editor
    {
        private UIManager _target;

        private void OnEnable()
        {
            _target = target as UIManager;
        }

        public override void OnInspectorGUI()
        {
            GUILayout.BeginHorizontal();
            EditorGUILayout.HelpBox("UI Manager, Control all UILogic Entity!", MessageType.Info);
            GUILayout.EndHorizontal();
        }
    }
}
