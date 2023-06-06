using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController PlayerController;

    private Transform tf;

    private void Awake()
    {
        tf = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        Vector3 pos = PlayerController.Position;
        tf.position = new Vector3(pos.x, pos.y, tf.position.z);
    }

    private void Update()
    {
        
    }
}
