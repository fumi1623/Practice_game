using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//当たり判定
public class CubeRigidbody : MonoBehaviour
{
    //ぶつかった時に実行されるもの（条件あり：どちらにもcolliderがある/Rigidbodyがついている）
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("イタイ");
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("トリガー");
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("exit");
    }
}

//Rigidbody rb;
//void Start()
//{
//    rb = GetComponent<Rigidbody>();
//    //rb.velocity = new Vector3(1, 0, 0);

//}

//// Update is called once per frame
//void Update()
//{
//    rb.AddForce(new Vector3(1, 0, 0));
//}