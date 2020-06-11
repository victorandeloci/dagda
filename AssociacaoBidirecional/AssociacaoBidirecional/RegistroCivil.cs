using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RegistroCivil
{
    public string nome;
    public int idade;
    private RegistroCivil conjuge;

    public RegistroCivil Conjuge
    {
        get
        {
            if (conjuge == null)
            {
                conjuge = new RegistroCivil();
            }
            return conjuge;
        }
        set
        {
            if (conjuge == null)
            {
                conjuge = new RegistroCivil();
            }
            conjuge = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);

        if (conjuge != null)
        {
            Console.WriteLine("\t Casado com: " + conjuge.nome);
            Console.WriteLine("\t Idade: " + conjuge.idade);
        }
    }


}

