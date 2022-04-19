using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private Text scoreLable;
    [SerializeField]
    private Button restartButton;
    [SerializeField]
    private Image firstHighScoreImage;
    [SerializeField]
    private Image secondHighScoreImage;
    [SerializeField]
    private Image thirdHighScoreImage;
    // Start is called before the first frame update
    public void DisplayScore(int currentScore, int firstHighScoreValue, int secondHighScoreValue, int thirdHighScoreValue)
    {
        //Restart stars states
        firstHighScoreImage.gameObject.SetActive(false);
        secondHighScoreImage.gameObject.SetActive(false);
        thirdHighScoreImage.gameObject.SetActive(false);

        scoreLable.text = $"Score: {currentScore}";

        this.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);   
        CheckHighScore(currentScore, firstHighScoreValue, firstHighScoreImage);
        CheckHighScore(currentScore, secondHighScoreValue, secondHighScoreImage);
        CheckHighScore(currentScore, thirdHighScoreValue, thirdHighScoreImage);
        Time.timeScale = 0;
    }

    private void CheckHighScore(int currentScore, int highScoreValue, Image highScoreImage)
    {
        if (currentScore >= highScoreValue)
        {
            highScoreImage.gameObject.SetActive(true);
        }
    }
}
