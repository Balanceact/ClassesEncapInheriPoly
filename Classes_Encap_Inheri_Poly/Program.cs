

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

                Console.WriteLine("Before changes:");
                personHandler.PrintPerson(testPerson4);

                personHandler.SetFName(testPerson4, "Öjvid");
                personHandler.SetLName(testPerson4, "Haraldsson");
                personHandler.SetAge(testPerson4, 50);
                personHandler.SetWeight(testPerson4, 65);
                personHandler.SetHeight(testPerson4, 1.67);

                Console.WriteLine("After changes:");
                personHandler.PrintPerson(testPerson4);

                Console.WriteLine("Before changes:");
                personHandler.PrintPerson(testPerson5);

                personHandler.SetFName(testPerson5, "Karin");
                personHandler.SetLName(testPerson5, "Knutsson");
                personHandler.SetAge(testPerson5, 63);
                personHandler.SetWeight(testPerson5, 60);
                personHandler.SetHeight(testPerson5, 1.70);

                Console.WriteLine("After changes:");
                personHandler.PrintPerson(testPerson5);
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
