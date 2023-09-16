using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UpdateUI : MonoBehaviour
{
    public GameObject dieObj;
    private TMP_Text dieText;
    private TMP_Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        dieObj = GameObject.Find("DieText");
        scoreText = GameObject.Find("Count").GetComponent<TMP_Text>();
        dieText = dieObj.GetComponent<TMP_Text>();

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayDie()
    {
        dieText.text = "YOU DIED";
    }

    public void CancelDie()
    {
        dieText.text = " ";
    }

    public void AddScore()
    {
        Debug.Log("add score");
        score += 1;
        scoreText.SetText("Waste can destroyed : " + score + "/3");
        if (score == 3)
        {
            dieText.text = "WIN!";
        }
    }
}
