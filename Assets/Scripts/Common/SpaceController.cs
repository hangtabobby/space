using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class SpaceController : MoveController
{
    public Transform tranShoot;
    public int minX, minY;
    public int maxX, maxY;

    protected override void Move(Vector3 direction)
    {
        if (transform.position.y > maxY || transform.position.y < minY || transform.position.x > maxX || transform.position.x < minX)
        {
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, minX, maxX),
                Mathf.Clamp(transform.position.y, minY, maxY));
        }
        base.Move(direction);
    }

    public void Shoot()
    {
        BulletController bullet = Creater.Instance.CreateBullet(tranShoot);
        bullet.tag = tag;
    }

}
