using System.IO;
using UnityEditor;
using UnityEngine;

public static class FoobarMagic
{
    [MenuItem("Foobar/Magic")]
    private static void CreateScript_1()
    {
        DoMagic();
    }

    private static void DoMagic()
    {
        var scriptAssetPath = AssetDatabase.GUIDToAssetPath(
            AssetDatabase.FindAssets($"t:Script {nameof(FoobarMagic)}")[0]
        );

        Debug.Log(scriptAssetPath);

        var scriptAssetAbsolutePath = Path.Combine(Application.dataPath, "..", scriptAssetPath);
        var scriptAssetAbsolutePathNormalized = Path.GetFullPath(scriptAssetAbsolutePath);

        Debug.Log(scriptAssetAbsolutePath);
        Debug.Log(scriptAssetAbsolutePathNormalized);

        var t1 = File.ReadAllText(scriptAssetAbsolutePath);
        var t2 = File.ReadAllText(scriptAssetAbsolutePathNormalized);

        Debug.Log(t1);
        Debug.Log(t2);
    }
}
