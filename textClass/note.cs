using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textClass
{
    public  class note : text
    {
        public int id;
        public string title;
        public string description;
        public DateTime creationDate;
        public DateTime updatedDate;
        public List<autor> autori = new List<autor>();
        public int maximumLenght = 100;
        public int width;
        public int height;
        public int top;
        public int left;
        public Color color;
        public Font font;
    }
}
