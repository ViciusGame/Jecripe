using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandyCreator_BubbleAssembly_Deleter : MonoBehaviour
{
    public GameObject Object;
    private Vector3 lastPosition;
    
    void Start()
    {
        lastPosition = Object.transform.position;
    }
    void Update()
    {
        // Verifica se algum dos objetos ainda existe na cena
        if (Object.transform.position != lastPosition)
        {
            Destroy(gameObject);
        }
    }
}
