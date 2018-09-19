using UnityEditor;
using UnityEngine;

public static class EditorMenus
{
    [MenuItem("Test menu/Do the thing")]
    public static void LogThing()
    {
        Debug.Log("pressed the button");
    }
}
