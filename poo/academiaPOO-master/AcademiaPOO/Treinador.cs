
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Treinador : Usuario {

    public Treinador() {
    }
    public Treinador(int id, string nome, string telefone, string email, string endereco, List<Treino> treinos, List<Aluno> alunos)
    {
        this.Id = id;
        this.Nome = nome;
        this.Telefone = telefone;
        this.Email = email;
        this.Endereco = endereco;
        this.Treinos = treinos;
        this.Alunos = alunos;
    }

    private List<Treino> treinos;

    private List<Aluno> alunos;

    public List<Treino> Treinos { 
        get => treinos; 
        set
        {
            if (value != null)
                treinos = value;
        } 
    }
    public List<Aluno> Alunos { 
        get => alunos; 
        set
        {
            if (value != null)
                alunos = value;
        }
    }

    public void imprimirDados() {
        Console.WriteLine("\n" + "\tNome do treinador: " + Nome);
        Console.WriteLine("\tID: " + Id);
        Console.WriteLine("\tTelefone: " + Telefone);
        Console.WriteLine("\tE-mail: " + Email);
        Console.WriteLine("\tEndereço: " + Endereco + "\n");

        if (this.Treinos != null)
        {
            foreach (Treino treino in this.Treinos)
            {
                if (treino != null)
                {
                    treino.imprimirDados();
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

    public void inserirTreino(Treino treino) {
        this.Treinos.Add(treino);
    }

    public void inserirAluno(Aluno aluno) {
        this.Alunos.Add(aluno);
    }

}