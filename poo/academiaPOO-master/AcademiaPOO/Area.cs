
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Area {

    public Area() {
    }

    public Area(int cod, string nome, List<Equipamento> equipamentos, List<Aula> aulas)
    {
        this.Cod = cod;
        this.Nome = nome;
        this.Equipamentos = equipamentos;
        this.Aulas = aulas;
    }

    private int cod;

    private string nome;

    private List<Equipamento> equipamentos;

    private List<Aula> aulas;

    public int Cod { get => cod; set => cod = value; }
    public string Nome { get => nome; set => nome = value; }
    public List<Equipamento> Equipamentos { 
        get => equipamentos;
        set
        {
            if(value != null)
            {
                equipamentos = value;
            }
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
        Console.WriteLine("\n" + "Nome da Área: " + Nome);
        Console.WriteLine("Código da Área: " + Cod + "\n");

        if(this.Equipamentos != null)
        {
            foreach (Equipamento equipamento in this.equipamentos)
            {
                if (equipamento != null)
                {
                    equipamento.imprimirDados();
                }
            }
        }

        if(this.Aulas != null)
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

    public void imprimirEquipamentos() {

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

    public void imprimirAulas() {

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

    public void inserirEquipamento(Equipamento equipamento) {
        this.Equipamentos.Add(equipamento); 
    }

    public void inserirAula(Aula aula) {
        this.Aulas.Add(aula);
    }

}