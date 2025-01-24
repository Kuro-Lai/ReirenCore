using UnityEngine;

namespace ReirenCore.ScriptableObjects
{
    [CreateAssetMenu(menuName = "ReirenCore/Audio Clip")]
    public class SoundReference : ScriptableObject
    {
        public AudioClip Clip;
    }
}