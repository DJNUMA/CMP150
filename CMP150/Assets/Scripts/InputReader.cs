using UnityEngine;
using System.Collections;

public class InputReader : MonoBehaviour
{

    public Control ControlInput;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (ControlInput.IsActive)
        {
            Debug.Log("Ya Done Goofed Up.");
        }
        if (ControlInput.Activated)
        {
            Debug.Log("Tis On Good Sir.");
        }
        if (ControlInput.Deactivated)
        {
            Debug.Log("Tis Off Good Sir.");
        }
	}
}
