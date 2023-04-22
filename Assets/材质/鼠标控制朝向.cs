using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 鼠标控制朝向 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) )
        {
            transform.forward = hit.point-transform.forward;
        }
    }
}
