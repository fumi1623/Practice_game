using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, 0, z)*0.1f;
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("ゲーム終了");
        SceneManager.LoadScene("SampleScene");
    }


}
