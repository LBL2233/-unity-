using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class 敌人移动 : MonoBehaviour
{
    Vector3 Mo;
    public float 敌人移动速度 = 1F;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Mo = GameObject.FindWithTag("Player").transform.position - transform.position;
        Mo = Mo.normalized;
        transform.position += Mo * 敌人移动速度 * Time.deltaTime;
        if (Mo.magnitude > 0.1f)
        {
            transform.forward = Mo;
        }
    }
}
