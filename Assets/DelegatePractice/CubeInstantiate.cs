using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiate : MonoBehaviour
{

    [SerializeField] GameObject ICube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cube()
    {
        Instantiate(ICube, transform.position, transform.rotation);
    }

    public void Cube2()
    {
        Instantiate(ICube, new Vector3(0, 10, 0), transform.rotation);
    }

    //UnityEventの利点は複数の関数命令が可能。条件分岐が必要ない。

}
