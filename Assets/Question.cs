using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "question",menuName ="ScriptableObjects/question")]
public class Question : ScriptableObject
{
    public string question;
    public string[] answers = new string[4];
    public int answerKey;


    
}
