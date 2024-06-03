namespace Classes_Encap_Inheri_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Person testPerson1 = new Person("Patrik", "Persson", 35, 1.75, 80);
                //Person testPerson2 = new Person("Peter", "Persson", 32);
                //Person testPerson3 = new Person("Hildar", "Johansson", 35, 1.67, 75);
                PersonHandler personHandler = new PersonHandler();
                Person testPerson4 = personHandler.CreatePerson("Hurtig", "Bulle", 43, 1.78, 70);
                Person testPerson5 = personHandler.CreatePerson("Glad", "Ihågen", 22, 1.82, 88);

                Console.Write("Before changes: ");
                personHandler.PrintPerson(testPerson4);

                personHandler.SetFName(testPerson4, "Öjvid");
                personHandler.SetLName(testPerson4, "Haraldsson");
                personHandler.SetAge(testPerson4, 50);
                personHandler.SetWeight(testPerson4, 65);
                personHandler.SetHeight(testPerson4, 1.67);

                Console.Write("After changes: ");
                personHandler.PrintPerson(testPerson4);

                Console.Write("Before changes: ");
                personHandler.PrintPerson(testPerson5);

                personHandler.SetFName(testPerson5, "Karin");
                personHandler.SetLName(testPerson5, "Knutsson");
                personHandler.SetAge(testPerson5, 63);
                personHandler.SetWeight(testPerson5, 60);
                personHandler.SetHeight(testPerson5, 1.70);

                Console.Write("After changes: ");
                personHandler.PrintPerson(testPerson5);

                UserError uEN1 = new NumericInputError();
                UserError uET1 = new TextInputError();
                UserError uEN2 = new NumericInputError();
                UserError uET2 = new TextInputError();
                UserError uEN3 = new NumericInputError();
                UserError uET3 = new TextInputError();
                UserError uEN4 = new NumericInputError();
                UserError uET4 = new TextInputError();
                UserError uEAN = new AlphaNumericInputError();
                UserError uESC = new SpecialInputError();
                UserError uEPW = new PasswordInputError();

                List<UserError> userErrorList = new List<UserError>() { uEN1, uET1, uEN2, uET2, uEN3, uET3, uEN4, uET4, uEAN, uESC, uEPW };

                foreach (UserError uE in userErrorList)
                {
                    Console.WriteLine(uE.UEMessage());
                }

                Horse horse = new Horse("Torsten", 9, 400, 2.5, 4, true);
                Dog dog = new Dog("Pepsi", 3, 20, 0.7 , 4, true);
                Hedgehog hedgehog = new Hedgehog("Harald", 5, 0.5, 0.25, 4, 742);
                Worm worm = new Worm("Rosie", 0, 0.01, 0.1, 0, false);
                Bird bird = new Bird("Polly", 8, 0.2, 0.2, 4, 0.35);
                Wolf wolf = new Wolf("Henry", 12, 75, 1.9, 4, true);
                Pelican pelican = new Pelican("George", 7, 4.1, 2.1, 4, 2.1, 0.45);
                Flamingo flamingo = new Flamingo("Beatrice", 3, 3, 2.5, 4, 2.5, true);
                Swan swan = new Swan("Pearl", 6, 5, 2.2, 4, 2.2, false);
                Wolfman wolfman = new Wolfman("Delulu", 28, 85, 1.78, 4, true);

                List<Animal> animals = new List<Animal>() { horse, dog, hedgehog, worm, bird, wolf, pelican, flamingo, swan, wolfman };

                foreach (Animal animal in animals)
                {
                    Console.WriteLine($"{animal.GetType().Name}");
                    animal.DoSound();
                    if (animal is IPerson)
                    {
                        //animal as IPerson.Talk(); 
                        //ToDo: Find and implement solution for 3.4.7.
                    }
                }

                Dog dog2 = new Dog("Arrak", 4, 21, 0.7, 4, false);
                Dog dog3 = new Dog("Onyx", 5, 22, 0.7, 4, true);
                Dog dog4 = new Dog("Jet", 6, 23, 0.7, 4, false);
                Dog dog5 = new Dog("Obsidian", 7, 24, 0.7, 4, true);
                Dog dog6 = new Dog("Hematite", 8, 25, 0.7, 4, false);
                Dog dog7 = new Dog("Vanta", 9, 26, 0.7, 4, true);
                Dog dog8 = new Dog("Coke", 10, 27, 0.7, 4, false);

                List<Dog> dogs = new List<Dog>() { dog, dog2, dog3, dog4, dog5, dog6, dog7, dog8 };
                //dogs.Add(horse);
                //3.4.9: A dog is an animal, and a horse is an animal, but a horse is not a dog, hence it can't be added to the list.

                //3.4.10: If by "all classes" you mean the ones made in 3.3, then the answer is a list of Animals.
                //If by "all classes" you mean ALL classes then perhaps a list of Classes?

                foreach (Animal animal in animals)
                {
                    Console.WriteLine($"{animal.Stats()}");
                    //3.4.13: On each of the animals in the list pull print the string built by the method Stats() that is the most specific available to the subclass of said animal.
                }

                Console.WriteLine();

                foreach (Animal animal in animals)
                {
                    if(animal is Dog)
                    { 
                        Console.WriteLine($"{animal.Stats()}");
                    }
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {

            }
        }
    }
}
