using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int CurrentScore
    {
        get
        {
            return currentScore;
        }
        set
        {
            currentScore = value;
        }
    }

    private static int  currentScore;
}
