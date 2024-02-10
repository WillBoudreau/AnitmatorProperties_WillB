using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimatorController : MonoBehaviour
{
    Animator Chestanimation;
    public bool TrigAnamation;
    // Start is called before the first frame update
    void Start()
    {
        Chestanimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Chestanimation != null)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {

                TrigAnamation = !TrigAnamation;

                Chestanimation.SetBool("ChestTrigger",TrigAnamation);
            }
        }
    }
}
