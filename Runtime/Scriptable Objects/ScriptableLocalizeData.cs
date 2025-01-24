using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

#if UNITY_EDITOR
using UnityEditor;
using System;
using System.Reflection;
#endif
namespace ReirenCore.ScriptableObjects
{


    /// <summary>
    /// Stellt Basisinformationen als Scriptable Object mit Localize Funktion zur Verfügung.
    /// </summary>
    public class ScriptableLocalizeData : ScriptableObject
    {
        /// <summary>
        /// Key Value mit dem die Lokalize Abruf in der hinterlegten Tabelle durchgeführt wird.
        /// </summary>
        public string LocalizeKey = "";
        /// <summary>
        /// Localizetabelle in welcher der Keybegriff gesucht wird für die Bezeichnung oder Text des Objektes
        /// </summary>
        public TableReference TRef_Texte;
        /// <summary>
        /// Localizetabelle in welcher der Keybegriff gesucht wird für Assetdaten
        /// </summary>
        public TableReference TRef_Assets;
        /// <summary>
        /// Iconbild. Wird zusätzlich im Editor als Dateisymbol genutzt.
        /// </summary>
        public Sprite Icon;
        /// <summary>
        /// Kategorie
        /// </summary>
        public string Kategorie;


        /// <summary>
        /// Gibt den Text/Bezeichnung des Objektes anhand der aktuellen Localizeumgebung zurück.<br/>
        /// Wenn im <see cref="LocalizeKey"/> das erste Zeichen "$" ist, wird stattdessen der Localize Key ohne das Zeichen zurückgegeben.<br/>
        /// The string will first be formatted with <see cref="SmartArgs"/> if <see cref="StringTableEntry.IsSmart"/> is enabled otherwise it will use String.Format.
        /// </summary>
        /// <param name="arguments">Arguments passed to SmartFormat or String.Format.</param>
        /// <returns></returns>
        public string GetBezeichnung(params object[] arguments)
        {
            if (LocalizeKey.Length >= 1 && LocalizeKey[0] == '$')
            {
                return LocalizeKey[1..];
            }
            if (TRef_Texte == null) return "! Missing Table Ref !";
            return LocalizationSettings.StringDatabase.GetLocalizedString(TRef_Texte, LocalizeKey, arguments);
        }
        /// <summary>
        /// Gibt das Asset des Objektes anhand der aktuellen Localizeumgebung zurück.<br/>
        /// wenn im Localizekey das erste Zeichen "$" ist, wird stattdessen <see langword="null"/> zurückgegeben.
        /// </summary>
        /// <typeparam name="TObject">The type of asset that should be loaded.</typeparam>
        /// <returns></returns>
        public TObject GetLocalizeAsset<TObject>() where TObject : UnityEngine.Object
        {
            if (LocalizeKey.Length >= 1 && LocalizeKey[0] == '$')
            {
                return null;
            }
            if (TRef_Assets == null) return null;
            return LocalizationSettings.AssetDatabase.GetLocalizedAsset<TObject>(TRef_Assets, LocalizeKey, null);
        }
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(ScriptableLocalizeData))]
    public class ScriptableLocalizeDataEditor : Editor
    {
        public ScriptableLocalizeData MB => target as ScriptableLocalizeData;

        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            base.OnInspectorGUI();
            if (EditorGUI.EndChangeCheck())
            {
                SceneView.RepaintAll();
            }
        }

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
            if (MB.Icon != null)
            {
                Type t = GetType("UnityEditor.SpriteUtility");
                if (t != null)
                {
                    MethodInfo method = t.GetMethod("RenderStaticPreview", new[] { typeof(Sprite), typeof(Color), typeof(int), typeof(int) });
                    if (method != null)
                    {
                        object ret = method.Invoke("RenderStaticPreview", new object[] { MB.Icon, Color.white, width, height });
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
}
#endif