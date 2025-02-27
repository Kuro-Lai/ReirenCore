using Reiren.Core.Interact;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Reiren.Core.Interact
{
    public class InteractEvent : MonoBehaviour, IInteractable
    {
        [SerializeField] private string _promt;
        public string InteractionPromt => _promt;

        public UnityEvent _event;
        public UnityEvent<GameObject> _event2;

        public bool Interact(Interactor interactor, GameObject gameObject)
        {
            Debug.Log($"Interacted with Object: {transform.name}");
            _event.Invoke();
            _event2.Invoke(gameObject);
            return true;
        }
    }
}
