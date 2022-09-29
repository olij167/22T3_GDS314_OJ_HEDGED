using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SetAITarget : MonoBehaviour
{
    AIDestinationSetter destinationSetter;

    private void Start()
    {
        destinationSetter = GetComponent<AIDestinationSetter>();

        destinationSetter.target = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
