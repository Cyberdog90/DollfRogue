using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu_SceneLoad : MonoBehaviour {
    private TitleMenu_Start _start;
    private TitleMenu_Load _load;
    private TitleMenu_EXiT _exit;
    private Color _startDefault;
    private Color _loadDefault;
    private Color _exitDefault;
    private int _select;

    void Start() {
        _start = GameObject.Find("TitleMenu_Start").GetComponent<TitleMenu_Start>();
        _load = GameObject.Find("TitleMenu_Load").GetComponent<TitleMenu_Load>();
        _exit = GameObject.Find("TitleMenu_EXiT").GetComponent<TitleMenu_EXiT>();
        _startDefault = _start.Color;
        _loadDefault = _load.Color;
        _exitDefault = _exit.Color;
    }


    void Update() {
        switch (_select) {
            case 0:
                _start.Color = Color.red;
                _load.Color = Color.yellow;
                _exit.Color = Color.yellow;
                break;
            case 1:
                _start.Color = Color.yellow;
                _load.Color = Color.red;
                _exit.Color = Color.yellow;
                break;
            case 2:
                _start.Color = Color.yellow;
                _load.Color = Color.yellow;
                _exit.Color = Color.red;
                break;
        }
        /*
        switch (_select) {
            case 0:
                _start.Color = Color.red;
                _load.Color = _loadDefault;
                _exit.Color = _exitDefault;
                break;
            case 1:
                _start.Color = _startDefault;
                _load.Color = Color.red;
                _exit.Color = _exitDefault;
                break;
            case 2:
                _start.Color = _startDefault;
                _load.Color = _loadDefault;
                _exit.Color = Color.red;
                break;
        }
        */

        if (Input.GetKeyDown(KeyCode.UpArrow)) _select--;
        if (Input.GetKeyDown(KeyCode.DownArrow)) _select++;
        if (_select < 0) _select = 0;
        if (_select > 2) _select = 2;

        if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("_select : " + _select);
            switch (_select) {
                case 0:
                    //ニューゲーム
                    SceneManager.LoadScene("MainMaps");
                    break;
                case 1:
                    //セーブデータロード
                    break;
                case 2:
                    //終了処理
                    UnityEditor.EditorApplication.isPlaying = false;
                    Application.Quit();
                    break;
            }
        }
    }
}