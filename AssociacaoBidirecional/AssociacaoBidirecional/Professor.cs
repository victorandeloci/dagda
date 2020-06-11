using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Professor
{
    public string nome;
    public int idade;
    private List<Professor> professores;    // RELACIONAMENTO 0...*
    private Professor coordenador;          // RELACIONAMENTO 

    public List<Professor> Professores
    {
        get{
            if (professores == null)
            {
                professores = new List<Professor>();
            }
            return professores;
        }
        set{
            if (professores == null)
            {
                professores = new List<Professor>();
            }
            professores = value;
        }
    }

    public Professor Coordenador
    {
        get
        {
            if (coordenador == null)
            {
                coordenador = new Professor();
            }
            return coordenador;
        }
        set
        {
            if (coordenador == null)
            {
                coordenador = new Professor();
            }
            coordenador = value;
        }
    }

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);

        if (coordenador != null)
        {
            Console.WriteLine("\t Coordenador: " + coordenador.nome);
            Console.WriteLine("\t Idade: " + coordenador.idade);
        }


        if (professores != null)
        {
            foreach (Professor item in professores)
            {
                Console.WriteLine("\t Nome: " + item.nome);
                Console.WriteLine("\t Idade: " + item.idade);
            }
        }
    }


}

