using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreboardText;
    private TextMeshProUGUI timeRemainingText;
    private GameObject toggleGroup;
    private GameObject startButton;
    private GameObject spawnManager;
    private Animator playerAnimator;
    private ParticleSystem dirtSplatter;
    public static bool gameOver = true;
    private static float score;
    private AudioSource audioSource;
    private int timeRemaining = 60;
    private bool timedGame;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void DisplayUI()
    {

    }

    private void TimeCountdown()
    {

    }

    public void StartGame()
    {

    }

    private void EndGame()
    {

    }

    public void SetTimed(bool timed)
    {

    }

    public void ChangeScore(int change)
    {

    }



}
