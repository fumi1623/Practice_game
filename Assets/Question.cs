using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Question : MonoBehaviour {
    // 名前：スタジオしまづ
    // 身長：163.0cm
    // 体重：44.5kg
    // 誕生日：5月7日
    bool myName = "スタジオしまづ";
    float height = 163.0;
    int weight = 44.5;
    string monthOfbirth = 5;
    Vector3 dayOfbirth = 7;

    void Start() {
        Debug.Log("名前：" + myName);
        Debug.Log("身長：" + height);
        Debug.Log("体重：" + weight);
        Debug.Log("誕生日：" + monthOfbirth + "月" + dayOfbirth + "日");
    }
}