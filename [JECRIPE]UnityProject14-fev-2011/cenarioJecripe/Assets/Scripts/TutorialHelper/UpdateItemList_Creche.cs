using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateItemList_Creche : MonoBehaviour
{
    private string objetoDaVez;
    private SpawnTutorialHelper script;

    // Start is called before the first frame update
    void Start()
    {
        script = gameObject.GetComponent<SpawnTutorialHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objetoDaVez != AtividadeCrecheController.ObjetoDaVez)
        {
            objetoDaVez = AtividadeCrecheController.ObjetoDaVez;
            script.waypoints.Clear();
            switch (objetoDaVez)
            {
                case "Mamadeira":
                    script.waypoints.Add(GameObject.Find("MamadeiraPos"));
                    script.waypoints.Add(GameObject.Find("BebePos"));
                    break;
                case "Chocalho":
                    script.waypoints.Add(GameObject.Find("ChocalhoPos"));
                    script.waypoints.Add(GameObject.Find("BebePos"));
                    break;
                case "Chupeta":
                    script.waypoints.Add(GameObject.Find("ChupetaPos"));
                    script.waypoints.Add(GameObject.Find("BebePos"));
                    break;
                case "Papinha":
                    script.waypoints.Add(GameObject.Find("PapinhaPos"));
                    script.waypoints.Add(GameObject.Find("BebePos"));
                    break;
            }
        }

    }
}
