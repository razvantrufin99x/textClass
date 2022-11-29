using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textClass
{
    public  class lineOfText
    {
        public List<string> thelineoftext = new List<string>();

        public lineOfText() { }
        public lineOfText(string text) {
            thelineoftext.Add(text);
        }
        public List<string> GetListOfText() {
            return this.thelineoftext;
        }
        public string GetTextOfLine()
        {
            string s = "";
            for (int i = 0; i < thelineoftext.Count; i++)
            {
                s +=thelineoftext[i].ToString();
            }
            return s;
        }
    }
}
