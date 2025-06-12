using UnityEngine;

public class InpectorWaiter : MonoBehaviour
{
    public GameObject inspector;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            inspector.gameObject.SetActive(true);
            enabled = false;
        }
    }
}
