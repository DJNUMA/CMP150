using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class CharacterControls
{
    public Control moveForward;
    public Control moveBackward;
    public Control moveLeft;
    public Control moveRight;
    //public Control jump;
}

public class myDerivedMono : MonoBehaviour
{
    public float XPos
    {
        get { return transform.position.x; }
        set
        {
            Vector3 myPos = transform.position;
            myPos.x = value;
            transform.position = myPos;
        }
    }

    public float YPos
    {
        get { return transform.position.y; }
        set
        {
            Vector3 myPos = transform.position;
            myPos.y = value;
            transform.position = myPos;
        }
    }
}

public class CharacterMovement : myDerivedMono
{
    public float moveSpeed = 5f;
    public CharacterControls controls = new CharacterControls();

    private float trueSpeed
    {
        get { return moveSpeed * Time.deltaTime; }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //XPos = 0f;

        if (controls.moveForward.IsActive)
        {
            transform.Translate(transform.forward * trueSpeed);
        }

        if (controls.moveBackward.IsActive)
        {
            transform.Translate(transform.forward * -1 * trueSpeed);
        }

        if (controls.moveLeft.IsActive)
        {
            transform.Translate(transform.right * -1 * trueSpeed);
        }

        if (controls.moveRight.IsActive)
        {
            transform.Translate(transform.right * trueSpeed);
        }

        //if (controls.jump.IsActive)
        //{
          //  transform.Translate(transform.up * trueSpeed);
        //}
    }
}