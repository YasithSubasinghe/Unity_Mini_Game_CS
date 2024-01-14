using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//user interface

public class ScoreScript : MonoBehaviour
{
    public Text pointsText;
    public static int scoreReturn;


    private void UpdateUI()
    {
        scoreReturn = GameManager.scoreCount;
        pointsText.text = "Score: " + scoreReturn.ToString();

    }

    void Update()
    {
        UpdateUI();
    }


}
