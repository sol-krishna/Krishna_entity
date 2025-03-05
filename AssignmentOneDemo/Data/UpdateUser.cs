using System;


    public void UpdateUser(int userId, string newName, string newEmail)
    {
        using (var context = new YourDbContext())
        {
            var user = context.Users.FirstOrDefault(u => u.Id == userId);  

            if (user != null)
            {
                user.Name = newName;  
                user.Email = newEmail;  

                context.SaveChanges();  
            }
        }
    }


