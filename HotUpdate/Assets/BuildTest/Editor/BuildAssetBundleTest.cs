using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildAssetBundleTest : MonoBehaviour
{
       private static string bundleOutPutPath {get{ return Application.dataPath + "/../AssetBundle";} }

       [MenuItem("FrameWork/BuildAssetBundle")]
       public static void BuildAssetBundle()
       {
              if (!Directory.Exists(bundleOutPutPath))
              {
                     Directory.CreateDirectory(bundleOutPutPath);
              }

              BuildPipeline.BuildAssetBundles(bundleOutPutPath, BuildAssetBundleOptions.ChunkBasedCompression,
                     BuildTarget.Android);
       }
}
