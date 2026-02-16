using UnityEngine;

public class santamanger : MonoBehaviour
{

    public Animator santaAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (santaAnimator != null) { }

        if ((Input.GetKeyDown(KeyCode.R)))
        {
            santaAnimator.SetTrigger("santarun");
        }
        if ((Input.GetKeyDown(KeyCode.J)))
        {
            santaAnimator.SetTrigger("santajump");
        }
        if ((Input.GetKeyDown(KeyCode.D)))
        {
            santaAnimator.SetTrigger("santadead");
        }
    }
}