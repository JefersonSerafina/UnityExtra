using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateGameObjectButton : EditorWindow
{
    [MenuItem("Tools/Create GameObject")]
    public static void ShowWindow()
    {
        GetWindow<CreateGameObjectButton>("Create GameObject");
    }

    private void OnGUI()
    {
        GUILayout.Label("Clique no bot�o para criar um novo GameObject:");

        if (GUILayout.Button("Criar GameObject"))
        {
            GameObject newObject = new GameObject("NovoGameObject");
        }
    }
}