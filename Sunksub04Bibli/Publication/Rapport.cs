using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Publication
{
    class Rapport
    {
        private string Type;
        private string Message;
        private string Tour;

        public Rapport(string type, string tour, string message)
        {
            Type = type;
            Tour = tour;
            Message = message;
        }
        public override string ToString()
        {
            string toString = $"{Type} : Reception {Tour} // {Message}"; 
            return toString;
        }

    }
}
