using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject lantai;
    public GameObject tempatMuncul;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < lantai.transform.position.z - 1)
        {
            transform.position = tempatMuncul.transform.position;
        }
    }
}
