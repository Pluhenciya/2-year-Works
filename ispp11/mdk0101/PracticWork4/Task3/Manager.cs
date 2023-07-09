using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    internal class Manager
    {
        public static string path = $"{Environment.CurrentDirectory}/userData.txt";

        public static Frame MainFrame { get; set; }

        public static string[] userData = File.ReadAllLines(path);

        public static string theme = userData[3];

        public static void InstallTheme()
        {
            var uri = new Uri($"Themes/{Manager.theme}Them.xaml", UriKind.RelativeOrAbsolute);
            ResourceDictionary dict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }

        public static string GetHash(string text)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(text);
            byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            return Convert.ToHexString(hashedBytes);
        }
    }
}
