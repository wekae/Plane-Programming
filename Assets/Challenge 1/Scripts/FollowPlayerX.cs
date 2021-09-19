using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(26.0f, 0.37f, 1.1f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Upldate is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
