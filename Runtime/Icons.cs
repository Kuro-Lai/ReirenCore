using UnityEditor;
using UnityEngine.UIElements;

namespace Reiren.Core.Icons
{
    using ExtensionMethods;
    /// <summary>
    /// d_FilterByType<br/>
    /// Dreieck nach unten Symbol. 
    /// </summary>
    public class ImageSelector : Image
    {
        public ImageSelector()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_FilterByType").ToSprite();
        }
    }
    /// <summary>
    /// Toolbar Plus
    /// </summary>
    public class ImageAdd : Image
    {
        public ImageAdd()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("Toolbar Plus").ToSprite();
        }
    }
    /// <summary>
    /// Toolbar Minus
    /// </summary>
    public class ImageRemove : Image
    {
        public ImageRemove()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("Toolbar Minus").ToSprite();
        }
    }
    /// <summary>
    /// CollabConflict
    /// </summary>
    public class ImageError : Image
    {
        public ImageError()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("CollabConflict").ToSprite();
        }
    }
    /// <summary>
    /// MetadataON
    /// </summary>
    public class ImageArg : Image
    {
        public ImageArg()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("MetadataON").ToSprite();
        }
    }
    /// <summary>
    /// d_winbtn_win_close<b\>
    /// Kreuz
    /// </summary>
    public class ImageClose : Image
    {
        public ImageClose()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_winbtn_win_close").ToSprite();
        }
    }
    /// <summary>
    /// d_PlayButton<b\>
    /// </summary>
    public class ImagePlay : Image
    {
        public ImagePlay()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_PlayButton").ToSprite();
        }
    }
    /// <summary>
    /// d_PreMatQuad<b\>
    /// Audio Pause
    /// </summary>
    public class ImagPause : Image
    {
        public ImagPause()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_PreMatQuad").ToSprite();
        }
    }
}

