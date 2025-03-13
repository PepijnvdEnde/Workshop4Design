using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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
            gate.transform.rotation = Quaternion.Euler(transform.rotation.x, 90, transform.rotation.z);
        }
    }
}
