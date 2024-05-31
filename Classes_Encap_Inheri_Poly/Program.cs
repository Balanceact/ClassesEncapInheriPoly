namespace Classes_Encap_Inheri_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person testPerson1 = new Person("Patrik", "Person", 35, 175, 80);
                Person testPerson2 = new Person("Peter", "Person", 32);
            }
            catch (ArgumentException)
            {

            }
            finally
            {

            }
        }
    }
}
