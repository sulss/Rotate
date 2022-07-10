using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform hedef;
    public int hýz;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(hedef.transform.position, hedef.transform.up, hýz * Time.deltaTime);

    }
}
