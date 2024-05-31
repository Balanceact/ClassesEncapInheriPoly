

namespace Classes_Encap_Inheri_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Person testPerson1 = new Person("Patrik", "Persson", 35, 175, 80);
                //Person testPerson2 = new Person("Peter", "Persson", 32);
                //Person testPerson3 = new Person("Hildar", "Johansson", 35, 167, 75);
                PersonHandler personHandler = new PersonHandler();
                Person testPerson4 = personHandler.CreatePerson("Hurtig", "Bulle", 43, 178, 70);
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
