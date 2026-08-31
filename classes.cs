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

    public LeaoMarinho(string nome, int idade, string especie, double altura, double peso)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
        Altura = altura;
        Peso = peso;
    }



    public override string ToString()
    {
        return $"Leão-marinho: {Nome} | Espécie: {Especie} | Idade: {Idade} anos | Altura: {Altura} m | Peso: {Peso} kg";
    }

}

