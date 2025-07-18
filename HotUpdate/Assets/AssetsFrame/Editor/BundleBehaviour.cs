using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class BundleBehaviour
{
    /// <summary>
    /// 模块配置列表
    /// </summary>
    protected List<BundleModuleData> moduleDataList;

    /// <summary>
    /// 模块配置行列表
    /// </summary>
    protected List<List<BundleModuleData>> rowMoudleDataList;

    public virtual void Initialization()
    {
        moduleDataList = BuildBundleConfigura.Instance.AssetBundleConfig;
        rowMoudleDataList = new List<List<BundleModuleData>>();

        for (int i = 0; i < moduleDataList.Count; i++)
        {
            //计算模块绘制的行数索引
            int rowIndex = Mathf.FloorToInt(i / 6);
            if (rowMoudleDataList.Count < rowIndex + 1)
            {
                rowMoudleDataList.Add(new List<BundleModuleData>());
            }
            //将模块数据添加到对应的行列表中
            rowMoudleDataList[rowIndex].Add(moduleDataList[i]);
        }
    }

    [OnInspectorGUI]
    public virtual void OnGUI()
    {
        if(rowMoudleDataList == null)
            return;
        foreach (var moduleDataList in rowMoudleDataList)
        {
            //开始横向绘制
            GUILayout.BeginVertical();
            foreach (var bundleModuleData in moduleDataList)
            {
                if (GUILayout.Button("123", GUILayout.Width(130), GUILayout.Height(170)))
                {
                    
                }
            }
            //结束横向绘制
            GUILayout.EndHorizontal();
        }
    }
}
