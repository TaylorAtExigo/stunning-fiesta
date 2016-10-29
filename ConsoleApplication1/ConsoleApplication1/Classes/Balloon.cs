using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
    public class Balloon
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private string _size;

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private int _psi;

        public int Psi
        {
            get { return _psi; }
            set { _psi = value; }
        }

        public Balloon(string color, string size, int psi) 
        {
            if(color == "yellow")
                throw new ArgumentException("Yellow is fucking terrible!", "color");
            Color = color;

            if (size == "large" || size == "medium" || size == "small")
                Size = size;
            else
                throw new ArgumentException("Not an option, try again", "size");
            /*
            if(size != "medium")
                throw new ArgumentException("Not an option, try again", "size");
            if(size != "small")
                throw new ArgumentException("Not an option, try again", "size");
             */
            Size = size;

            if (psi < 0)
                throw new ArgumentException("A positive number is needed here", "psi");
            Psi = psi;
        }



    }
}
