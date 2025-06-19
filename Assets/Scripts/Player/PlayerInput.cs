using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private Yonverme inputActions;
    private PlayerMover playerMover;

    private void Awake()
    {
        inputActions = new Yonverme();
        playerMover = GetComponent<PlayerMover>();
    }

    private void OnEnable()
    {
        inputActions.haraket.Enable();
    }

    private void OnDisable()
    {
        inputActions.haraket.Disable();
    }

    private void Update()
    {
        Vector2 input = inputActions.haraket.harekett.ReadValue<Vector2>();
        playerMover.Move(input);
    }
}