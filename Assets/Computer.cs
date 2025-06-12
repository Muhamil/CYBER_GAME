using UnityEngine;
using UnityEngine.SceneManagement;

public class Computer : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}
