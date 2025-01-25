using UnityEngine;

namespace Reiren.Core.ScriptableObjects
{
    [CreateAssetMenu(menuName = "ReirenCore/Sprite")]
    public class SpriteReference : ScriptableObject
    {
        public Sprite Sprite;
    }
}