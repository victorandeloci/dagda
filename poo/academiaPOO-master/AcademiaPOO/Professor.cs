
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Professor : Usuario {

    public Professor() {
    }

    public Professor(int id, string nome, string telefone, string email, string endereco, string especialidade, List<Aluno> alunos, List<Aula> aulas)
    {
        this.Id = id;
        this.Nome = nome;
        this.Telefone = telefone;
        this.Email = email;
        this.Endereco = endereco;
        this.Especialidade = especialidade;
        this.Alunos = alunos;
        this.Aulas = aulas;
    }

    private string especialidade;

    private List<Aluno> alunos;

    private List<Aula> aulas;

    public string Especialidade { get => especialidade; set => especialidade = value; }
    public List<Aluno> Alunos { 
        get => alunos; 
        set
        {
            if (value != null)
                alunos = value;
        }
    }
    public List<Aula> Aulas { 
        get => aulas; 
        set
        {
            if (value != null)
                aulas = value;
        }
    }

    public void imprimirDados() {
        Console.WriteLine("\n" + "\tNome do Professor: " + Nome);
        Console.WriteLine("\tID: " + Id);
        Console.WriteLine("\tEspecialidade: " + Especialidade);
        Console.WriteLine("\tTelefone: " + Telefone);
        Console.WriteLine("\tE-mail: " + Email);
        Console.WriteLine("\tEndereço: " + Endereco + "\n");

        if (this.Aulas != null)
        {
            foreach (Aula aula in this.Aulas)
            {
                if (aula != null)
                {
                    aula.imprimirDados();
                }
            }
        }

        if (this.Alunos != null)
        {
            foreach (Aluno aluno in this.Alunos)
            {
                if (aluno != null)
                {
                    aluno.imprimirDados();
                }
            }
        }

    }

    public void inserirAula(Aula aula) {
        this.Aulas.Add(aula);
    }


    public void inserirAluno(Aluno aluno) {
        this.Alunos.Add(aluno);
    }

}