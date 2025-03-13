using Unity.VisualScripting;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    private GameObject gate;

    void Start()
    {
        gate = GameObject.Find("Gate");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Crate")
        {
            Debug.Log(other.name);
            Debug.Log(gate.name);
            Destroy(gate);
        }
    }
}
