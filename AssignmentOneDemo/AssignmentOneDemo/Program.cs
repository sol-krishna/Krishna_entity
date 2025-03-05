using AssignmentOneDemo;
using Core.Entity;
using Infrastructure;

//var userA = new UserA();
//userA.FirstName = "Krishna";
//userA.LastName = "Solanki";
//userA.Age = 35;

//var userB = new UserB();

//foreach(var property in typeof(UserA).GetProperties())
//{
//    foreach(var propertyB in typeof(UserB).GetProperties())
//    {
//        if(property.Name == propertyB.Name && property.PropertyType == propertyB.PropertyType)
//        {
//            propertyB.SetValue(userB, property.GetValue(userA));
//        }
//    }   
//}

//Console.WriteLine(userB.FirstName);
//Console.WriteLine(userB.LastName);

class Program
{
    static void Main(string[] args)
    {
        var test = new User();  // Replace with the class containing your CRUD methods
        test.TestDatabase();  // Call TestDatabase to perform the CRUD operations
    }
}
