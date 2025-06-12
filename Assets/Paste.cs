using UnityEngine;

public class Paste : MonoBehaviour
{
    public GameObject inspector;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.V))
        {
            enabled = false;
            inspector.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
