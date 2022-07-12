using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class EnemyController : SpaceController,Ihit
{
    int timeCountChangeDirection =0;
    Vector3 direction = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (timeCountChangeDirection == 0)
        {
            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeCountChangeDirection = Random.Range(1, 1000);
            timeCountChangeDirection = Random.Range(1, 1000);
        }
        timeCountChangeDirection--;
        Move(direction);
        if (Random.Range(1,10000)%500 == 0)
        {
            Shoot();
        }
    }
    public void OnHit()
    {
        Observer.Instance.Notify(Observerkey.ENEMY_DIE);
        Creater.Instance.CreateExplosion(transform.position);
        Destroy(this.gameObject);
    }
}
