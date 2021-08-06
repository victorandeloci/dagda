
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Usuario {

    public Usuario() {
    }

    private int id;

    private string nome;

    private string telefone;

    private string email;

    private string endereco;

    protected int Id { get => id; set => id = value; }
    protected string Nome { get => nome; set => nome = value; }
    protected string Telefone { get => telefone; set => telefone = value; }
    protected string Email { get => email; set => email = value; }
    protected string Endereco { get => endereco; set => endereco = value; }
}