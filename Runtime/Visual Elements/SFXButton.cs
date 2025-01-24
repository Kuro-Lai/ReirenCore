using UnityEngine;
using UnityEngine.UIElements;

namespace ReirenCore.VisualElmenents
{
    using Icons;
    /// <summary>
    /// AudioClip Filed mit einem Play Audio Button.
    /// </summary>
    public class SFXButton : Button
    {
        /// <summary>
        /// Audio Clip
        /// </summary>
        public AudioClip audioClip;
        /// <summary>
        /// Gibt an, ob ein Clip abgespielt wird.
        /// </summary>
        public bool PlayButton = true;
        public SFXButton()
        {
            styleSheets.Add(Resources.Load<StyleSheet>("SFXButton"));
            Image image = new();
            image.AddToClassList("Image");
            Add(image);
            if (PlayButton)
                image.sprite = new ImagePlay().sprite; // EditorGUIUtility.FindTexture("d_PlayButton").ToSprite();
            //image.sprite = EditorGUIUtility.FindTexture("d_preAudioPlayOff").ToSprite();
            else
                image.sprite = new ImagPause().sprite; // EditorGUIUtility.FindTexture("d_PreMatQuad").ToSprite();
            this.RegisterCallback<ClickEvent>(OnBoxClicked);
        }

        private void OnBoxClicked(ClickEvent evt)
        {
            if (audioClip != null && PlayButton)
                EditorSFX.PlayClip(audioClip);
            else if (audioClip != null && !PlayButton)
                EditorSFX.StopAllClips();
        }
    }
}