using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateItemList_Musica : MonoBehaviour
{
    private MusicaInsideController script;
    private List<GameObject> listJanelas;
    private Vector3 pos = new Vector3(-42.98013f, 20.52977f, 40.79858f);

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("MusicaInsideController").GetComponent<MusicaInsideController>();
        listJanelas = gameObject.GetComponent<SpawnTutorialHelper>().waypoints;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = GameObject.Find("Camera").GetComponent<Transform>().position;
        if (cameraPos != pos)
        {
            Destroy(GameObject.FindWithTag("Handy"));
        }
        if (script.janela1Feita)
        {
            listJanelas.Remove(GameObject.Find("janela_1"));
        }
        if (script.janela2Feita)
        {
            listJanelas.Remove(GameObject.Find("janela_2"));
        }
        if (script.janela3Feita)
        {
            listJanelas.Remove(GameObject.Find("janela_3"));
        }
        if (script.janela4Feita)
        {
            listJanelas.Remove(GameObject.Find("janela_4"));
        }
        if (script.janela5Feita)
        {
            listJanelas.Remove(GameObject.Find("janela_5"));
        }
        if (script.janela6Feita)
        {
            listJanelas.Remove(GameObject.Find("janela_6"));
        }
    }
}
