using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finger1_1rotate : MonoBehaviour
{
    Vector3 ori_coordinate;
    Vector3 new_coordinate;

    public void updatef11up()
    {
        ori_coordinate = this.transform.eulerAngles;
        new_coordinate = ori_coordinate + new Vector3(0, 0, 10);        
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.Euler(new_coordinate), Time.deltaTime * 500);        
    }

    public void updatef11down()
    {
        ori_coordinate = this.transform.eulerAngles;
        new_coordinate = ori_coordinate - new Vector3(0, 0, 10);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.Euler(new_coordinate), Time.deltaTime * 500);        
    }

    public void updatef11(float i)
    {
        ori_coordinate = this.transform.eulerAngles;
        new_coordinate = ori_coordinate + new Vector3(0, 0, i*2);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.Euler(new_coordinate), Time.deltaTime * 500);
    }
}
