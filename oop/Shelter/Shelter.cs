using System;

class Animal
{
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public Species Species { get; set; }

    public const decimal BaseShelterCost = 200;

    public Animal(string name, Species species)
    {
        Name = name;
        Cost = BaseShelterCost;
        Species = species;
    }

    public decimal HowMuch()
    {
        if (Species.Breed == "cat")
        {
            return Cost;
        }
        else if (Species.Breed == "dog")
        {
            decimal walkingFee = 50;
            return Cost + walkingFee;
        }
        else
        {
            return Cost;
        }
    }
}

class Species
{
    public string Breed { get; set; }

    public Species(string breed)
    {
        Breed = breed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Species catSpecies = new Species("cat");
        Species dogSpecies = new Species("dog");

        Animal cat1 = new Animal("Boncuk", catSpecies);
        Animal cat2 = new Animal("Pamuk", catSpecies);
        Animal dog1 = new Animal("Karabaş", dogSpecies);
        Animal dog2 = new Animal("Paşa", dogSpecies);

        Console.WriteLine($"{cat1.Name} için barınak ücreti: {cat1.HowMuch()}");
        Console.WriteLine($"{cat2.Name} için barınak ücreti: {cat2.HowMuch()}");
        Console.WriteLine($"{dog1.Name} için barınak ücreti: {dog1.HowMuch()}");
        Console.WriteLine($"{dog2.Name} için barınak ücreti: {dog2.HowMuch()}");
    }
}
