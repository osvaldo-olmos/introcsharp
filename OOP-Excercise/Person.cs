namespace House
{
    public class Person
    {
        string Name {get;set;}
        public House MyHouse {get; set;}
        public Person(string name){
            Name =name;
        }

        public void ShowData(){
            System.Console.WriteLine($"Soy una persona llamada {Name}");
            MyHouse.ShowData();
            MyHouse.MyDoor.ShowData();
        }
    }
}