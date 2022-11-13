using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScripts : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        Debug.Log("this is working");
    }

    // Update is called once per frame
    void Update()
    {
        if(mAnimator != null) {
            if(Input.GetKeyDown(KeyCode.F)) {
                mAnimator.SetBool("Attacking", true);
            }
            if(Input.GetKeyUp(KeyCode.F)) {
                mAnimator.SetBool("Attacking", false);
            }
        } else {
            Debug.Log("no animator found or working");
        }
    }
}
