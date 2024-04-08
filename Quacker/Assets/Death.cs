using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Player"))
        {
            //float score = GameManager.GetCurrentScore();
            //Debug.Log(score);
            //GameManager.AddToOverallScore(score);
            //Debug.Log(GameManager.GetOverallScore());
            //GameOverScreen.SetActive(true);
            //Cursor.visible = true;
            //Destroy(this);
            SceneManager.LoadScene(2);
        }
    }
}
