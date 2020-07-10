using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finger1_2rotate : MonoBehaviour
{
    Vector3 ori_coordinate12;
    Vector3 new_coordinate12;
    
    public void updatef12up()
    {
        ori_coordinate12 = this.transform.eulerAngles;
        new_coordinate12 = ori_coordinate12 + new Vector3(0, 0, 10);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.Euler(new_coordinate12), Time.deltaTime * 500);
    }

    public void updatef12down()
    {
        ori_coordinate12 = this.transform.eulerAngles;
        new_coordinate12 = ori_coordinate12 - new Vector3(0, 0, 10);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.Euler(new_coordinate12), Time.deltaTime * 500);
        
    }
}
