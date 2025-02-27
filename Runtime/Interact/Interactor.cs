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

        [Tooltip("Use the Physics2D Engine instead of Physics")]
        [SerializeField] private bool _2DSystem;
        [Tooltip("Only include objects with a Z coordinate (depth) greater than or equal to this value.")]
        [SerializeField] private float _2D_Zmin = -Mathf.Infinity;
        [Tooltip("Only include objects with a Z coordinate (depth) less than or equal to this value.")]
        [SerializeField] private float _2D_Zmax = Mathf.Infinity;

        private readonly Collider[] _colliders = new Collider[3];
        private readonly Collider2D[] _colliders2D = new Collider2D[3];
        [SerializeField] private int _numFounds;


        private IInteractable _interactable = null;
        private PlayerInputActions _actions;

        public void Set2Ddepth(float zmin, float zmax)
        {
            _2D_Zmin -= zmin;
            _2D_Zmax -= zmax;
        }

        private void Awake()
        {
            _actions = new PlayerInputActions();
            _actions.Player.Interact.performed += InputInteract;
            _actions.Enable();
        }

        // Update is called once per frame
        void Update()
        {
            if (_2DSystem)
            {
                _numFounds = Physics2D.OverlapCircleNonAlloc(_interactablePoint.position, _interactablePointRadius, _colliders2D, _interactableMask, _2D_Zmin, _2D_Zmax);
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
                if(_interactableObject == null)
                    _interactable.Interact(this, this.gameObject);
                else
                    _interactable.Interact(this, _interactableObject);
            }
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(_interactablePoint.position, _interactablePointRadius);
        }
    }
}
