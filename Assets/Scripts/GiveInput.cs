using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GiveInput : MonoBehaviour
{
    public InputField inputField;
    public TextMeshProUGUI txtHighScore;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    
    // Update is called once per frame
    void Update()
    {
       DataPersistence.Instance.NameInput = inputField.text;
            txtHighScore.text = "High Score: " + DataPersistence.Instance.HighScorerName + " " + DataPersistence.Instance.HighScore;
        
    }
    public void Begin()
    {
        
       
            DataPersistence.Instance.NameInput = inputField.text;
        
        if (DataPersistence.Instance.HighScorerName == "")
        {
            DataPersistence.Instance.HighScorerName = "Anonymous";
        }
    }
}
