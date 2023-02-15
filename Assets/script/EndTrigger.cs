using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject CompleteLevel;

    private void OnTriggerEnter(Collider other)
    {
        CompleteLevel.SetActive(true);
        gameManager.CompleteLevel();
    }
}
