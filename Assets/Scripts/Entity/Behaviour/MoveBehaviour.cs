using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : BaseBehaviour
{
    public float speed = 0.1f;

    public override void exec(Vector2 moveDir, Vector2 aimDir, string returnState = "", float delta = 0)
    {
        base.exec(moveDir, aimDir, returnState, delta);

        transform.position += (Vector3)(moveDir * speed * delta);
    }
}
