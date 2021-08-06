
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Usuario : Usuario {

    public Usuario() {
    }

    private int id;

    private string nome;

    private string telefone;

    private string email;

    private string endereco;

    protected int Id {
        get; set;
    }

    protected string Nome {
        get; set;
    }

    protected string Telefone {
        get; set;
    }

    protected string Email {
        get; set;
    }

    protected string Endereco {
        get; set;
    }

}