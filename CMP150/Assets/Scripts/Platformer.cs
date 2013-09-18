using System;
using System.Collections;
using UnityEngine;

public static class Extensions
{
    public static bool has<T>(this Enum type, T value)
    {
        try
        {
            return (((int)(object)type & (int)(object)value) == (int)(object)value);
        }
        catch
        {
            return false;
        }
    }
}
[RequireComponent(typeof(CharacterController))]
public class Platformer : myDerivedMono
{

        public Control  MoveLeft,
                        MoveRight,
                        Jump;

        public float Gravity = 9,
                     JumpStrength = 20,
                     MoveSpeed = 30;

	    private CharacterController controller;
        
        CollisionFlags prevFlags;
        void Start()
        {
        controller = GetComponent<CharacterController>();
        if(controller == null)
        {
            Debug.LogError("No Character Controller can be found on: ");
        }
	}
	
	void Update () 
    {
        Vector3 moveVec = Vector3.zero;

        if (MoveLeft.IsActive)
        {
            moveVec.x -= MoveSpeed;
        }
        if (MoveRight.IsActive)
        {
            moveVec.x += MoveSpeed;
        }
        if (Jump.IsActive)
        {
            moveVec.y = JumpStrength;
        }
        if(!prevFlags.has(CollisionFlags.CollidedBelow))
        {
            moveVec.y -= Gravity;
        }
        prevFlags = controller.Move(moveVec*Time.deltaTime);

        //CollisionFlags flags = controller.Move(moveVec * Time.deltaTime);
        //if (flags.has(CollisionFlags.CollidedSides))
        //{
        //    Debug.Log("I hit something! On the side!");
        //}

        //Homework is to implement Jumping.
	}
}
