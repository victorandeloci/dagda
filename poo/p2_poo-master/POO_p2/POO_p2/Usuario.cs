public abstract class Usuario
{
	private string nome;
	private string email;

	public abstract string Nome {get; set;}
	public abstract string Email {get; set;}

	public abstract void imprimirDados();

}

