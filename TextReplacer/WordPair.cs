using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReplacer
{
    class WordPair
    {
        public string target, newText;

        public WordPair(string target, string newText)
        {
            this.target = target;
            this.newText = newText;
        }
    }
}
