using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulationState : CharacterState
{
    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Character.Controller.MoveDirection;
        float moveSpeed = Character.GetMoveSpeed();
        float turnSpeed = Character.GetTurnSpeed();
        Quaternion rotationToMoveDirection = Quaternion.LookRotation(moveDirection);
        
        
        Character.transform.position += moveDirection * moveSpeed * Time.deltaTime;
        Character.transform.rotation = Quaternion.RotateTowards(Character.transform.rotation, rotationToMoveDirection, turnSpeed * Time.deltaTime);

    }
}
