using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class CreateController : MonoBehaviour
{
    public BulletController prebullet;
    public GameObject preExplosion;
    public EnemyController preEnemy;
    public BulletController CreateBullet(Transform tranPos)
    {
        return Instantiate(prebullet,tranPos.position, tranPos.rotation);
    }

    public void CreateExplosion(Vector3 pos)
    {
        Instantiate(preExplosion, pos, Quaternion.identity);
    }

    public void CreateEnemy(Vector3 pos)
    {
        Instantiate(preEnemy, pos, preEnemy.transform.rotation);
    }
}
public class Creater : SingletonMonoBehaviour<CreateController>{}