public class LeaoMarinho
{
    private string nome;

    private int idade;

    private string especie;

    private double altura;

    private double peso;

    public string Nome
    {
        get { return nome;}
        set { nome = value;}
    }

    public int Idade
    {
        get {return idade;}
        set 
        { 
            if (value >=0)
                idade = value;

        
        }
    }

    public string Especie
    {
        get { return especie; }
        set { especie = value; }
    }

        public double Altura
    {
        get { return altura; }
        set
        {
            if (value > 0)
                altura = value;
        }
    }

    public double Peso
    {
        get { return peso; }
        set
        {
            if (value > 0)
                peso = value;
        }
    }



    public void exibirinfo()
    {
        Console.WriteLine($"Leão marinho: {nome}");
        Console.WriteLine($"Espécie: {especie}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Peso: {peso}");
    }
}

