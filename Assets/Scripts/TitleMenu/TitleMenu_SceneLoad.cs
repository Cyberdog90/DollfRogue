using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu_SceneLoad : MonoBehaviour {
    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadScene("MainMaps");
        }
    }
}