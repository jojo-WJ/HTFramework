﻿using UnityEngine;

namespace HT.Framework
{
    /// <summary>
    /// HT.Framework编辑器配置表
    /// </summary>
    public static class EditorPrefsTable
    {
        #region EditorGlobalTools
        /// <summary>
        /// 新建Helper脚本的文件夹
        /// </summary>
        public static string Script_Helper_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.Helper";
            }
        }
        /// <summary>
        /// 新建FiniteState脚本的文件夹
        /// </summary>
        public static string Script_FiniteState_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.FiniteState";
            }
        }
        /// <summary>
        /// 新建Procedure脚本的文件夹
        /// </summary>
        public static string Script_Procedure_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.Procedure";
            }
        }
        /// <summary>
        /// 新建EventHandler脚本的文件夹
        /// </summary>
        public static string Script_EventHandler_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.EventHandler";
            }
        }
        /// <summary>
        /// 新建AspectProxy脚本的文件夹
        /// </summary>
        public static string Script_AspectProxy_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.AspectProxy";
            }
        }
        /// <summary>
        /// 新建UILogicResident脚本的文件夹
        /// </summary>
        public static string Script_UILogicResident_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.UILogicResident";
            }
        }
        /// <summary>
        /// 新建UILogicTemporary脚本的文件夹
        /// </summary>
        public static string Script_UILogicTemporary_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.UILogicTemporary";
            }
        }
        /// <summary>
        /// 新建DataSet脚本的文件夹
        /// </summary>
        public static string Script_DataSet_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.DataSet";
            }
        }
        /// <summary>
        /// 新建HotfixProcedure脚本的文件夹
        /// </summary>
        public static string Script_HotfixProcedure_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.HotfixProcedure";
            }
        }
        /// <summary>
        /// 新建HotfixObject脚本的文件夹
        /// </summary>
        public static string Script_HotfixObject_Directory
        {
            get
            {
                return Application.productName + ".HT.Framework.Script.HotfixObject";
            }
        }
        #endregion

        #region AssetBundleEditor
        /// <summary>
        /// AssetBundleEditor打包路径
        /// </summary>
        public static string AssetBundleEditor_BuildPath
        {
            get
            {
                return Application.productName + ".HT.Framework.AssetBundleEditor.BuildPath";
            }
        }
        /// <summary>
        /// AssetBundleEditor打包平台
        /// </summary>
        public static string AssetBundleEditor_BuildTarget
        {
            get
            {
                return Application.productName + ".HT.Framework.AssetBundleEditor.BuildTarget";
            }
        }
        /// <summary>
        /// AssetBundleEditor打包变体设置
        /// </summary>
        public static string AssetBundleEditor_Variant
        {
            get
            {
                return Application.productName + ".HT.Framework.AssetBundleEditor.Variant";
            }
        }
        #endregion
    }
}
