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

    [SerializeField] Image afterScreen;

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
        afterScreen.gameObject.SetActive(false);
    }

    public void SubmitHandler()
    {
        Toggle selectedAnswer = toggleGroup.ActiveToggles().FirstOrDefault();
        TextMeshProUGUI text = afterScreen.GetComponentInChildren<TextMeshProUGUI>();

        if (LoadQuizScene.instance.quizObject.GetAnswer().ToString().Equals(selectedAnswer.name))
        {
            text.text = "Correct!";
            text.color = new Color(0f, 0.8113208f, 0f); // dark Green
            afterScreen.color = new Color(0.7877358f, 1f, 0.7877358f); // light Green
            Debug.Log("Correct Answer");
        }
        else
        {
            text.text = "Wrong";
            text.color = new Color(0.8113208f, 0f, 0f); // dark red
            afterScreen.color = new Color(1f, 0.7877358f, 0.7877358f); // light red
            // afterScreen.

            Debug.Log("Wrong Answer");
        }
        afterScreen.gameObject.SetActive(true);
        // Debug.Log(selectedAnswer.name + " = " + selectedAnswer.GetComponentInChildren<Text>().text);
    }

}
