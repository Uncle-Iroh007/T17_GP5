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
        public const string PREFERENCE_PROJECT_ID = "Project_Id";
        public const string PREFRENCE_PROJECT_NAME = "Project_Name";
        private const string NO_ERROR = "";
        
        //Not sure why this is here, commenting it out for now.
        //private static Dictionary<string, string> innderDict;
        private static Dictionary<string, Dictionary<string, string>> Preferences;

       
        public FakePreferenceRepository()
        {
            if (Preferences == null)
            {
                Preferences = new Dictionary<string, Dictionary<string, string>>();
            }
        }
  
        public string GetPreference(string UserName, string PreferenceName)
        {
            string a = string.Empty;
            return a;
        }
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            Preferences.Add(UserName, new Dictionary<string, string>());
            Preferences[UserName].Add(PreferenceName, Value);
            return NO_ERROR;
        }

    }
}
