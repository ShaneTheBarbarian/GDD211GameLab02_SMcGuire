using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController3D : MonoBehaviour
{
    [SerializeField] private Animator ani;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.RightArrow))
        {
            ani.SetBool("IsWalking", true);
        }
        else
        {
            ani.SetBool("IsWalking", false);
        }
    }
}
