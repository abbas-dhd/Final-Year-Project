using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuizController : MonoBehaviour
{
    QuizObject quizObject;
    ToggleGroup toggleGroup;

    [SerializeField] TextMeshProUGUI question_TMP;
    [SerializeField] Toggle optionA_Toggle;
    [SerializeField] Toggle optionB_Toggle;
    [SerializeField] Toggle optionC_Toggle;
    [SerializeField] Toggle optionD_Toggle;
    void Start()
    {
        toggleGroup = GetComponentInChildren<ToggleGroup>();

        //quizObject = GetComponent<QuizObject>();
        question_TMP.text = LoadQuizScene.instance.quizObject.question;
        optionA_Toggle.GetComponentInChildren<Text>().text = LoadQuizScene.instance.quizObject.optionA;
        optionB_Toggle.GetComponentInChildren<Text>().text = LoadQuizScene.instance.quizObject.optionB;
        optionC_Toggle.GetComponentInChildren<Text>().text = LoadQuizScene.instance.quizObject.optionC;
        optionD_Toggle.GetComponentInChildren<Text>().text = LoadQuizScene.instance.quizObject.optionD;
        Destroy(LoadQuizScene.instance);
    }

    public void SubmitHandler()
    {
        Toggle selectedAnswer = toggleGroup.ActiveToggles().FirstOrDefault();

        if (LoadQuizScene.instance.quizObject.GetAnswer().ToString().Equals(selectedAnswer.name))
        {
            Debug.Log("Correct Answer");
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
        Debug.Log(selectedAnswer.name + " = " + selectedAnswer.GetComponentInChildren<Text>().text);
    }
}
