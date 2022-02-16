using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform; // 움직일 자식 게임 오브젝트의 트랜스폼

    private void Start()
    {
        transform.position = new Vector3(0, -1, 0); // 자신의 전역 위치를 (0, -1, 0)으로 변경
        childTransform.localPosition = new Vector3(0, 2, 0);    // 자식의 지역 위치를 (0, 2, 0)으로 변경

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));   // 자신의 전역 회전을 (0, 0, 30)으로 변경
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0)); // 자식의 지역 회전을 (0, 60, 0)으로 변경
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime); // 위쪽 방향키를 누르면 초당 (0, 1, 0)의 속도로 평행이동
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);    // 아래쪽 방향키를 누르면 초당 (0, -1, 0)의 속도로 평행이동
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 100) * Time.deltaTime);  // 왼쪽 방향키를 누르면 자신을 초당 (0, 0, 100) 회전
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime); // 자식을 초당 (0, 180, 0) 회전
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime); // 오른쪽 방향키를 누르면 자신을 초당 (0, 0, -180) 회전
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);    // 자식을 초당 (0, -180, 0) 회전
        }
    }
}