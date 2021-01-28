using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        this.gameObject.transform.position += new Vector3(0, 0, 20 * Time.deltaTime);
    }
}
