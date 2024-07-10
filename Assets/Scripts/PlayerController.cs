using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private bool isGameOver;

    public PlayerInput PlayerInput {get => playerInput;}
    public bool IsGameOver {get => isGameOver; set { isGameOver = value; } }

    private void Awake()
    {
        this.isGameOver = false;
    }
    void Update()
    {
        var movementType = playerInput.PlayerMovementType;
        playerMovement.HandlePlayerMovement(movementType);
    }

}
