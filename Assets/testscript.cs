using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Cube;
    void Start()
    {
        Debug.Log("abcd");
        Instantiate(Cube, new Vector3(-1.0f, 0.0f, 0.0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
