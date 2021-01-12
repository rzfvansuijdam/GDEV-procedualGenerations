using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //Check collision name
       
        if (col.gameObject.name == "sand")
        {
            Destroy(col.gameObject);
        }
    }
}
