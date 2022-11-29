using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textClass
{
    public class text
    {
        public List<lineOfText> lines = new List<lineOfText>();
        public text() { }
        public void addNewLine(lineOfText plineOfText) { lines.Add(plineOfText); }
        public void removeLine(int pindex) { lines[pindex] = new lineOfText(); }
        public void clearAll() { lines = new List<lineOfText>(); }
        public List<lineOfText> getText() { return this.lines; }
        public void printAllText(ref TextBox txtbox) {
            for (int i = 0; i < lines.Count; i++)
            {
                txtbox.Text += lines[i].GetTextOfLine();
            }
        }


    }
}
