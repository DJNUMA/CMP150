using UnityEngine;
using System.Collections;
using System;


[Serializable]
public class CharacterControls : MonoBehaviour
{
    public KeyCode MoveForward = KeyCode.W;
    public KeyCode MoveBack = KeyCode.S;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveRight = KeyCode.D;
}

public class CharacterMovement : MonoBehaviour
{
    public CharacterControls controls = new CharacterControls();
    
    public float MoveSpeed = 5f;
    
    private float trueSpeed
    {
        get { return MoveSpeed * Time.deltaTime; }
    }
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
   
        if (Input.GetKey(MoveForward))
        {
            transform.Translate(transform.forward * trueSpeed);
        }
        if (Input.GetKey(MoveBack))
        {
            transform.Translate(transform.forward * -1 * trueSpeed);
        }
	    if (Input.GetKey(MoveRight)
        {
            transform.Translate(transform.right * trueSpeed);
        }
        if (Input.GetKey(MoveLeft)
        {
            transform.Translate(transform.right * -1 * trueSpeed);
        }

    }
}
