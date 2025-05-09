using UnityEngine;

public class GameManagerBase : MonoBehaviour
{
    public static GameManagerBase Instance { get; private set; }

    private int carteles = 0;

    public int Carteles => carteles;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Opcional, si lo necesitas en múltiples escenas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarCarteles(int cantidad)
    {
        carteles += cantidad;
        Debug.Log("Carteles actuales: " + carteles);
    }
}
