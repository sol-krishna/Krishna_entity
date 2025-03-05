using System;

public class Class1
{
    public void AddUser(string name, string email)
    {
        using (var context = new YourDbContext())
        {
            var newUser = new User
            {
                Name = name,
                Email = email
            };

            context.Users.Add(newUser);  
            context.SaveChanges();  
        }
    }

}
