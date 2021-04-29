using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rascar();
    }

    void rascar()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger("rascar");
        }
    }
}
