using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;

namespace Reiren.Core.VisualElmenents
{
    using ExtensionMethods;


    public class FoldoutList : VisualElement
    {
        private VisualElement Header = new();
        public VisualElement HeaderSub = new();
        private Image Icon = new();
        public Label LabelElement = new();
        public Button AddButton;
        public bool HeaderAtSide = false;

        bool _NoFoldout = false;
        public bool NoFoldout
        {
            get => _NoFoldout;
            set
            {
                _NoFoldout = value;
                switchState();
            }
        }
        bool _side;
        public bool SidePosition
        {
            get => _side;
            set
            {
                _side = value;
                Initialize(_side);
            }
        }
        bool _value;
        public bool value
        {
            get => _value;
            set
            {
                _value = value;
                switchState();
            }
        }

        public FoldoutList(string Headertext, bool noFoldout = false)
        {
            styleSheets.Add(Resources.Load<StyleSheet>("FoldoutList"));
            _NoFoldout = noFoldout;
            AddButton = new();
            Image AddIcon = new();
            AddIcon.AddToClassList("AddIcon");
            AddIcon.sprite = EditorGUIUtility.FindTexture("Toolbar Plus More").ToSprite();
            AddButton.Add(AddIcon);
            Header.Add(AddButton);
            Header.Add(HeaderSub);

            HeaderSub.RegisterCallback<MouseDownEvent>(evt =>
            {
                _value = !_value;
                switchState();
            });
            Icon.sprite = EditorGUIUtility.FindTexture("d_PlayButton").ToSprite();

            LabelElement.AddToClassList("Label");
            LabelElement.text = Headertext;
            HeaderSub.Add(Icon);
            HeaderSub.Add(LabelElement);

            Add(Header);

            Initialize(_side);
            switchState();
        }

        void Initialize(bool Side)
        {
            if (Side)
            {
                Header.style.flexDirection = FlexDirection.Column;
                HeaderSub.style.flexDirection = FlexDirection.Column;
            }
            else
            {
                Header.style.flexDirection = FlexDirection.Row;
                HeaderSub.style.flexDirection = FlexDirection.Row;
            }
            contentContainer.style.maxHeight = contentContainer.style.height;
            contentContainer.style.maxWidth = style.width;
            contentContainer.style.width = style.width;

        }

        void switchState()
        {
            contentContainer.style.maxWidth = style.width;
            contentContainer.style.width = style.width;
            Icon.visible = !_NoFoldout;
            if (_NoFoldout)
            {
                contentContainer.visible = true;
                contentContainer.style.maxHeight = contentContainer.style.height;
            }
            else
            {
                contentContainer.visible = (_value);
                if (_value && !_side)
                {
                    contentContainer.style.maxHeight = contentContainer.style.height;
                    Icon.style.rotate = new Rotate(90f);
                }
                else if (!_value && !_side)
                {
                    contentContainer.style.maxHeight = 0;
                    Icon.style.rotate = new Rotate(0f);
                }
                else if (_value && _side)
                {
                    contentContainer.style.maxWidth = style.width;
                    Icon.style.rotate = new Rotate(0f);
                }
                else if (!_value && _side)
                {
                    contentContainer.style.maxWidth = 0;
                    Icon.style.rotate = new Rotate(90f);
                }
            }



        }
    }
}