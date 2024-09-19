using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] GameObject QuizPanel;
    [SerializeField] GameObject StartPanel;
    [SerializeField] GameObject FirstQuestionPanel;
    [SerializeField] GameObject SecondQuestionPanel;
    [SerializeField] GameObject ThirdQuestionPanel;
    [SerializeField] GameObject ResultsPanel;
    [SerializeField] TextMeshProUGUI ScoreDisplay;
    int count = 0;

    public void openQuizPanel()
    {
        QuizPanel.SetActive(true);
        StartPanel.SetActive(true);
        FirstQuestionPanel.SetActive(false);
        SecondQuestionPanel.SetActive(false);
        ThirdQuestionPanel.SetActive(false);
        ResultsPanel.SetActive(false);
        count = 0;
    }

    public void startQuiz()
    {
        StartPanel.SetActive(false);
        FirstQuestionPanel.SetActive(true);
    }

    public void closeQuiz()
    {
        QuizPanel.SetActive(false);
    }

    public void answerAQ1()
    {
        FirstQuestionPanel.SetActive(false);
        SecondQuestionPanel.SetActive(true);
    }

    public void answerBQ1()
    {
        FirstQuestionPanel.SetActive(false);
        SecondQuestionPanel.SetActive(true);
        scoreCounter();
    }

    public void answerAQ2()
    {
        SecondQuestionPanel.SetActive(false);
        ThirdQuestionPanel.SetActive(true);
        scoreCounter();
    }

    public void answerBQ2()
    {
        SecondQuestionPanel.SetActive(false);
        ThirdQuestionPanel.SetActive(true);
    }

    public void answerAQ3()
    {
        ThirdQuestionPanel.SetActive(false);
        ResultsPanel.SetActive(true);
        scoreCounter();
        displayScore();
    }

    public void answerBQ3()
    {
        ThirdQuestionPanel.SetActive(false);
        ResultsPanel.SetActive(true);
        displayScore();
    }

    public void scoreCounter()
    {
        count = count + 1;
    }

    public void displayScore()
    {   
        if (count == 3) {
            ScoreDisplay.text = "You answered " + count + "/3 correctly!";
        } 
        else
        {
            ScoreDisplay.text = "You answered " + count + "/3 correctly";
        }
    }
}
