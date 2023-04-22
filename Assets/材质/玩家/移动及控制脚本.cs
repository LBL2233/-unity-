using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 移动及控制脚本 : MonoBehaviour
{
    public float 速度 = 6;
    Vector3 XZ;
    public static Vector3 PO;
    Vector3 子弹生成位置;
    public GameObject 子弹预设体;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float V = Input.GetAxis("Vertical");
        float H = Input.GetAxis("Horizontal");
        PO=new Vector3(H,0,V);
        PO = PO.normalized;
        //Debug.Log(PO);
        //transform.Translate(H * 速度 * Time.deltaTime, 0, V * 速度 * Time.deltaTime);
        transform.position += PO * 速度 * Time.deltaTime;
        //Debug.Log($"横向:{H},纵向:{V}");

        //注释掉此段代码是为了鼠标能够控制朝向，避免争夺。
        //if (PO.magnitude > 0.1f)
        //{
        //    transform.forward = PO;
        //}

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }

        XZ = transform.position;
        if (XZ.x>31.5F)
        {
            XZ.x = 31.5F;
        }
        if (XZ.x < -31.5F)
        {
            XZ.x = -31.5F;
        }
        if(XZ.z < -19.4F)
        {
            XZ.z = -19.4F;
        }
        if (XZ.z > 19.4F)
        {
            XZ.z = 19.4F;
        }
        transform.position = XZ;
    }
    void Fire()
    {
        子弹生成位置 = GameObject.Find("Cube").transform.position;
        GameObject ZD = Instantiate(子弹预设体, 子弹生成位置, Quaternion.identity);
        ZD.transform.position = transform.position + transform.forward * 1.0f;
        ZD.transform.forward = transform.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Time.timeScale = 0;
        }
    }
}
