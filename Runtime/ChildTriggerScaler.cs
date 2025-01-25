using UnityEngine;

namespace Reiren.Core
{
    /// <summary>
    /// Scalliert alle Childs mit einem Offsetverhältnis um berührende Triggerfunktionen zu vermeiden
    /// </summary>
    [ExecuteInEditMode]
    public class ChildTriggerScaler : MonoBehaviour
    {
        public int Gridsize = 16;
        public int Offset = 1;
#if UNITY_EDITOR
        void Update()
        {
            if (transform.hasChanged)
            {
                transform.hasChanged = false;
                Vector3 Parentscale = transform.localScale;
                foreach (Transform child in transform)
                {
                    child.transform.localScale = new Vector3()
                    {
                        x = Parentscale.x == 0 ? 0 : ((Parentscale.x * Gridsize - Offset * 2) / (Gridsize * Parentscale.x)),
                        y = Parentscale.y == 0 ? 0 : ((Parentscale.y * Gridsize - Offset * 2) / (Gridsize * Parentscale.y)),
                        z = Parentscale.z
                    };
                }
            }
        }
#endif
    }
}
