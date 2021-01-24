using System;
using UnityEngine;

public class TitleMenu_Debug : MonoBehaviour {
    private string test = "";
    private readonly DEBUG_VARIABLE _dV = new DEBUG_VARIABLE();
    void Start() {
    }

    void Update() {
        if (Input.anyKeyDown) {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode))) {
                if (Input.GetKeyDown(code)) {
                    var tmp = code.ToString().Replace("Alpha", "");
                    test += tmp;
                    Debug.Log(test);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.RightControl)) test = "";

        if (test == _dV.DEBUGPASS && !_dV.DEBUGFRAG) {
            Debug.Log("立ったまま死ね!");
            _dV.DEBUGFRAG = true;
        }
    }
}