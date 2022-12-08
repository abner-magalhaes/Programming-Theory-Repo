using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    private static GameManager instance;
    public static GameManager Instance => instance;

    [Header("Track")]
    [SerializeField] private int currentCheckpoint = 0;
    [SerializeField] private int currentLap = 1;
    [SerializeField] private int totalLaps = 5;
    [SerializeField] private int position = 0;
    [SerializeField] private bool isFinished = false;
    [SerializeField] private List<Collider> checkpoints;

    public bool IsFinished => isFinished;
    public int CurrentLap => currentLap;
    public int TotalLaps => totalLaps;
    public int Position => position;

    void Start()
    {
        instance = this;
    }

    public bool VerifyCheckpoint(Collider checkpointCollider) => checkpointCollider == checkpoints[currentCheckpoint];
    public void IncreaseCheckpoint()
    {
        currentCheckpoint++;

        if (currentCheckpoint >= checkpoints.Count)
        {
            currentCheckpoint = 0;
            currentLap++;

            if(currentLap > totalLaps)
            {
                currentLap = 0;
                isFinished = true;
            }
        }
    }

}