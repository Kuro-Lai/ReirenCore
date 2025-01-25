using System;
using UnityEngine.UIElements;

namespace Reiren.Core.VisualElmenents
{
    public class TabButton : Button
    {
        public bool ToggleState;
        public string Togglegroup;

        public TabButton()
        {
            RegisterCallback<ClickEvent>(OnBoxClicked);
        }
        public void Init()
        {
            RegisterCallback<ClickEvent>(OnBoxClicked);
        }

        public TabButton(Action clickEvent) : base(clickEvent)
        {
            Init();
        }

        private void OnBoxClicked(ClickEvent evt)
        {
            AddToClassList("Header-Button-Pressed");
            ToggleState = true;

            if (parent == null) return;
            foreach (var value in parent.contentContainer.Children())
            {
                if (value != null && value.GetType() == typeof(TabButton) && (TabButton)value != this && ((TabButton)value).Togglegroup == Togglegroup)
                {
                    ((TabButton)value).ToggleState = false;
                    value.RemoveFromClassList("Header-Button-Pressed");
                }
            }

        }
    }
}