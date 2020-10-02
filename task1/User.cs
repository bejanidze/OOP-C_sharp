using System;
namespace Task1 {
    public class User {
        private static object sync = new object();
        private static int _id;
        public int id;
        public string Name;
        public string LastName;
        public string Address;

        public User(string name, string lastname, string address) {
            lock (sync)
            {
              id = _id++;
            }
            Name = name;
            LastName = lastname;
            Address = address;
        }

        public void GetMessage(User user, Message message) {
            Console.WriteLine($"User: {user.Name}\nTitle: {message.Title}\nContent: {message.Description}");
        }
    }
}