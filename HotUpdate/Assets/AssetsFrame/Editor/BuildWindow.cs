using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

public class BuildWindow : OdinMenuEditorWindow
{
    [SerializeField]
    public BuildBundleWindow buildBundleWindow = new BuildBundleWindow();
    
    [MenuItem("FrameWork/AssetBundle")]
    public static void ShowAssetBundleWindow()
    {
        BuildWindow window = GetWindow<BuildWindow>();
        window.position = GUIHelper.GetEditorWindowRect().AlignCenter(958, 612);
        window.ForceMenuTreeRebuild();
    }
    
    protected override OdinMenuTree BuildMenuTree()
    {
        OdinMenuTree menuTree = new OdinMenuTree(supportsMultiSelect: false)
        {
            { "Build", null, EditorIcons.House },
            {"AssetBundle", buildBundleWindow, EditorIcons.UnityLogo}
        };
        return menuTree;
    }
}
