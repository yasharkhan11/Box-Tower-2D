using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    
    public float score;
    public float hiScore;

    void Start()
    {
        if(PlayerPrefs.HasKey("HiScore"))
         hiScore = PlayerPrefs.GetFloat("HiScore");
    }

    void Update()
    {
    
       if(score>hiScore){
           hiScore = score;
           PlayerPrefs.SetFloat("HiScore",hiScore);
       }
      scoreText.text = Mathf.Round(score).ToString();
      hiScoreText.text = Mathf.Round(hiScore).ToString();
    }
}
