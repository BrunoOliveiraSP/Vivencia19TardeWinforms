using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Utils
{
    public class NsfException : Exception
    {
        public NsfException(string msg)
            : base (msg)
        {

        }
	}
}