using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager 
{
    static int currentScore;
    static int endScore;

    //Puntutación Inicial y Final
    public static void SetValues(int newCurrentScore, int newEndScore)
    {
        currentScore = newCurrentScore;
        endScore = newEndScore;
    }

    //Sumar puntos
    public static void AddScore(int scoreAmmount)
    {
        if(currentScore + scoreAmmount >= endScore)
        {
            currentScore = endScore;
            Debug.Log("Congratulations!");
        }
        else
        {
            currentScore += scoreAmmount;
            Debug.Log(scoreAmmount);
        }
        Debug.Log(currentScore);
    }   
}
