using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HandyCreator_Path_Deleter : MonoBehaviour
{
    public GameObject Objects;
    public SpawnTutorialHelper STH;
    // Update is called once per frame
    public List<string> ItemNames;
    
    void Start()
    {
        foreach(Transform child in Objects.transform)
        {
            ItemNames.Add(child.name);
        }
    }
    void Update()
    {
        List<string> ObjectsToRemove = new List<string>();

        if(Objects.transform.childCount == 1)
            Destroy(gameObject);

        foreach(string objectName in ItemNames)
        {
            // Verifica se algum dos objetos ainda existe na cena
            if (Objects.transform.Find(objectName) == null && transform.Find(objectName) != null)
            {
                int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find(objectName).gameObject);
                STH.waypoints.RemoveAt(indiceObjeto);
                if(indiceObjeto < STH.waypoints.Count)
                    STH.waypoints.RemoveAt(indiceObjeto);

                ObjectsToRemove.Add(objectName);
            }
        }

        foreach(string objectName in ObjectsToRemove)
            ItemNames.Remove(objectName);
    }
}
