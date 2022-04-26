using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 10;

    public Material material;

    public UnityEngine.GameObject nematode;

    public void Awake()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(nematode, new UnityEngine.Vector3(0,0,0), UnityEngine.Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
