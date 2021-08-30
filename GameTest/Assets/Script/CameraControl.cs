using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ballPlayer;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ballPlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ballPlayer.transform.position + offset;
    }
}
