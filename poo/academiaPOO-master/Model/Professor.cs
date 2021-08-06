
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Professor : Usuario {

    public Professor() {
    }

    private string especialidade;

    private List<Aluno> alunos;

    private List<Aula> aulas;

    public string Especialidade {
        get; set;
    }

    public List<Aluno> Alunos {
        get; set;
    }

    public List<Aula> Aulas {
        get; set;
    }





    public void imprimirDados() {
        // TODO implement here
    }

    /// <summary>
    /// @param aula
    /// </summary>
    public void inserirAula(Aula aula) {
        // TODO implement here
    }

    /// <summary>
    /// @param aluno
    /// </summary>
    public void inserirAluno(Aluno aluno) {
        // TODO implement here
    }

}