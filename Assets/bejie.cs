using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class bejie : MonoBehaviour
{
    GameObject pointer;

    [SerializeField] Material material;
    [SerializeField] float distance = 10;   //Lineの距離
    [SerializeField] float dropHeight = 5;　//Line高さ
    [SerializeField] int positionCount = 10;
    [SerializeField] float width = 0.1f;

    GameObject line;
    LineRenderer lRend;
    
    Vector3 p2;
    RaycastHit hit;

    float moveX;
    float moveYZ;
    float speed = 10;
    

    
    // Start is called before the first frame update
    void Start()
    {
        pointer = gameObject;
        InitLine();
    }

    // Update is called once per frame
    void Update()
    {
        Draw();

        moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        moveYZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        p2 += new Vector3(moveX, 0, moveYZ);

        

        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            transform.position = hit.point;
        }
        
        

        

        


    }

    void InitLine()
    {
        line = new GameObject("Line");
        line.transform.parent = pointer.transform;

        lRend = line.AddComponent<LineRenderer>();
        lRend.receiveShadows = false;
        lRend.shadowCastingMode = ShadowCastingMode.Off;
        lRend.loop = false;
        lRend.positionCount = positionCount;
        lRend.startWidth = width;
        lRend.endWidth = width;

        lRend.material = material;
    }

    void Draw()
    {
        Vector3 p0 = pointer.transform.position;
        Vector3 p1 = pointer.transform.position +  pointer.transform.forward * distance / 2;
        //p2 = pointer.transform.position + pointer.transform.forward * distance;
        p2.y = p0.y - dropHeight;

        Vector3 _b012 = p0;

        for(int i = 0; i < positionCount; i++)
        {
            float amp = ((float)i / (float)(positionCount - 1));
            Vector3 b01 = Vector3.Lerp(p0, p1, amp);
            Vector3 b12 = Vector3.Lerp(p1, p2, amp);

            Vector3 b012 = Vector3.Lerp(b01, b12, amp);

            //RaycastHit hit;
            if(Physics.Linecast(_b012,b012,out hit))
            {
                Debug.Log("hit!");
                Vector3 hitPoint = hit.point;
                for(int i2 = i; i2 < positionCount; i2++)
                {
                    lRend.SetPosition(i2, hitPoint);
                }
                break;
            }

            else
            {
                lRend.SetPosition(i, b012);
                _b012 = b012;
            }
        }

        Debug.Log(hit.point);
    }
}
