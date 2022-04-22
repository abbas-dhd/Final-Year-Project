using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadQuizScene : MonoBehaviour
{
    public static LoadQuizScene instance;
    public QuizObject quizObject;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        // quizObject = GetComponent<QuizObject>();
    }
    public void LoadScene()
    {
        quizObject = GetComponent<QuizObject>();
        instance.quizObject = quizObject;
        SceneManager.LoadScene(1);
    }
}
