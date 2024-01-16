using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정한다.
        if (Input.GetMouseButtonDown(0)) // 클릭되었는지 확인하기 위해 GetMouseButtonDown 매서드 사용 (클릭된 순간 true를 반환)
        {
            this.rotSpeed = 10;
        }

        // 회전 속도만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);

        // 룰렛을 감속시킨다. (추가)
        this.rotSpeed *= 0.95f; // 곱하는 숫자를 점점 작게 할수록 룰렛이 오랫동안 돌다가 멈춘다.

    }
}
