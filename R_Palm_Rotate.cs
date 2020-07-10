using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Palm_Rotate : MonoBehaviour
{
    public SerialInput i1;
    public SerialInput2 i2;
    public finger1_1rotate f11;
    public finger1_2rotate f12;
    float old_data11 = 0;
    float old_data12 = 0;

    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation,
            Quaternion.Euler(-i1.daty, 0, i1.datx), Time.deltaTime * 500);
        if (old_data11 > i2.dat1)
            f11.updatef11down();
        if (old_data11 < i2.dat1)
            f11.updatef11up();
        old_data11 = i2.dat1;

        if (old_data12 > i2.dat2)
            f12.updatef12down();
        if (old_data12 < i2.dat2)
            f12.updatef12up();
        old_data12 = i2.dat2;

        
    }
}
