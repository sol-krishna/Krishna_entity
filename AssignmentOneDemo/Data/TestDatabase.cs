using System;

    public void TestDatabase()
    {

        Console.WriteLine("Before CRUD operations:");
        var usersBefore = ListAllUsers();
        foreach (var user in usersBefore)
        {
            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }


        AddUser("Alice", "alice@example.com");
        Console.WriteLine("\nAfter adding a user:");
        var usersAfterAdd = ListAllUsers();
        foreach (var user in usersAfterAdd)
        {
            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }


        UpdateUser(1, "Alice Updated", "alice.updated@example.com");
        Console.WriteLine("\nAfter updating a user:");
        var usersAfterUpdate = ListAllUsers();
        foreach (var user in usersAfterUpdate)
        {
            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }


        DeleteUser(1);
        Console.WriteLine("\nAfter deleting a user:");
        var usersAfterDelete = ListAllUsers();
        foreach (var user in usersAfterDelete)
        {
            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }
    }
