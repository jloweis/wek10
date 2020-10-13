using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCoreKeeper : MonoBehaviour
{
    private int currentScore;
    public int pointsPerCoin;


    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void IncrementScore()
    {
        currentScore += pointsPerCoin;
        Debug.Log(currentScore);
    }
}
