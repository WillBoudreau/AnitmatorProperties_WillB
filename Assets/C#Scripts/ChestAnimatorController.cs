using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimatorController : MonoBehaviour
{
    Animator Chestanimation;
    public bool TrigAnamation;
    public bool IsOpen;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        Chestanimation = GetComponent<Animator>();
        speed = Chestanimation.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Chestanimation != null)
        {
            if(Input.GetKeyDown(KeyCode.E) && !Chestanimation.GetBool("ChestTrigger"))
            {
                Debug.Log("E Pressed");
                TrigAnamation = !TrigAnamation;
                Chestanimation.SetBool("ChestTrigger",TrigAnamation);
            }
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(Chestanimation.speed == 0f)
                {
                    Debug.Log("Resume");
                    ResumeAnim();
                }
            }
        }
    }
    void PauseAnim()
    {
        Debug.Log("Pause");
        Chestanimation.speed = 0f;
    }
    void ResumeAnim()
    {
        Debug.Log("Resume");
        Chestanimation.speed = speed;
    }
    void OpenChest()
    {
        Debug.Log("Open");
        IsOpen = true;
        Chestanimation.SetBool("ChestTrigger",false);
    }
    void CloseChest()
    {
        Debug.Log("Close");
        IsOpen = false;
        Chestanimation.SetBool("ChestTrigger",false);
    }
}
