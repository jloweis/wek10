using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ScoreBoard;
    public SCoreKeeper ScoreKeeper;
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard.text = "Current Score: " + ScoreKeeper.CurrentScore; 
    }

    // Update is called once per frame
    public void UpdateScore()
    {
         ScoreBoard.text = "Current Score: " +  ScoreKeeper.CurrentScore; 
    }
}
