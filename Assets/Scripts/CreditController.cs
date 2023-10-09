using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    public string sceneToLoad;

    public void SceneChange(string name)
    {
        if (Input.GetButton("Cancel"))
        {
            SceneManager.LoadScene(name);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
