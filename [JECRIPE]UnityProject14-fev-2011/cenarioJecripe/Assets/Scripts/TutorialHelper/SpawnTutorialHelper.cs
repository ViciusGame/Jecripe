using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTutorialHelper : MonoBehaviour
{
    public GameObject prefab; // Prefab a ser instanciado
    public List<GameObject> waypoints; // Objeto-alvo na cena
    public float idleTime = 10f; // Tempo de inatividade em segundos
    public GameObject objectTutorialHelperCanvas;

    public GameObject Camera;
    private Vector3 lastCameraPosition;
    private bool isMoving;
    private float mouseIdleTimer = 0f; // Timer de inatividade

    void Start()
    {
        lastCameraPosition = Camera.transform.position;
        isMoving = false;
    }
    void Update()
    {
        // Detecta movimentação do mouse
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            mouseIdleTimer = 0f; // Reseta o timer
        }
        else
        {
            mouseIdleTimer += Time.deltaTime; // Incrementa o timer
        }

        // Verifica se a posição da câmera mudou
        if (Camera.transform.position != lastCameraPosition)
        {
            isMoving = true;
            lastCameraPosition = Camera.transform.position;
        }
        else
        {
            isMoving = false;
        }

        // Checa se o tempo de inatividade foi atingido
        if (mouseIdleTimer >= idleTime && GameObject.FindWithTag("Handy") == null && !isMoving)
        {
            InstantiatePrefab();
            mouseIdleTimer = 0f; // Reseta o timer para evitar múltiplas instâncias
        }
    }

    void InstantiatePrefab()
    {
        // Instancia o prefab no local especificado
        if (prefab != null && waypoints.Count > 0)
        {
            GameObject tutorialObject = Instantiate(prefab, transform.position, transform.rotation, objectTutorialHelperCanvas.transform);
            tutorialObject.transform.eulerAngles = new Vector3(0, 0, 30);
            TutorialHelper script = tutorialObject.GetComponent<TutorialHelper>();
            if (script != null)
            {
                script.SetWaypoint(waypoints);
            }
        }
        else
        {
            Debug.LogWarning("Prefab ou posição de spawn não configurados!");
        }
    }
}
