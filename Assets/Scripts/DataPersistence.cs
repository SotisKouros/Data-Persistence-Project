using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class DataPersistence : MonoBehaviour
{
    
    public string NameInput;
    public int HighScore = 0;
    public string HighScorerName;
    public static DataPersistence Instance;

    private void Awake()
    {
        Load();
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
      
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    [System.Serializable]
    class SaveData
    {
        public string HighScorerName;
        public int HighScore = 0;
        
    }
    
    public void Save()
    {
        SaveData data = new SaveData();
        data.HighScorerName = HighScorerName;
        data.HighScore = HighScore; 
        
        string json = JsonUtility.ToJson(data);
        
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        
    }
    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            

            HighScore = data.HighScore;
            HighScorerName = data.HighScorerName;
        }
    }

}
