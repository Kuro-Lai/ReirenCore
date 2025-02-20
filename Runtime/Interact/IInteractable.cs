using Reiren.Core.Interact;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reiren.Core.Interact
{
    public interface IInteractable
    {
        public string InteractionPromt { get; }
        public bool Interact(Interactor interactor);
        public bool Interact(Interactor interactor, GameObject gameObject);
    }
}
