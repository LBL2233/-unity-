using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 创建物体测试 : MonoBehaviour
{
    public GameObject 预制体;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = Instantiate(预制体, new Vector3(3,3,3),Quaternion.identity);
    }
}
