using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    public float left_limit_s1 = 81; //_s1 추가
    public float right_limit_s1 = 433; //수정
    
    public float left_limit_s2 = 650; //수정
    public float right_limit_s2 = 948; //수정    

    //public float left_limit_s3 = 650; //수정
    //public float right_limit_s3 = 948; //수정


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec3 = new Vector3();
        vec3.x = player.position.x;

        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 1) {
            if (player.position.x < left_limit_s1) vec3.x = left_limit_s1; //_s1 추가
            else if (player.position.x >= right_limit_s1) vec3.x = right_limit_s1; //수정
        }        
        
        if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 2) {
            if (player.position.x < left_limit_s2) vec3.x = left_limit_s2; //수정
            else if (player.position.x >= right_limit_s2) vec3.x = right_limit_s2; //수정
        }        

        /*if (GameObject.Find("스테이지 매니저").GetComponent<StageManager>().stage == 3) {
            if (player.position.x < left_limit_s3) vec3.x = left_limit_s3; //수정
            else if (player.position.x >= right_limit_s3) vec3.x = right_limit_s3; //수정
        }*/

        vec3.y = player.position.y + 27.50f;
        vec3.z  = player.position.z;
        transform.position = vec3;
    }
}
