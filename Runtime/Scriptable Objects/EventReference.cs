using System;
using UnityEngine;

namespace ReirenCore.ScriptableObjects
{
    [CreateAssetMenu(menuName = "ReirenCore/Event Reference")]
    public class EventReference : ScriptableObject
    {
        public EventHandler<ScriptArgs> Event;
        /// <summary>
        /// Rückmeldeinformationen des Events
        /// </summary>
        public class ScriptArgs : EventArgs
        {
            /// <summary>
            /// <see langword="true"/> = Prozess abgeschlossen
            /// </summary>
            public bool m_Status;
            /// <summary>
            /// optionaler Zusatztext 
            /// </summary>
            public string m_Zusatztext;
            /// <summary>
            /// optionales GameObject
            /// </summary>
            public GameObject m_GameObject;
        }
    }
}