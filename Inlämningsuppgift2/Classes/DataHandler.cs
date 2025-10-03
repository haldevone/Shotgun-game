using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inlämningsuppgift2.Classes
{
    public static class DataHandler
    {
        static string path = @"C:\Users\HalDev\Desktop\.Net\shotgun\users.txt";
        static List<User> users = new List<User>();
        public static void Save(User user)
        {

            users = Load();
            if (!CheckExistingUser(user))
            {
                users.Add(user);
            }
            else
            {
                ReplaceUserScore(user);
            }


            string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(path, jsonString);
        }

        public static List<User> Load()
        {
            if (!File.Exists(path))
            {
                return users;
            }
            string loadJson = File.ReadAllText(path);
            if (!string.IsNullOrWhiteSpace(loadJson))
            {
                return users = JsonSerializer.Deserialize<List<User>>(loadJson);
            }
            return users;
        }

        private static bool CheckExistingUser(User user)
        {
            foreach (var item in users)
            {
                if (item.UserName == user.UserName)
                {
                    return true; 
                }
            }
            return false;
        }

        private static void ReplaceUserScore(User user)
        {
            foreach (var item in users)
            {
                if (item.UserName == user.UserName)
                {
                    item.MyScore = user.MyScore;
                }
            }
        }

    }
}
