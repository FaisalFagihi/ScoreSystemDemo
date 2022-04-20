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
    [SerializeField]
    public AudioClip winClip;
    [SerializeField]
    public AudioClip LoseClip;
    private AudioSource audioSource;

    void Start()
    {
        Zone.ZoneHitHandler += OnZoneHit;

        audioSource = GetComponent<AudioSource>();
    }

    private void OnZoneHit(object sender, bool isWinZone)
    {
        if (isWinZone)
        {
            audioSource.clip = winClip;
        }
        else
        {
            audioSource.clip = LoseClip;

        }
        menu.DisplayScore(Score.CurrentScore, firstHighScoreValue, secondHighScoreValue, thirdHighScoreValue);
        audioSource.Play();
    }

    public void Restart()
    {
        Score.CurrentScore = 0;
        menu.gameObject.SetActive(false);
        tokens.ForEach(t => t.gameObject.SetActive(true));
        Time.timeScale = 1;
    }
}
