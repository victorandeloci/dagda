
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Aula {

    public Aula() {
    }

    public Aula(string nome, Area area, Professor professor, DateTime data, List<Aluno> alunos)
    {
        this.Nome = nome;
        this.Area = area;
        this.Professor = professor;
        this.Data = data;
        this.Alunos = alunos;

    }

    private string nome;

    private Area area;

    private List<Aluno> alunos;

    private Professor professor;

    private DateTime data;

    public string Nome { get => nome; set => nome = value; }
    public Area Area { get => area; set => area = value; }
    public Professor Professor { get => professor; set => professor = value; }
    public DateTime Data { get => data; set => data = value; }
    public List<Aluno> Alunos
    {
        get => alunos;
        set
        {
            if (value != null)
                alunos = value;
        }
    }

    public void imprimirDados() {
        Console.WriteLine("\n" + "Nome da Aula: " + Nome);
        Area.imprimirDados();
        Professor.imprimirDados();
        Console.WriteLine("Data da aula: " + Data +  "\n");

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
    public void inserirAluno(Aluno aluno)
    {
        this.Alunos.Add(aluno);
    }

}