using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    //refernces cus im lazy
    public TextMeshProUGUI questionField;
    public TextMeshProUGUI[] answerButtons;
    public Question[] questions;
    public TextMeshProUGUI scoreField;
    //
    public int score = 0;
    public int currentQuestion;
    private void Start()
    {
        NewQuestion();
    }
    public void NewQuestion()
    {
        if(currentQuestion==-1)
        {
            questionField.text = "no more questions";
            return;
        }
        questionField.text = questions[currentQuestion].question;

        for (int i = 0; i < 4; i++)
        {
            answerButtons[i].text = questions[currentQuestion].answers[i];

        }
    }
    

    public void answerPressed(int answerKey)
    {
        if (currentQuestion == -1) return;
        if (answerKey == questions[currentQuestion].answerKey) score++;
        scoreField.text = $"Score:{score}";
        currentQuestion++;
        if (currentQuestion > questions.Length - 1) currentQuestion = -1;


        NewQuestion();
       
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
