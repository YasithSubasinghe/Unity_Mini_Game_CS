using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText; //create variable for score text

    public static int scoreCount; //create variable for count Score

    void Start()
    {
        scoreCount = 0;
        StartCoroutine(CountScore());
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    IEnumerator CountScore()
    {
        yield return new WaitForSeconds(1f);

        scoreCount++;

        StartCoroutine(CountScore());
    }
    private void UpdateUI()
    {
        scoreText.text="Score: "+scoreCount.ToString();
    }
     
}
