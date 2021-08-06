
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Aluno : Usuario {

    public Aluno() {
    }

    private int contrato;

    private DateTime inicioContrato;

    private DateTime fimContrato;

    private List<Treino> treinos;

    private List<Aula> aulas;

    public int Contrato {
        get; set;
    }

    public DateTime InicioContrato {
        get; set;
    }

    public DateTime FimContrato {
        get; set;
    }

    public List<Treino> Treinos {
        get; set;
    }

    public List<Aula> Aulas {
        get; set;
    }






    public void imprimirDados() {
        // TODO implement here
    }

    /// <summary>
    /// @param treino
    /// </summary>
    public void inserirTreino(Treino treino) {
        // TODO implement here
    }

    /// <summary>
    /// @param aula
    /// </summary>
    public void inserirAula(Aula aula) {
        // TODO implement here
    }

}