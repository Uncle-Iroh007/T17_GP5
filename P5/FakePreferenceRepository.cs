using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "1";

        private static Dictionary<string, string> innderDict;
        private static Dictionary<string, Dictionary<string, string>> Preferences;

        public FakePreferenceRepository()
        {

            if (Preferences == null)
            {
                innderDict = new Dictionary<string, string>();
                innderDict.Add("Background", "red");
                Preferences = new Dictionary<string, Dictionary<string, string>>();
                Preferences.Add("Naluca", innderDict);

                innderDict.Add("Foreground", "Black");
                Preferences.Add("Naluca", innderDict);
            }
        }

        public string GetPreference(string UserName, string PreferenceName)
        {
            string a = string.Empty;
            return a;
        }
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            string a = string.Empty;
            return a;

        }

    }
}
