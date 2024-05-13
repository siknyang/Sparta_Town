using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera camera;
    public Transform characterPos;
    public Vector3 offset = new Vector3(0, 0, -10);

    private void Awake()
    {
        camera = Camera.main;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = characterPos.position + offset;
        camera.transform.position = newPosition;
    }
}
