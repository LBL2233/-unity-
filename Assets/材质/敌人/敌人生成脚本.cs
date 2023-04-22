using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 敌人生成脚本 : MonoBehaviour
{

    public GameObject 敌人预设体;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            敌人生成();
        }
    }

    void 敌人生成()
    {
        // 创建一个随机数生成器
        System.Random random = new System.Random();

        // 生成一个随机数，范围是-100到100
        double number = random.NextDouble() * 200 - 100;

        // 如果随机数的绝对值小于12，就加上或减去24，使其大于12或小于-12
        if (Math.Abs(number) < 12)
        {
            number += Math.Sign(number) * 24;
        }

        // 如果随机数的绝对值大于30，就除以一个随机的整数，使其小于30或大于-30
        if (Math.Abs(number) > 30)
        {
            number /= random.Next(2, 10);
        }

        // 将随机数保留一位小数
        number = Math.Round(number, 1);

        // 生成一个随机数，范围是-100到100
        double number2 = random.NextDouble() * 200 - 100;

        // 如果随机数的绝对值小于12，就加上或减去24，使其大于12或小于-12
        if (Math.Abs(number2) < 12)
        {
            number2 += Math.Sign(number2) * 24;
        }

        // 如果随机数的绝对值大于30，就除以一个随机的整数，使其小于30或大于-30
        if (Math.Abs(number2) > 30)
        {
            number2 /= random.Next(2, 10);
        }

        // 将随机数保留一位小数
        number2 = Math.Round(number2, 1);


        GameObject E_CLONE = Instantiate(敌人预设体, new Vector3((float)number, 1F, (float)number2), Quaternion.identity);

    }

}
