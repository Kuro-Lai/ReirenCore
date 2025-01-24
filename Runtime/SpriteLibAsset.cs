using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.U2D.Animation;

namespace ReirenCore
{

    public class SpriteLibAsset : SpriteLibraryAsset
    {
        /// <summary>
        /// Abgewandelte SpriteLibraryAsset, welche im Editor als Symbol für die Datei anzeigt.
        /// Kategorie: "South Idle", Element: "Entry_0"
        /// </summary>
#if UNITY_EDITOR
        [CustomEditor(typeof(SpriteLibAsset))]
        public class SpriteLibAssetEditor : Editor
        {
            public SpriteLibAsset SpLibAs => target as SpriteLibAsset;

            //public override void OnInspectorGUI()
            //{
            //    EditorGUI.BeginChangeCheck();
            //    base.OnInspectorGUI();
            //    if (EditorGUI.EndChangeCheck())
            //    {
            //        SceneView.RepaintAll();
            //    }
            //}

            /// <summary>
            /// Renders a static preview Texture2D for a RuleTile asset
            /// </summary>
            /// <param name="assetPath">Asset path of the RuleTile</param>
            /// <param name="subAssets">Arrays of assets from the given Asset path</param>
            /// <param name="width">Width of the static preview</param>
            /// <param name="height">Height of the static preview </param>
            /// <returns>Texture2D containing static preview for the RuleTile asset</returns>
            public override Texture2D RenderStaticPreview(string assetPath, UnityEngine.Object[] subAssets, int width, int height)
            {
                Sprite val = SpLibAs.GetSprite("South Idle", "Entry_0");
                if (val != null)
                {
                    Type t = GetType("UnityEditor.SpriteUtility");
                    if (t != null)
                    {
                        MethodInfo method = t.GetMethod("RenderStaticPreview", new[] { typeof(Sprite), typeof(Color), typeof(int), typeof(int) });
                        if (method != null)
                        {
                            object ret = method.Invoke("RenderStaticPreview", new object[] { val, Color.white, width, height });
                            if (ret is Texture2D)
                                return ret as Texture2D;
                        }
                    }
                }
                return base.RenderStaticPreview(assetPath, subAssets, width, height);
            }

            private static Type GetType(string typeName)
            {
                var type = Type.GetType(typeName);
                if (type != null)
                    return type;

                var currentAssembly = Assembly.GetExecutingAssembly();
                var referencedAssemblies = currentAssembly.GetReferencedAssemblies();
                foreach (var assemblyName in referencedAssemblies)
                {
                    var assembly = Assembly.Load(assemblyName);
                    if (assembly != null)
                    {
                        type = assembly.GetType(typeName);
                        if (type != null)
                            return type;
                    }
                }
                return null;
            }

        }
#endif
    }
}