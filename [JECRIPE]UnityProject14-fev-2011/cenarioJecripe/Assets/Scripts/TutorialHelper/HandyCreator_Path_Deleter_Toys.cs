using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HandyCreator_Path_Deleter_Toys : MonoBehaviour
{
    public Transform aviaoTransform,
                    petecaTransform,
                    carroVermelhoTransform,
                    peaoTransform,
                    carroAzulTransform,
                    bolaTransform,
                    barcoTransform,
                    skateTransform;
    Vector3 aviaoPositionInitial,
            petecaPositionInitial,
            carroVermelhoPositionInitial,
            peaoPositionInitial,
            carroAzulPositionInitial,
            bolaPositionInitial,
            barcoPositionInitial,
            skatePositionInitial;

    public SpawnTutorialHelper STH;

    // Start is called before the first frame update
    void Start()
    {
        aviaoPositionInitial = aviaoTransform.position;
        petecaPositionInitial = petecaTransform.position;

        carroVermelhoPositionInitial = carroVermelhoTransform.position;
        peaoPositionInitial = peaoTransform.position;

        carroAzulPositionInitial = carroAzulTransform.position;
        bolaPositionInitial = bolaTransform.position;

        barcoPositionInitial = barcoTransform.position;
        skatePositionInitial = skateTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (STH.waypoints.Count == 0)
            Destroy(gameObject);
        if (aviaoTransform.position != aviaoPositionInitial && STH.waypoints.Contains(transform.Find("aviao_amarelo").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("aviao_amarelo").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if (indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }
        if (petecaPositionInitial != petecaTransform.position && STH.waypoints.Contains(transform.Find("peteca_amarela").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("peteca_amarela").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if (indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }
        if (carroVermelhoPositionInitial != carroVermelhoTransform.position && STH.waypoints.Contains(transform.Find("carro_vermelho").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("carro_vermelho").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if(indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }
        if (peaoPositionInitial != peaoTransform.position && STH.waypoints.Contains(transform.Find("peao_vermelho").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("peao_vermelho").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if(indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }
        if (carroAzulPositionInitial != carroAzulTransform.position && STH.waypoints.Contains(transform.Find("carro_azul").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("carro_azul").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if(indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }
        if (bolaPositionInitial != bolaTransform.position && STH.waypoints.Contains(transform.Find("bola_azul").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("bola_azul").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if(indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }
        if (barcoPositionInitial != barcoTransform.position && STH.waypoints.Contains(transform.Find("barco_verde").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("barco_verde").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if(indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }
        if (skatePositionInitial != skateTransform.position && STH.waypoints.Contains(transform.Find("skate_verde").gameObject))
        {
            int indiceObjeto = STH.waypoints.FindIndex(objeto => objeto == transform.Find("skate_verde").gameObject);
            STH.waypoints.RemoveAt(indiceObjeto);
            if(indiceObjeto < STH.waypoints.Count)
                STH.waypoints.RemoveAt(indiceObjeto);
        }

    }
}
