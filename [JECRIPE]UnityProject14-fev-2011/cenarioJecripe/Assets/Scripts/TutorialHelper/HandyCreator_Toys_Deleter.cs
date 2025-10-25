using UnityEngine;

public class HandyCreator_Toys_Deleter : MonoBehaviour
{
    public GameObject Aviao;
    public GameObject Peteca;

    private Vector3 targetPositionAviao = new Vector3(-1.984909f, -1.915348f, 4.429565f);
    private Vector3 targetPositionPeteca = new Vector3(-1.985239f, -2.02116f, 4.429603f);
    
    private readonly float tolerance = 0.1f;
    void Update()
    {
        bool aviaoCheck = Mathf.Abs(Aviao.transform.position.x - targetPositionAviao.x) <= tolerance
                        && Mathf.Abs(Aviao.transform.position.z - targetPositionAviao.z) <= tolerance;

        bool petecaCheck = Mathf.Abs(Peteca.transform.position.x - targetPositionPeteca.x) <= tolerance
                        && Mathf.Abs(Peteca.transform.position.z - targetPositionPeteca.z) <= tolerance;

        // Se ambos os objetos estiverem dentro da tolerância, destrói este objeto
        if (aviaoCheck && petecaCheck)
        {
            Destroy(gameObject);
        }    
    }
}
