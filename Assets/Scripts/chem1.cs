using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chem1 : MonoBehaviour
{
    private Animator anim;
    void Start()
    {

    }
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetTrigger("Slash");
        }
    }
}