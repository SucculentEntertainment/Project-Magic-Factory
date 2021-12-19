using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float stiffness = 1f;
    public float zDistance = -10f;
    public GameObject target;

	private Vector3 initalOffset;
	private Vector3 cameraPosition;

    void Start()
    {
        if(target == null) return;

        transform.position = target.transform.position + new Vector3(0, 0, zDistance);
		initalOffset = transform.position - target.transform.position;
    }

    void FixedUpdate()
    {
        if (target == null) return;

		cameraPosition = target.transform.position + initalOffset;
		transform.position = Vector3.Lerp(transform.position, cameraPosition, stiffness * Time.fixedDeltaTime);
    }
}
