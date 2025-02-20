using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Reiren.Core.Interact
{
    public class Interactor : MonoBehaviour
    {
        [SerializeField] private Transform _interactablePoint;
        [SerializeField] private float _interactablePointRadius;
        [SerializeField] private LayerMask _interactableMask;
        [SerializeField] private InteractionPromptUI _interactionPromptUI;
        [SerializeField] GameObject _interactableObject;

        [SerializeField] private bool _2DSystem;

        private readonly Collider[] _colliders = new Collider[3];
        private readonly Collider2D[] _colliders2D = new Collider2D[3];
        [SerializeField] private int _numFounds;


        private IInteractable _interactable = null;
        private PlayerInputActions _actions;



        private void Awake()
        {
            _actions = new PlayerInputActions();
            _actions.Player.Interact.performed += InputInteract;
        }

        // Update is called once per frame
        void Update()
        {
            if (_2DSystem)
            {
                _numFounds = Physics2D.OverlapCircleNonAlloc(_interactablePoint.position, _interactablePointRadius, _colliders2D, _interactableMask);
            }
            else
            {
                _numFounds = Physics.OverlapSphereNonAlloc(_interactablePoint.position, _interactablePointRadius, _colliders, _interactableMask);
            }

            if (_numFounds > 0)
            {
                if (_2DSystem)
                {
                    _interactable = _colliders2D[0].GetComponent<IInteractable>();
                }
                else
                {
                    _interactable = _colliders[0].GetComponent<IInteractable>();
                }
                if (_interactable != null)
                {
                    if(_interactionPromptUI != null & !_interactionPromptUI.IsDisplayed)
                    {
                        _interactionPromptUI.SetUp(_interactable.InteractionPromt);
                    }
                }
            }
            else
            {
                if(_interactable != null) _interactable = null;
                if(_interactionPromptUI != null & _interactionPromptUI.IsDisplayed) _interactionPromptUI.Close();
            }
        }


        private void InputInteract(InputAction.CallbackContext context)
        {
            if(_interactable != null)
            {
                _interactable.Interact(this);
                _interactable.Interact(this, gameObject);
            }
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(_interactablePoint.position, _interactablePointRadius);
        }
    }
}
