using System;


    public void DeleteUser(int userId)
    {
        using (var context = new YourDbContext())
        {
            var user = context.Users.FirstOrDefault(u => u.Id == userId); 

            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();  
            }
        }
    }


