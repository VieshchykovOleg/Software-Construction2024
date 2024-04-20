using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class TextDocumentMemento
    {
        public string Text { get; private set; }

        public TextDocumentMemento(string text)
        {
            Text = text;
        }
    }

