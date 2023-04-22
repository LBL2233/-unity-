using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static 移动及控制脚本;

public class 发射子弹 : MonoBehaviour
{
    public float 子弹生命周期 = 1.5F;
    float startTime;
    public float 子弹速度 = 30;
    GameObject 方向绑定;
    // Start is called before the first frame update
    void Start()
    {
        方向绑定 = GameObject.Find("Cube");
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += 子弹速度 * transform.forward * Time.deltaTime;
        if (startTime+ 子弹生命周期<Time.time)
        {
            Destroy(gameObject);
        }
    }
}