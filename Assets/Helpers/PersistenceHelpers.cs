using System.IO;
using UnityEngine;

namespace OTools.Helpers
{
    public static class PersistenceHelpers
    {
        #region Player Prefs

        public static int GetInt(string key, int defaultValue)
        {
            if(!PlayerPrefs.HasKey(key))
                PlayerPrefs.SetInt(key, defaultValue);

            return PlayerPrefs.GetInt(key);
        }
        
        public static void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }
        
        public static float GetFloat(string key, float defaultValue)
        {
            if(!PlayerPrefs.HasKey(key))
                PlayerPrefs.SetFloat(key, defaultValue);

            return PlayerPrefs.GetFloat(key);
        }
        
        public static void SetFloat(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
        }
        
        public static string GetString(string key, string defaultValue)
        {
            if(!PlayerPrefs.HasKey(key))
                PlayerPrefs.SetString(key, defaultValue);

            return PlayerPrefs.GetString(key);
        }
        
        public static void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }
        
        public static bool GetBool(string key, bool defaultValue)
        {
            if(!PlayerPrefs.HasKey(key))
                PlayerPrefs.SetInt(key, defaultValue ? 1 : 0);

            return PlayerPrefs.GetInt(key) == 1;
        }
        
        public static void SetBool(string key, bool value)
        {
            PlayerPrefs.SetInt(key, value ? 1 : 0);
        }

        #endregion

        #region Json Save

        public static void SaveData<T>(T data, string relativePath)
        {
            string absolutePath = Application.persistentDataPath + relativePath;
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(absolutePath, json);
        }
        
        public static T LoadData<T>(string relativePath)
        {
            string absolutePath = Application.persistentDataPath + relativePath;
            if(!File.Exists(absolutePath))
                return default;

            string json = File.ReadAllText(absolutePath);
            return JsonUtility.FromJson<T>(json);
        }

        #endregion
    }
}