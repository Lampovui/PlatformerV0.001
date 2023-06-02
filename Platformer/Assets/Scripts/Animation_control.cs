using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_control : MonoBehaviour
{
    private Animator _animator;

    public bool IsMoving { private get; set; }
    // Start is called before the first frame update
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _animator.SetBool("IsMoving", IsMoving);
    }
}
