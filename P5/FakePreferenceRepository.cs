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

        private static Dictionary<string, Dictionary<string, string>> Preferences;
       
        public FakePreferenceRepository()
        {
            if (Preferences == null)
            {
                Preferences = new Dictionary<string, Dictionary<string, string>>();
            }
        }
  
        //Gets preference of UserName, at key of PreferenceName
        public string GetPreference(string UserName, string PreferenceName)
        {
            if (!Preferences.ContainsKey(UserName) || !Preferences[UserName].ContainsKey(PreferenceName))
                return null;
            else
            {
                Dictionary <string,string> userDictionary = Preferences[UserName];
                return userDictionary[PreferenceName];
            }
        }
        //Adds a new preference to a user's key
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            //If the user key does not exist, create
            if(!Preferences.ContainsKey(UserName))
                Preferences.Add(UserName, new Dictionary<string, string>());
            //If the preference is not already a key for the user, add
            if (!Preferences[UserName].ContainsKey(PreferenceName))
                Preferences[UserName].Add(PreferenceName, Value);

            return NO_ERROR;
        }

    }
}
