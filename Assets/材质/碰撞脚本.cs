using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 碰撞脚本 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
