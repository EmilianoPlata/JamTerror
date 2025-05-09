using UnityEngine;

public class Cartel : MonoBehaviour
{
    [Header("Valor del cartel")]
    public int valor = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManagerBase.Instance != null)
            {
                GameManagerBase.Instance.SumarCarteles(valor);
            }
            Destroy(gameObject, 0.1f);
        }
    }
}
