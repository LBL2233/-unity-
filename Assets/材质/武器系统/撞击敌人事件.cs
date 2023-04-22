using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static 敌人移动;

public class 撞击敌人事件 : MonoBehaviour
{
        public float 敌人初始生命 = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
