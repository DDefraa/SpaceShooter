using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public GameObject spawnManager;
    public GameObject speederManager;
    public GameObject tankManager;


    

    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);

        scoreText.text = "SCORE: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {

        score += 1;
        scoreText.text = "SCORE: " + score.ToString();

        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);

        if (score <= 5)
        {
            spawnManager.SetActive(true);
            speederManager.SetActive(false);

        }
        else if (score <= 10)
        {

            speederManager.SetActive(true);
            spawnManager.SetActive(false);
        }
        else if (score <= 15)
        {
            spawnManager.SetActive(false);
            speederManager.SetActive(false);
            tankManager.SetActive(true);
        }
     


    }


}
