using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BundleModuleData
{
    //assetbundle模块id   
    public long bundleId;
    
    //模块名
    public string moduleName;

    //是否打包
    public bool isBuild;

    //上一次点击按钮的事件
    public float lstClickBtnTime;
}
