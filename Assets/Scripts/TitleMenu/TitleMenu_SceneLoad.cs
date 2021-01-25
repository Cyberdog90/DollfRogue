using UnityEngine;

public class TitleMenu_SceneLoad : MonoBehaviour {
    private TitleMenu_Start _start;
    private TitleMenu_Load _load;
    private TitleMenu_EXiT _exit;
    private int _select;

    void Start() {
        _start = GameObject.Find("TitleMenu_Start").GetComponent<TitleMenu_Start>();
        _load = GameObject.Find("TitleMenu_Load").GetComponent<TitleMenu_Load>();
        _exit = GameObject.Find("TitleMenu_EXiT").GetComponent<TitleMenu_EXiT>();
    }


    void Update() {
        switch (_select) {
            case 0:
                _start.Color = Color.red;
                _load.Color = Color.white;
                _exit.Color = Color.white;
                break;
            case 1:
                _start.Color = Color.white;
                _load.Color = Color.red;
                _exit.Color = Color.white;
                break;
            case 2:
                _start.Color = Color.white;
                _load.Color = Color.white;
                _exit.Color = Color.red;
                break;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            _select++;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            _select--;
        }

        if (_select < 0) _select = 0;
        if (_select > 2) _select = 2;

        if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("_select : " + _select.ToString());
            switch (_select) {
                case 0:
                    //ニューゲーム
                    break;
                case 1:
                    //セーブデータロード
                    break;
                case 2:
                    //終了処理
                    break;
            }
        }
    }
}