using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMockClassLibrary
{
    public class ClassWithPrivate
    {
        protected int _numero { get; set; }


        public int Numero => _numero;
        
        public ClassWithPrivate(int numero)
        {
            _numero = numero;
        }

        public string DoppiaNumero()
        {
            _doppiaNumero();
            return Numero.ToString();
        }

        private void _doppiaNumero()
        {
            _numero=_numero*2;
        }
    }
}
