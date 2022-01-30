using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgressTracker : MonoBehaviour
{
    private Transform finishLine, playerPos;

    private float distanceToFinish;

    private bool isFinished;

    void Start()
    {
        finishLine = GameObject.FindGameObjectWithTag("Finish Line").transform;
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        isFinished = false;
    }

    private void Update()
    {
        CheckDistance();
    }

    private void CheckDistance()
    {
        distanceToFinish = Mathf.Abs(Vector3.Distance(finishLine.position, playerPos.position));

        if ((int)distanceToFinish == 0 && !isFinished)
        {
            isFinished = true;
            distanceToFinish = 100;
            EventManager.OnLevelFinish?.Invoke();
        }
    }
}
