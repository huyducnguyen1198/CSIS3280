using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Exception
{
    [Serializable]
    class BookNameEmptyException : Exception
    {
        public BookNameEmptyException() { }
        public BookNameEmptyException(string message) :
            base(String.Format("Book Name empty: {0}", message))
        {

        }
    }
}
