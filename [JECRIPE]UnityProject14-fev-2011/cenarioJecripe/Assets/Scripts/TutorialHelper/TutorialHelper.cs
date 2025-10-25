using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialHelper : MonoBehaviour
{
    public RectTransform imageTransform;

    // Coordenadas atuais da imagem
    public Vector3 originalPosition;

    // Conjunto de pontos para o caminho
    public List<GameObject> waypoints;

    // Velocidade da animaçao
    public float speed = 200f;

    private int currentPosition = 0;
    public ParticleSystem pingEffect;

    public void SetWaypoint(List<GameObject> waypoints)
    {
        this.waypoints = waypoints;
    }

    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = imageTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(waypoints.Count == 0) return;

        // Posicao do ponto de partida
        Vector3 target = waypoints[currentPosition].transform.position;

        // Mover-se para proxima posicao
        if(canMove)
        {
            imageTransform.position = Vector3.MoveTowards(imageTransform.position, target, speed * Time.deltaTime);
        }
        
        // Checar se a imagem esta proxima do ponto de destino
        if (Vector3.Distance(imageTransform.position, target) < 0.1f)
        {
            // Atualizar contador para o próximo ponto de destino (se acabar a lista, volta para o primeiro)
            if(currentPosition == waypoints.Count - 1)
            {
                // Ping effect
                if (!pingEffect.isPlaying)
                    pingEffect.Play();

                Destroy(gameObject, 3f);
            }
            else
            {
                StartCoroutine(Wait());
                currentPosition++;
            }
        }
    }
    IEnumerator Wait()
    {
        if (!pingEffect.isPlaying)
        {
            pingEffect.Play();
        }
        canMove = false; // Stop movement
        yield return new WaitForSeconds(1);
        canMove = true; // Resume movement
    }
}
