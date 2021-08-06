
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Treino {

    public Treino() {
    }

    private string nome;

    private List<Equipamento> equipamentos;

    private Aluno aluno;

    private Treinador trenaidor;

    private DateTime inicio;

    private DateTime fim;

    public string Nome {
        get; set;
    }

    public List<Equipamento> Equipamentos {
        get; set;
    }

    public Aluno Aluno {
        get; set;
    }

    public Treinador Treinador {
        get; set;
    }

    public DateTime Inicio {
        get; set;
    }

    public DateTime Fim {
        get; set;
    }





    public void imprimirDados() {
        // TODO implement here
    }

    /// <summary>
    /// @param inicio 
    /// @param fim
    /// </summary>
    public void alterarData(DateTime inicio, DateTime fim) {
        // TODO implement here
    }

    /// <summary>
    /// @param equipamento
    /// </summary>
    public void inserirEquipamento(Equipamento equipamento) {
        // TODO implement here
    }

}