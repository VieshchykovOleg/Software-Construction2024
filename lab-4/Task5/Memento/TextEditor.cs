using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class TextEditor
    {
        private TextDocument _document;
        private Stack<TextDocumentMemento> _history;

        public TextEditor()
        {
            _document = new TextDocument();
            _history = new Stack<TextDocumentMemento>();
        }

        public void Type(string words)
        {
            _history.Push(_document.Save());
            _document.Text += words;
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Restore(memento);
            }
        }

        public string Print()
        {
            return _document.Text;
        }
    }

