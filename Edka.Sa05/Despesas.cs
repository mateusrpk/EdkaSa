using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa04
{
    public class Disciplinals
    {
        public string Disciplina { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public override string ToString() => $"{Disciplina,-20}  {Inicio:dd/MM/yyyy} {Termino:dd/MM/yyyy}";
    }
}