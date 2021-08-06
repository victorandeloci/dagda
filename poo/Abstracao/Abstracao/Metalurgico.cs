using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Metalurgico : Pessoa
{
    public override float Salario
    {
        get
        {
            return salario;
        }
        set
        {
            salario = value + 500f;
        }
    }


}
