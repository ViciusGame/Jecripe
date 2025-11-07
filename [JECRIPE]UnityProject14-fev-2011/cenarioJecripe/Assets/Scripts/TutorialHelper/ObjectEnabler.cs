using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnabler : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Object;
    
    // posicao da camera no ultimo jogo
    public Vector3 targetPosition;
    // Update is called once per frame
    void Update()
    {
        if(Camera != null && Object != null && Camera.transform.position == targetPosition)
        {
            Object.SetActive(true);
        }
    }
}
