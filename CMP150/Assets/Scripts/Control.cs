using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour
{
    public string Name = "Control";
    private List<ControllerInput> inputs = new List<ControllerInput>();
    public bool IsActive
    {
        get {return isActive;}
    }
    private bool isActive = false;
    
    public bool Activated
    {
        get { return activated; }
    }
    private bool activated = false;


    public bool Deactivated
    {
        get { return deactivated; }
    }
    private bool deactivated = false;
    
    void Start ()
    {

        foreach(var input in gameObject.GetComponents<ControllerInput>())
        {
            if(inputs.Contains(input)) continue;
            inputs.Add(input);
        }
    }
    void Update ()
    {
        isActive = false;
        deactivated = false;
        activated = false;
        foreach (var input in inputs)
        {
            if(input.IsActive)
            {
                isActive = true;
                break;
            }
            if (input.Activated)
            {
                activated = true;
                break;
            }
            if (input.Deactivated)
            {
                deactivated = true;
                break;
            }
        }
    }
}

