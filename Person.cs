namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            System.Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
}
