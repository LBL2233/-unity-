using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 摄像机跟随脚本 : MonoBehaviour
{
    Transform FollowObject;
    GameObject Obj;
    Vector3 偏移量;
    // Start is called before the first frame update
    void Start()
    {
        Obj = GameObject.Find("Capsule");
        FollowObject = Obj.GetComponent<Transform>();
        偏移量 = transform.position - FollowObject.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = FollowObject.position + 偏移量;
        //Debug.Log(FollowObject.position);
    }
}
