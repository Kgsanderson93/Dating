using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField, Tooltip("the current score")] private float currentScore = 0;
    [SerializeField, Tooltip("the text box for the player's score")] private TMP_Text scoreText;
    [SerializeField, Tooltip("the rate at which the score increase per second")] private float pointsPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;

        UpdateScoreText();
    }

    void FixedUpdate()
    {
        float pointsRate = pointsPerSecond;

        pointsRate += Mathf.Max(3, 0);
        IncreaseScore(pointsRate * Time.fixedDeltaTime);
    }

    public void IncreaseScore(float score)
    {
        //Debug.Log("added points");
        currentScore += score;


        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = ((int)currentScore).ToString();
    }

}
