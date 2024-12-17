using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed; // 旋转速度，可以根据需要调整
    public float rotationRange; // 旋转角度范围，可以根据需要调整

    private float rotationAngle = 0f; // 当前旋转角度
    private bool increasingAngle = true; // 角度增加或减少的标志

    void Update()
    {
        // 根据标志增加或减少角度
        if (increasingAngle)
        {
            rotationAngle += rotationSpeed * Time.deltaTime;
        }
        else
        {
            rotationAngle -= rotationSpeed * Time.deltaTime;
        }

        // 当角度达到最大值或最小值时，改变增加或减少的方向
        if (rotationAngle >= rotationRange || rotationAngle <= -rotationRange)
        {
            increasingAngle = !increasingAngle;
        }

        // 设置物体的局部旋转角度
        transform.localEulerAngles = new Vector3(0, 0, rotationAngle);
    }
}