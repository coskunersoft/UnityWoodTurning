using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class tool : MonoBehaviour
{

    private void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        transform.position = pos;
    }

  
    private void OnTriggerStay2D(Collider2D _collision)
    {

        

        if (_collision.transform.CompareTag("wood"))
        {
            _collision.GetComponent<Wood>().TouchMe();
        }
    }

   
}
