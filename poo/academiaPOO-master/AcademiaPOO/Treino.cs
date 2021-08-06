
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Treino {

    public Treino() {
    }

    public Treino(string nome, Aluno aluno, Treinador treinador, DateTime inicio, DateTime fim, List<Equipamento> equipamentos)
    {
        this.Nome = nome;
        this.Aluno = aluno;
        this.Treinador = treinador;
        this.Inicio = inicio;
        this.Fim = fim;
        this.Equipamentos = equipamentos;
    }

    private string nome;

    private List<Equipamento> equipamentos;

    private Aluno aluno;

    private Treinador treinador;

    private DateTime inicio;

    private DateTime fim;

    public string Nome { get => nome; set => nome = value; }
    public List<Equipamento> Equipamentos { 
        get => equipamentos; 
        set
        {
            if (value != null)
            {
                equipamentos = value;
            }
        }
    }
    public Aluno Aluno { get => aluno; set => aluno = value; }
    public Treinador Treinador { get => treinador; set => treinador = value; }
    public DateTime Inicio { get => inicio; set => inicio = value; }
    public DateTime Fim { get => fim; set => fim = value; }

    public void imprimirDados() {
        Console.WriteLine("\n" + "Nome do treino: " + Nome);
        Aluno.imprimirDados();
        Treinador.imprimirDados();
        Console.WriteLine("Data do ínicio: " + Inicio);
        Console.WriteLine("Data do fim: " + Fim + "\n");

        if (this.Equipamentos != null)
        {
            foreach (Equipamento equipamento in this.equipamentos)
            {
                if (equipamento != null)
                {
                    equipamento.imprimirDados();
                }
            }
        }
    }

    public void alterarData(DateTime inicio, DateTime fim) {
        this.Inicio = inicio;
        this.Fim = fim;
    }

    public void inserirEquipamento(Equipamento equipamento) {
        this.Equipamentos.Add(equipamento);
    }

}