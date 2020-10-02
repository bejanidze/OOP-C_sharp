using System;
using System.Collections.Generic;
namespace Task1 {
    public class Program {
        static void Main(string[] args){
        List<List<string>> users = new List<List<string>>{};

        for(int i=0; i < 10; i++){
          users.Add(new List<string>{$"name{i}", $"lastname{i}", $"address{i}"});
        };

        for(int i=0; i<users.Count; i++){
              Console.WriteLine($"{i}: {users[i][0]} - {users[i][1]} {users[i][2]}");
        };
        
        Console.Write("Choose user by ID:");
        int subject = Convert.ToInt32(Console.ReadLine());

        while (subject > users.Count - 1) {
          Console.Write("User with this ID does not exists.\nTry again:");
          subject = Convert.ToInt32(Console.ReadLine());
        }

        User user = new User(users[subject][0], users[subject][1], users[subject][2]);
        Console.Write("Enter message title: ");
        string title = Console.ReadLine();
        Console.Write("Enter message description: ");
        string description = Console.ReadLine();
        Message message = new Message(title, description);
        Console.WriteLine($"Sending message to {users[subject][0]}");
        Post.SendMessage(user, message);
        }
    }
}