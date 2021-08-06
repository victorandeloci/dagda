using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Posicao
{
    public string nome;
    public int numCamisa;
    public Jogador jogador;

    public void imprimirDados()
    {
        Console.WriteLine("Posição: " + this.nome);
        Console.WriteLine("Camisa: " + this.numCamisa);

        //Posicao possui de 0 a N jogadores
        if(this.jogador != null)
        {
            Console.WriteLine("Jogador: " + this.jogador.nome);
            Console.WriteLine("Idade do Jogador: " + this.jogador.idade);
        }
    }
}
