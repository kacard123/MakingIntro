using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiceController : MonoBehaviour
{
    void Start() {
        
    }

    void Update() {
        // 프레임마다 낙하시킨다
        transform.Translate(0, -0.1f, 0);

        // 화면 밖으로 나오면 오브젝트 소멸시킴
        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }
    }
}
