using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;

    [SerializeField]
    private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        //Instatiate red object
        Instantiate(redObj, new Vector3(2,0,0), Quaternion.Euler(0, 0, 0));

        //Instantiate blue object
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
