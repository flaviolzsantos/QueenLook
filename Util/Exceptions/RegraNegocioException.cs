using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Exceptions
{
    [Serializable]
    public class RegraNegocioException : Exception
    {
        public RegraNegocioException() { }

        public RegraNegocioException(string mensagem) : base(mensagem) { }

        public RegraNegocioException(string mensagem, Exception innerException) : base(mensagem, innerException) { }
    }
}
