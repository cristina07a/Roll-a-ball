using UnityEngine;
using System.Collections;

public class Rotator1 : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(30, 60, 45) * Time.deltaTime);
    }
}