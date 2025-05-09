using UnityEngine;

public class GameManagerBootstrap : MonoBehaviour
{
    [Header("Prefab del GameManager")]
    public GameManagerBase gameManagerPrefab;

    private void Awake()
    {
        if (GameManagerBase.Instance == null)
        {
            GameManagerBase instancia = Instantiate(gameManagerPrefab);
            instancia.name = "GameManager (Bootstrap)";
        }

        // Este bootstrap puede eliminarse una vez que cumplió su función
        Destroy(gameObject);
    }
}
