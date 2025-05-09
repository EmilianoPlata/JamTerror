using UnityEngine;
using UnityEngine.SceneManagement;

public class Salida : MonoBehaviour
{
    [SerializeField] private GameObject salida;
    [SerializeField] private GameObject chest;


    void Start()
    {
        chest.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(GameManagerBase.Instance.Carteles == 8)
        {
            salida.SetActive(false);
            chest.SetActive(true);
            Debug.Log("Son 8");
            
        }
    }
}
