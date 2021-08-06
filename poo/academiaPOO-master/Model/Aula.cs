
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Aula {

    public Aula() {
    }

    private string nome;

    private Area area;

    private List<Aluno> alunos;

    private Professor professor;

    private DateTime data;

    public string Nome {
        get; set;
    }

    public Area Area {
        get; set;
    }

    public List<Aluno> Alunos {
        get; set;
    }

    public Professor Professor {
        get; set;
    }

    public DateTime Data {
        get; set;
    }




    public void imprimirDados() {
        // TODO implement here
    }

    /// <summary>
    /// @param aluno
    /// </summary>
    public void inserirAluno(Aluno aluno) {
        // TODO implement here
    }

}