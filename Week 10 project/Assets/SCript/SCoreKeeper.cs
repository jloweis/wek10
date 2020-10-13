using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SCoreKeeper : MonoBehaviour
{
    private int currentScore;
    public int CurrentScore
    {
        get
        {
            return(currentScore);
        }
    }
    public int pointsPerCoin;
    public UIManager UIManager;

    // Start is called before the first frame update
    void Start()
    {
       currentScore = 0;
    }

    public void IncrementScore()
    {
        currentScore += pointsPerCoin;
        UIManager.UpdateScore();
    }
}
