public class pessoa
{
    private string? nome;
    private int idade;

    public string? Nome
    {
        get{return nome;}
        set{nome = value;}
    }
    public int Idade
    {
        get{return idade;}
        set{
            if (value > 0)
            {
                idade = value;
            }
            else if (idade > 150)
            {
                Console.WriteLine("Bah cupinxa a idade dos guri é impossivel");
            }

            else
            {
                Console.WriteLine("Bah, a idade dos guri é inválida");
            }
        }
    }
}




