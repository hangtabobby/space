using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class BulletController : MoveController
{

    private int timeCount=0;

    private float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount++;
        if (timeCount==500)
        {
            Destroy(gameObject);
            return; 
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 0.5f);
        if (hit.transform!=null && tag != hit.transform.tag)
        {
            Ihit iHit = hit.transform.GetComponent<Ihit>();
            if (iHit != null)
            {
                iHit.OnHit();
            }
        }
        Move(transform.up);
    }
}
