using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MiningHelper.Helper
{
    public static class Settings
    {
        private static object? GetSettings(string name)
        {
            if (!Application.Current.Properties.Contains(name)) return null;
            return Application.Current.Properties[name];
        }

        private static void SetSettings(string name, object value)
        {
            Application.Current.Properties[name] = value;
        }

        private static string _adminrequired = "AdminRequired";
        public static bool AdminRequired { get { return (bool?)GetSettings(_adminrequired) ?? false; } set { SetSettings(_adminrequired, value); } }



    }
}
