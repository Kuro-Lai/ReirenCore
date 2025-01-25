using UnityEngine;

namespace Reiren.Core.ScriptableObjects
{
    [CreateAssetMenu(menuName = "ReirenCore/Audio Clip")]
    public class SoundReference : ScriptableObject
    {
        public AudioClip Clip;
    }
}