using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleGrua : MonoBehaviour
{
    public int indice;
    public GameObject mercurio;
    public GameObject venus;
    public GameObject terra;
    public GameObject marte;
    public GameObject jupiter;
    public GameObject saturno;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(indice == 0) {
            transform.position = mercurio.transform.position;
        }
        if(indice == 1) {
            transform.position = venus.transform.position;
        }
        if(indice == 2) {
            transform.position = terra.transform.position;
        }
        if(indice == 3) {
            transform.position = marte.transform.position;
        }
        if(indice == 4) {
            transform.position = jupiter.transform.position;
        }
        if(indice == 5) {
            transform.position = saturno.transform.position;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            indice = indice - 1;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            indice = indice + 1;
        }
    }
}
