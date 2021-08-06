
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Franquia : Academia {

    public Franquia() {
    }

    private string cnpj;

    private string endereco;

    private string telefone;

    private List<Area> areas;

    private List<Aluno> alunos;

    private List<Professor> professores;

    private List<Treinador> treinadores;

    public string Cnpj {
        get; set;
    }

    public string Endereco {
        get; set;
    }

    public string Telefone {
        get; set;
    }

    public List<Area> Areas {
        get; set;
    }

    public List<Professor> Professores {
        get; set;
    }

    public List<Treinador> Treinadores {
        get; set;
    }






    public void imprimirDados() {
        // TODO implement here
    }

    /// <summary>
    /// @param area
    /// </summary>
    public void inserirArea(Area area) {
        // TODO implement here
    }

    /// <summary>
    /// @param treinador
    /// </summary>
    public void inserirTreinador(Treinador treinador) {
        // TODO implement here
    }

    /// <summary>
    /// @param professor
    /// </summary>
    public void inserirProfessor(Professor professor) {
        // TODO implement here
    }

    /// <summary>
    /// @param aluno
    /// </summary>
    public void inserirAluno(Aluno aluno) {
        // TODO implement here
    }

}