
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

public class Equipamento {

    public Equipamento() {
    }

    public Equipamento(int cod, string nome, string tipo, string status, string fabricante)
    {
        this.Cod = cod;
        this.Nome = nome;
        this.Tipo = tipo;
        this.Status = status;
        this.Fabricante = fabricante;
    }

    private int cod;

    private string nome;

    private string tipo;

    private string status;

    private string fabricante;

    public int Cod { get => cod; set => cod = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Tipo { get => tipo; set => tipo = value; }
    public string Status { get => status; set => status = value; }
    public string Fabricante { get => fabricante; set => fabricante = value; }

    public void imprimirDados() {
        Console.WriteLine("\n" + "\tCód do equipamento: " + Cod);
        Console.WriteLine("\tNome do equipamento: " + Nome);
        Console.WriteLine("\tTipo do equipamento: " + Tipo);
        Console.WriteLine("\tSituação do Equipamento: " + Status);
        Console.WriteLine("\tFabricante do Equipamento: " + Fabricante + "\n");
    }

}