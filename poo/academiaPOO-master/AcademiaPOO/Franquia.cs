
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Franquia : Academia {

    public Franquia() {
    }
    public Franquia(string nome, string site, string cnpj, string endereco, string telefone, List<Area> areas, List<Aluno> alunos, List<Professor> professores, List<Treinador> treinadores)
    {
        this.Nome = nome;
        this.Site = site;
        this.Cnpj = cnpj;
        this.Endereco = endereco;
        this.Telefone = telefone;
        this.Areas = areas;
        this.Alunos = alunos;
        this.Professores = professores;
        this.Treinadores = treinadores;
    }

    private string cnpj;

    private string endereco;

    private string telefone;

    private List<Area> areas;

    private List<Aluno> alunos;

    private List<Professor> professores;

    private List<Treinador> treinadores;

    public string Cnpj { get => cnpj; set => cnpj = value; }
    public string Endereco { get => endereco; set => endereco = value; }
    public string Telefone { get => telefone; set => telefone = value; }
    public List<Area> Areas { 
        get => areas; 
        set
        {
            if(value != null)
            {
                areas = value;
            }
        }
    }
    public List<Aluno> Alunos { 
        get => alunos; 
        set
        {
            if (value != null)
            {
                alunos = value;
            }
        }
    }
    public List<Professor> Professores { 
        get => professores;
        set
        {
            if (value != null)
            {
                professores = value;
            }
        }
    }
    public List<Treinador> Treinadores {
        get => treinadores; 
        set
        {
            {
                if (value != null)
                {
                    treinadores = value;
                }
            }
        }
    }

    public void imprimirDados() {
        Console.WriteLine("\n" + "Nome da Academia: " + Nome);
        Console.WriteLine("Site da Academia: " + Site);
        Console.WriteLine("CNPJ da franquia: " + Cnpj);
        Console.WriteLine("Telefone da franquia: " + Telefone + "\n");

        if(this.Areas != null)
        {
            foreach (Area area in this.Areas)
            {
                if (area != null)
                {
                    area.imprimirDados();
                }
            }
        }

        if(this.Professores != null)
        {
            foreach (Professor professor in this.Professores)
            {
                if (professor != null)
                {
                    professor.imprimirDados();
                }
            }
        }

        if(this.Treinadores != null)
        {
            foreach (Treinador treinador in this.Treinadores)
            {
                if (treinador != null)
                {
                    treinador.imprimirDados();
                }
            }
        }

        if(this.Alunos != null)
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

    public void inserirArea(Area area) {
        this.Areas.Add(area);
    }

    public void inserirTreinador(Treinador treinador) {
        this.Treinadores.Add(treinador);
    }

    public void inserirProfessor(Professor professor) {
        this.Professores.Add(professor);
    }

    public void inserirAluno(Aluno aluno) {
        this.Alunos.Add(aluno);
    }

}