using System.Collections;
using System.Collections.Generic;
# if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[CreateAssetMenu(menuName = "AssetBundle", fileName = "BuildBundleConfigura", order = 4)]
public class BuildBundleConfigura : ScriptableObject
{
    private static BuildBundleConfigura _instance;

    public static BuildBundleConfigura Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = AssetDatabase.LoadAssetAtPath<BuildBundleConfigura>("Asset/AssetsFrame/Config/BuildBundleConfigura.asset");
            }
            return _instance;
        }
    }
    
    //assetbundle模块数据
    [SerializeField]
    public List<BundleModuleData> AssetBundleConfig = new List<BundleModuleData>();
    
}
