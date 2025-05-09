using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    [SerializeField] private GameObject chest;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && GameManagerBase.Instance.Carteles == 8)
        {
            chest.SetActive(true);
            SceneManager.LoadScene("Final");
        }
    }
}
