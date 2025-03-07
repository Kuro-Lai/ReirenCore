using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace Reiren.Core.Interact
{
    public class InteractionPromptUI : MonoBehaviour
    {
        private Camera _mainCam;
        [SerializeField] private GameObject _uiPanel;
        [SerializeField] private TextMeshProUGUI _promtText;
        public bool IsDisplayed = false;

        private void Start()
        {
            _mainCam = Camera.main;
            _uiPanel.SetActive(false);
            IsDisplayed = false;
        }

        private void LateUpdate()
        {
            var rotation = _mainCam.transform.rotation;
            transform.LookAt(transform.position + rotation* Vector3.forward, rotation * Vector3.up);
        }

        public void SetUp(string promtText)
        {
            _promtText.text = promtText;
            _uiPanel.SetActive(true);
            IsDisplayed = true;
        }

        public void Close()
        {
            _uiPanel.SetActive(false);
            IsDisplayed = false;
        }

    }
}
