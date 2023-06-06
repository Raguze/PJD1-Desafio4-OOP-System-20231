using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : BaseController
{
    [SerializeField]
    protected float Speed;
    [SerializeField]
    protected float Distance;
    [SerializeField]
    protected Vector2 StartPosition;


    public void SetTransform(Vector2 position, float rotation)
    {
        tf.position = position;
        tf.rotation = Quaternion.Euler(0, 0, rotation);

        StartPosition = position;
    }

    public void SetDTO(WeaponDTO dto)
    {
        Speed = dto.BulletSpeed;
        Distance = dto.Distance;

        rb.velocity = tf.rotation * new Vector2(0, Speed);
    }

    private void Update()
    {
        float currentDistance = Vector3.Distance(tf.position, StartPosition);
        if (currentDistance >= Distance)
        {
            Destroy(gameObject);
        }
        
    }

}
