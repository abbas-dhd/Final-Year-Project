using UnityEngine;

public class QuizObject : MonoBehaviour // this class contains all the information needed for a quiz.
{
    [SerializeField] public string question;
    [SerializeField] public string optionA;
    [SerializeField] public string optionB;
    [SerializeField] public string optionC;
    [SerializeField] public string optionD;
    [SerializeField] public char correctOption;

    public char GetAnswer()
    {
        return char.ToUpper(correctOption);
    }
}
