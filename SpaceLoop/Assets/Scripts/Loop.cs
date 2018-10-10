using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {
    public GameObject objPreFab;
    GameObject objInstance;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("ObjFactory", 0f, 3f);
    }

    void ObjFactory()
    {
        objInstance = Instantiate(objPreFab, transform.position, transform.rotation);
        Destroy(objInstance, 10f);
    }

    // Update is called once per frame
    void Update () {

	}
}
