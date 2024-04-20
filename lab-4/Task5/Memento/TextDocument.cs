using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class TextDocument
    {
        public string Text { get; set; }

        public TextDocumentMemento Save()
        {
            return new TextDocumentMemento(Text);
        }

        public void Restore(TextDocumentMemento memento)
        {
            Text = memento.Text;
        }
    }

