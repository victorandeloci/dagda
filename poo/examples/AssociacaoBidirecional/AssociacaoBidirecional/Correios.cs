using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Correios
{
    public string obterCidade(string cep)
    {
        switch (cep)
        {
            case "11":
                return "São Paulo";
                break;

            case "14":
                return "Ribeirão Preto";
                break;
            default:
                return "";
        }
    }
}
