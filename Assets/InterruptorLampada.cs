using UnityEngine;

public class InterruptorLampada : MonoBehaviour
{
    public Light lampada;
    public Transform interruptor;
    private bool jogadorDentro = false;

    private void Update()
    {
        if (jogadorDentro && Input.GetKeyDown(KeyCode.F))
        {
            lampada.enabled = !lampada.enabled;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorDentro = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorDentro = false;
        }
    }
}
