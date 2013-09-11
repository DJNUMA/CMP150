using UnityEngine;
using System.Collections;

public abstract class ControllerInput : MonoBehaviour
{
    public bool Activated
    {
        get {return activated;}
    }
    public bool Deactivated
    {
        get {return deactivated;}
    }
    public bool IsActive
    {
        get {return isActive;}
    }
    protected bool isActive = false;
    protected bool activated = false;
    protected bool deactivated = false;
}