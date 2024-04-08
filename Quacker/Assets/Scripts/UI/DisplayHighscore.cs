using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHighscore : MonoBehaviour
{
    [SerializeField, Tooltip("the text box for the player's highscore")] private TMP_Text highscoreText1;
    [SerializeField, Tooltip("the text box for the player's highscore")] private TMP_Text highscoreText2;
    [SerializeField, Tooltip("the text box for the player's highscore")] private TMP_Text highscoreText3;
    // Start is called before the first frame update
    void Start()
    {
        highscoreText1.text = PlayerPrefs.GetFloat("Highscore 1", 0).ToString();
        highscoreText2.text = PlayerPrefs.GetFloat("Highscore 2", 0).ToString();
        highscoreText3.text = PlayerPrefs.GetFloat("Highscore 3", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
