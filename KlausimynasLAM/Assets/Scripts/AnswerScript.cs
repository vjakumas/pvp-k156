using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect;

    [SerializeField]
    //private GameController gameController;
    private QuizController gameController;

    [SerializeField]
    private Image buttonImage;

    public Color startColor;

    [SerializeField]
    public Color correctColor;

    [SerializeField]
    public Color wrongColor;

    public Image originalEllipse;

    [SerializeField]
    private Sprite correctEllipse;

    [SerializeField]
    private Sprite incorrectEllipse;
    public void CheckAnswer()
    {
        if (isCorrect)
        {
            buttonImage.color = correctColor;
            originalEllipse.sprite = correctEllipse;
            gameController.Correct();
        }
        else
        {
            buttonImage.color = wrongColor;
            originalEllipse.sprite = incorrectEllipse;
            gameController.Wrong();
        }
    }
}