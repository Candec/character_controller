using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

[System.Serializable]
public class MoveInputEvent : UnityEvent<float, float> { }

[System.Serializable]
public class RunInputEvent : UnityEvent<bool> { }

public class InputManager : MonoBehaviour
{
    private Controls controls;
    public MoveInputEvent moveInputEvent;
    public RunInputEvent runInputEvent;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
        controls.Gameplay.Move.performed += OnMove;
        controls.Gameplay.Move.canceled += OnMove;
        controls.Gameplay.Run.performed += OnRun;
        controls.Gameplay.Run.canceled += OnRun;
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInputEvent.Invoke(moveInput.x, moveInput.y);
        //Debug.Log($"Move input: {moveInput}");
    }

    private void OnRun(InputAction.CallbackContext context)
    {
        bool runInput = context.ReadValueAsButton();
        runInputEvent.Invoke(runInput);
        //Debug.Log($"Run input: {runInput}");
    }
}
