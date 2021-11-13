using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    void Start()
    {
         
    }

    void Update()
    {
        
    }
    
    private void OnMove(InputValue dirVal)
    {
        if (disableDirectional) return;
        movDir = dirVal.Get<Vector2>();

        if(movDir.magnitude > 0) inputData.setData("move", moveDir, aimDir);
        else inputData.setData("idle", moveDir, aimDir);
    }

    private void OnAim(InputValue posVal)
    {
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(posVal.Get<Vector2>());
        mouseDir = worldPos - gm.playerPosition;
        mouseDir.Normalize();
    }
}
