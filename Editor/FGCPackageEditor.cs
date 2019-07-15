using UnityEditor;
using UnityEngine;

public class FGCPackageEditor : EditorWindow
{  
    private static Vector2 WindowSize = new Vector2(400, 600);
    
    [MenuItem("Synergy88/FGC/Essential")]
    public static void Init()
    {
        var window =  GetWindow<FGCPackageEditor>(true);
        window.minSize = WindowSize;
        window.maxSize = WindowSize;
        window.Show();
        window.InitializeWindow();

    }

    private void InitializeWindow()
    {
        var file = MonoScript.FromScriptableObject(this);
        var dir = AssetDatabase.GetAssetPath(file);
        var path = Application.dataPath;
        var dirMod = $"{dir}/../";
        Debug.LogError(dirMod);
    }

}
