using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    [Header("References")]
    public Camera mainCamera;

    private Vector2 movDir = new Vector2(0, 0);
    private Vector2 aimDir = new Vector2(0, 0);

    private void OnMove(InputValue dirVal)
    {
        movDir = dirVal.Get<Vector2>();

        if(movDir.magnitude > 0) parent.setData(movDir, aimDir, "move");
        else parent.setData(movDir, aimDir, "idle");
    }

    private void OnLook(InputValue posVal)
    {
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(posVal.Get<Vector2>());
        aimDir = worldPos - (Vector2)transform.position;
        aimDir.Normalize();
    }
}
