using UnityEngine;
using TMPro;

public class HUD: MonoBehaviour
{
    public TextMeshProUGUI textoCarteles;

    void Update()
    {
        if (textoCarteles != null && GameManagerBase.Instance != null)
        {
            textoCarteles.text = GameManagerBase.Instance.Carteles.ToString();
        }
    }
}
