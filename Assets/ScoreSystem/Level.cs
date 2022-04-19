using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField]
    private Menu menu;
    [SerializeField]
    private int firstHighScoreValue;
    [SerializeField]
    private int secondHighScoreValue;
    [SerializeField]
    private int thirdHighScoreValue;
    // Start is called before the first frame update
    [SerializeField]
    List<Token> tokens;
    void Start()
    {
        DeathArea.DeathHandler += OnDie;
    }

    private void OnDie(object sender, object value)
    {
        menu.DisplayScore(Score.CurrentScore, firstHighScoreValue, secondHighScoreValue, thirdHighScoreValue);
    }

    public void Restart()
    {
        Score.CurrentScore = 0;
        menu.gameObject.SetActive(false);
        tokens.ForEach(t => t.gameObject.SetActive(true));
        Time.timeScale = 1;
    }
}
