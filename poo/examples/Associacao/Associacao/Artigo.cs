using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Artigo
{
    public string titulo;
    public int ano;

    private Autor[] autores = new Autor[3];

    public Autor[] Autores {

        get => autores;
        set => autores = value; 
    }

    public void imprimirDados()
    {
        Console.WriteLine("Título: " + this.titulo);
        Console.WriteLine("Ano: " + this.ano);

        for(int i = 0; i < 3; i++)
        {
            if(this.Autores[i] != null)
            {
                Console.WriteLine("\t Código: " + Autores[i].codigo);
                Console.WriteLine("\t Nome: " + Autores[i].nome);
            }
        }
    }
}
