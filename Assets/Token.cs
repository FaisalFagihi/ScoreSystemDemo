using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Score.CurrentScore++;
        gameObject.SetActive(false);
        
    }
}
