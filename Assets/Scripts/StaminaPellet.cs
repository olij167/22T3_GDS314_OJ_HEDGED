using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Toolbelt_OJ;

public class StaminaPellet : MonoBehaviour
{
    PlayerController playerController;
    [SerializeField] float staminaBoost;
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerController.stamina += staminaBoost;
            Destroy(gameObject);
        }
    }
}
