using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBehaviour : MonoBehaviour
{
    public string targetState;
    public bool isOneshot;

    void execute(Vector2 moveDir, Vector2 aimDir, string returnState = "")
    {
        // If returnState is unknown for oneshot mode behaviours, the entity would not know which state to return to when execution has finished
        if(isOneshot && returnState == "")
        {
            Debug.LogError("returnState cannot be empty when behaviour is oneshot", this);
            return;
        }

        
    }
}
