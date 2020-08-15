using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotspeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotspeed = 10;
        }

        if (Input.GetMouseButtonDown(1))//오른쪽 클릭 시 정지
        {
            rotspeed = 0;
            if(transform.rotation.eulerAngles.z > 30 && transform.rotation.eulerAngles.z <= 90)
            {
                Debug.Log("운수대통");
            }
            else if(transform.rotation.eulerAngles.z > 90 && transform.rotation.eulerAngles.z <= 150)
            {
                Debug.Log("운수매우나쁨");
            }
            else if (transform.rotation.eulerAngles.z > 150 && transform.rotation.eulerAngles.z <= 210)
            {
                Debug.Log("운수보통");
            }
            else if (transform.rotation.eulerAngles.z > 210 && transform.rotation.eulerAngles.z <= 270)
            {
                Debug.Log("운수조심");
            }
            else if (transform.rotation.eulerAngles.z > 270 && transform.rotation.eulerAngles.z <= 330)
            {
                Debug.Log("운수좋음");
            }
            else
            {
                Debug.Log("운수나쁨");
            }
        }
        transform.Rotate(0, 0, rotspeed);
    }
}
