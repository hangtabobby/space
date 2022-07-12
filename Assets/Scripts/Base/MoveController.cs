using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public int speed;
    protected virtual void Move(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
