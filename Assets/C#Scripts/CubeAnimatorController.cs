using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimatorController : MonoBehaviour
{
    Animator animation;
    public bool IsAnamation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animation != null)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {

                IsAnamation = !IsAnamation;

                animation.SetBool("AnimTrigger",IsAnamation);
            }
        }
    }
}
