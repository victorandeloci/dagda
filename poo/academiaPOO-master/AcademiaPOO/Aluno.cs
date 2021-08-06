
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Aluno : Usuario {

    public Aluno() {
    }

    public Aluno(int id, string nome, string telefone, string email, string endereco, int contrato, DateTime inicioContrato, DateTime fimContrato, List<Treino> treinos, List<Aula> aulas)
    {
        this.Id = id;
        this.Nome = nome;
        this.Telefone = telefone;
        this.Email = email;
        this.Endereco = endereco;
        this.Contrato = contrato;
        this.InicioContrato = inicioContrato;
        this.FimContrato = fimContrato;
        this.Treinos = treinos;
        this.Aulas = aulas;
    }

    private int contrato;

    private DateTime inicioContrato;

    private DateTime fimContrato;

    private List<Treino> treinos;

    private List<Aula> aulas;

    public int Contrato { get => contrato; set => contrato = value; }
    public DateTime InicioContrato { get => inicioContrato; set => inicioContrato = value; }
    public DateTime FimContrato { get => fimContrato; set => fimContrato = value; }
    public List<Treino> Treinos { 
        get => treinos; 
        set
        {
            if (value != null)
                treinos = value;
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
        Console.WriteLine("\n" + "\tNome do aluno: " + Nome);
        Console.WriteLine("\tID: " + Id);
        Console.WriteLine("\tContrato: " + Contrato);
        Console.WriteLine("\tData do Início do Contrato: " + InicioContrato);
        Console.WriteLine("\tData do Fim do Contrato: " + FimContrato);
        Console.WriteLine("\tTelefone: " + Telefone);
        Console.WriteLine("\tE-mail: " + Email);
        Console.WriteLine("\tEndereço: " + Endereco + "\n");

        if(this.Treinos != null)
        {
            foreach (Treino treino in this.Treinos)
            {
                if (treino != null)
                {
                    treino.imprimirDados();
                }
            }
        }

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
    }


    public void inserirTreino(Treino treino) {
        this.Treinos.Add(treino);
    }

    public void inserirAula(Aula aula) {
        this.Aulas.Add(aula);
    }

}