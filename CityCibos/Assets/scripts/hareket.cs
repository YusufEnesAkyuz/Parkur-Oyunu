using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    private Animator Myanim;
    public int hiz;
    [SerializeField] private Rigidbody myrb;
    void Start()
    {
        hiz = 3;
        Myanim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Myanim.SetBool("Run", true);
            transform.Translate(new Vector3(0, 0, 1f) * Time.deltaTime * hiz);
        }
        else
        {
            Myanim.SetBool("Run", false);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            Myanim.SetBool("jump", true);
            transform.Translate(new Vector3(0, 1, 1f) * Time.deltaTime * hiz);
        }
        else
        {
            Myanim.SetBool("jump", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 1f) * Time.deltaTime * hiz);
            Myanim.SetBool("turnLeft", true);
        }
        else
        {
            Myanim.SetBool("turnLeft", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime *hiz);
            Myanim.SetBool("turnright", true);
        }
        else
        {
            Myanim.SetBool("turnright", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1f) * Time.deltaTime * hiz);
            Myanim.SetBool("back", true);
        }
        else
        {
            Myanim.SetBool("back", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
