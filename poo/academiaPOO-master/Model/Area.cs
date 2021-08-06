
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Area {

    public Area() {
    }

    private int cod;

    private string nome;

    private List<Equipamento> equipamentos;

    private List<Aula> aulas;

    public int Cod {
        get; set;
    }

    public string Nome {
        get; set;
    }

    public List<Equipamento> Equipamentos {
        get; set;
    }

    public List<Aula> Aulas {
        get; set;
    }




    public void imprimirDados() {
        // TODO implement here
    }

    public void imprimirEquipamentos() {
        // TODO implement here
    }

    public void imprimirAulas() {
        // TODO implement here
    }

    /// <summary>
    /// @param equipamento
    /// </summary>
    public void inserirEquipamento(Equipamento equipamento) {
        // TODO implement here
    }

    /// <summary>
    /// @param aula
    /// </summary>
    public void inserirAula(Aula aula) {
        // TODO implement here
    }

}