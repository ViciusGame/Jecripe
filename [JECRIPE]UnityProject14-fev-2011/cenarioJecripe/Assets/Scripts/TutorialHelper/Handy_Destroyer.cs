using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handy_Destroyer : MonoBehaviour
{
    public GameObject Object;
    private Vector3 lastPosition;
    private Vector3 currentPosition;


    // Start is called before the first frame update
    void Start()
    {
        lastPosition = Object.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Detecta movimentação do mouse
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            GameObject handy = GameObject.FindWithTag("Handy");
            if(handy != null)
                Destroy(handy);
        }

        if(Vector3.Distance(Object.transform.position, currentPosition) == 0)
            lastPosition = Object.transform.position;

        currentPosition = Object.transform.position;
        // Verifica se algum dos objetos ainda existe na cena
        if (Object.transform.position != lastPosition)
        {
            if(GameObject.FindWithTag("Handy") != null)
            {
                Destroy(GameObject.FindWithTag("Handy"));
            }
        }

    }
}
