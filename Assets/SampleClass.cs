using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SampleClass : MonoBehaviour
{
    
    void Update()
    {
        

    }
}

// キーボード入力を行ってコンソールにログを出す

//キーボードの横方向の入力を−１~１で受け付ける
//float x = Input.GetAxis("Horizontal");
//Debug.Log("x:" + x);
//float z = Input.GetAxis("Vertical");
//Debug.Log("z:" + z);

//キーボードの横方向の入力を−１, 0, １で受け付ける(raw)
//float rawX = Input.GetAxisRaw("Horizontal");
//Debug.Log("rawX:" + rawX);
//float rawZ = Input.GetAxisRaw("Vertical");
//Debug.Log("rawZ:" + rawZ);

//ボタン入力
//if (Input.GetButton("Jump")) {
//    Debug.Log("pushed spaceKey ");
//}

//if (Input.GetButtonDown("Jump")) {
//    Debug.Log("pushed spaceKey ");
//}

//if (Input.GetKeyDown(KeyCode.J)) {
//    Debug.Log("pushed J Key ");
//} 