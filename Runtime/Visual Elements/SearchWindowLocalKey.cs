using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;
using UnityEditor.Localization;
using System;

namespace ReirenCore.VisualElmenents
{
    public class SearchWindowLocalKey : ScriptableObject, ISearchWindowProvider
    {
        private StringTableCollection _stringTable;
        private List<string> _Listdata;
        private TextField TextField;
        private Texture2D _indentationIcon;
        private Button Button;
        private bool ButtonSetText = true;
        private bool _SplitText = true;
        private string _SplitSymbol = "_";

        public void Init(StringTableCollection stringTable, TextField textField)
        {
            _stringTable = stringTable;
            TextField = textField;
            _indentationIcon = new Texture2D(1, 1);
            _indentationIcon.SetPixel(0, 0, new Color(0, 0, 0, 0));
            _indentationIcon.Apply();
        }
        public void Init(List<string> Data, TextField textField)
        {
            _Listdata = Data;
            TextField = textField;
            _indentationIcon = new Texture2D(1, 1);
            _indentationIcon.SetPixel(0, 0, new Color(0, 0, 0, 0));
            _indentationIcon.Apply();
        }
        public void Init(List<string> Data, Button button, bool SetText = true)
        {
            _Listdata = Data;
            Button = button;
            ButtonSetText = SetText;
            _indentationIcon = new Texture2D(1, 1);
            _indentationIcon.SetPixel(0, 0, new Color(0, 0, 0, 0));
            _indentationIcon.Apply();
        }
        public void SplitText(bool val, string Symbol = "_")
        {
            _SplitText = val;
            _SplitSymbol = Symbol;
        }

        public List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
        {
            List<SearchTreeEntry> tree = new List<SearchTreeEntry>();
            tree.Add(new SearchTreeGroupEntry(new GUIContent("Localize Keys"), 0));

            List<string> values = new();
            if (_stringTable != null)
            {
                values = _stringTable.StringTables[0].SharedData.Entries.Select(p => p.Key.ToString()).ToList();
            }
            else if (_Listdata != null)
            {
                values = _Listdata;
            }

            values.Sort((x, y) => x.CompareTo(y));

            List<string> groups = new();
            foreach (var entry in values)
            {
                string[] var = entry.Split(_SplitSymbol, _SplitText ? 2 : 1);
                string Groupname = "";
                if (var.Length == 1)
                {
                    tree.Add(new SearchTreeEntry(new GUIContent(entry, _indentationIcon))
                    {
                        userData = entry,
                        level = 1
                    });
                    Groupname = entry;
                    groups.Add(Groupname);
                }
                else if (var.Length == 2)
                {
                    Groupname = var[0];
                    if (!groups.Contains(var[0]))
                    {
                        tree.Add(new SearchTreeGroupEntry(new GUIContent(Groupname, _indentationIcon))
                        {
                            userData = "",
                            level = 1
                        });
                        groups.Add(Groupname);
                    }
                    Groupname += "/" + entry;
                    tree.Add(new SearchTreeEntry(new GUIContent(entry, _indentationIcon))
                    {
                        userData = entry,
                        level = 2,
                    });
                    groups.Add(Groupname);
                }
            }
            return tree;
        }

        public bool OnSelectEntry(SearchTreeEntry SearchTreeEntry, SearchWindowContext context)
        {
            if ((string)SearchTreeEntry.userData == "")
                return false;
            else
            {
                if (TextField != null)
                    TextField.value = (string)SearchTreeEntry.userData;
                else if (Button != null && ButtonSetText)
                    Button.text = (string)SearchTreeEntry.userData;
                else if (Button != null)
                {
                    ChangeEvent<string> evt = ChangeEvent<string>.GetPooled("", (string)SearchTreeEntry.userData);
                    evt.target = Button;
                    Button.SendEvent(evt);
                }
                return true;
            }

        }
    }
}