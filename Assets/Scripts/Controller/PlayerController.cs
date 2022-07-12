using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class PlayerController : SpaceController,Ihit
{
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Move(new Vector3(horizontal,vertical,0));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void OnHit()
    {
        Creater.Instance.CreateExplosion(transform.position);
        Destroy(gameObject);
    }
}