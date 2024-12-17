using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed; // ��ת�ٶȣ����Ը�����Ҫ����
    public float rotationRange; // ��ת�Ƕȷ�Χ�����Ը�����Ҫ����

    private float rotationAngle = 0f; // ��ǰ��ת�Ƕ�
    private bool increasingAngle = true; // �Ƕ����ӻ���ٵı�־

    void Update()
    {
        // ���ݱ�־���ӻ���ٽǶ�
        if (increasingAngle)
        {
            rotationAngle += rotationSpeed * Time.deltaTime;
        }
        else
        {
            rotationAngle -= rotationSpeed * Time.deltaTime;
        }

        // ���Ƕȴﵽ���ֵ����Сֵʱ���ı����ӻ���ٵķ���
        if (rotationAngle >= rotationRange || rotationAngle <= -rotationRange)
        {
            increasingAngle = !increasingAngle;
        }

        // ��������ľֲ���ת�Ƕ�
        transform.localEulerAngles = new Vector3(0, 0, rotationAngle);
    }
}