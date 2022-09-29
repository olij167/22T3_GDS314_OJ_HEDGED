using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AISpeedUp : MonoBehaviour
{
    [SerializeField] private RichAI chaserAI;
    [SerializeField] private GameTimer gameTimer;

    private void Start()
    {
        gameTimer = GameObject.FindGameObjectWithTag("GameTimer").GetComponent<GameTimer>();

        chaserAI = GetComponent<RichAI>();
    }

    public void IncreaseAISpeed()
    {
        chaserAI.maxSpeed++;
    }
}
