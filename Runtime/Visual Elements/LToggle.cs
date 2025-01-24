using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace ReirenCore.VisualElmenents
{
    using ExtensionMethods;
    public class LToggle : VisualElement
    {
        public Label Label = new();

        public Sprite IconChecked = EditorGUIUtility.FindTexture("AlphabeticalSorting").ToSprite();
        public Sprite IconNotChecked = EditorGUIUtility.FindTexture("AlphabeticalSorting").ToSprite();

        private Image Icon = new();

        bool _value;
        public bool value
        {
            get => _value;
            set
            {
                _value = value;
                switchIcon();
            }
        }


        public LToggle(string Headertext)
        {
            Add(Icon);
            Add(Label);
            Label.text = Headertext;
            RegisterCallback<MouseDownEvent>(evt =>
            {
                _value = !_value;
                switchIcon();
            });
            style.flexDirection = FlexDirection.Row;
            switchIcon();
        }

        void switchIcon()
        {
            if (_value)
                Icon.sprite = IconChecked;
            else
                Icon.sprite = IconNotChecked;
        }
    }
}