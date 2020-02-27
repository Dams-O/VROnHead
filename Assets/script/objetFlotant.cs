using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetFlotant : MonoBehaviour
{
    /*[SerializeField] float rotationSpeed = 100f;
    bool dragging = false;*/
    public Rigidbody rb;
    public Animator anim;
    float x;
    bool gravityIsOn = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    /*void OnMouseDrag(){
        dragging = true;
    }*/
    // Update is called once per frame
    void Update()
    {
        if(!gravityIsOn){
            x += Time.deltaTime * 70;
            transform.rotation = Quaternion.Euler(x,0,0);
        }
        if(Input.GetMouseButtonUp (0)){
            rb.useGravity = true;
            gravityIsOn = true;
            Destroy(anim);
            //dragging = false;
        }  
    }

    /*void FixedUpdate()
    {
        if(dragging){
            float x = Input.GetAxis("Mouse X")* rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y")* rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
            
        }
        
    }*/
}
