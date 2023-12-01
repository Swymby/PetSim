using PetSim;

Console.WriteLine("Wanna cat? (yes/no)");
var isCat = Console.ReadLine() == "yes";

Pet pet = isCat ? new Cat("Ladislava") : new Dog("Vašek");

pet.Feed();

pet.Play();
pet.Play();
pet.Play();
