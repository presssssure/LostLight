using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopOutPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopOut(Vector3 direction, float distance)
    {
        Instantiate(toclone, Position, Rotation, Quaternion.Identity);
    }
}
