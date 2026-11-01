using UnityEngine;

public class AudioPrueba : MonoBehaviour
{
    [SerializeField] private AudioSource sonidoSalto;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sonidoSalto.Play();
        }
    }
}
