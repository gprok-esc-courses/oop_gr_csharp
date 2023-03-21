

using petshop;

List<Pet> pets = new List<Pet>();

pets.Add(new Dog("Pluto"));
pets.Add(new Cat("Sylvester"));
pets.Add(new Duck("Donald"));
pets.Add(new Dog("Cooper"));
pets.Add(new Cat("Garfield"));
pets.Add(new Parrot("Willy"));

foreach(Pet pet in pets)
{
    Console.WriteLine(pet.Name + " says " + pet.Sound);
}

foreach (Pet pet in pets)
{
    pet.eat();
}





