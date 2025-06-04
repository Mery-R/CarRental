using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Car_Rental
{
    public enum UserRole
    {
        Employee,
        Admin
    }

    public class User
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public UserRole Role { get; set; }
    }

    public class UserStore
    {
        private const string FilePath = "users.json";
        public List<User> Users { get; private set; } = new();

        public UserStore()
        {
            Load();
        }

        public void AddUser(string username, string password, UserRole role)
        {
            Users.RemoveAll(u => u.Username == username);
            Users.Add(new User { Username = username, Password = password, Role = role });
            Save();
        }

        public User? ValidateUser(string username, string password)
        {
            return Users.Find(u => u.Username == username && u.Password == password);
        }

        public void Load()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                Users = JsonSerializer.Deserialize<List<User>>(json) ?? new();
            }
            else
            {
                Users = new List<User> { new User { Username = "Mery", Password = "123", Role = UserRole.Admin } };
                Save();
            }
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}