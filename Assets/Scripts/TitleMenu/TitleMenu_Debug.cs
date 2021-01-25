using System;
using UnityEngine;

public class TitleMenu_Debug : MonoBehaviour {
    private string _test = "";
    private readonly DEBUG_VARIABLE _dV = new DEBUG_VARIABLE();

    void Update() {
        if (Input.anyKeyDown) {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode))) {
                if (Input.GetKeyDown(code)) {
                    var tmp = code.ToString().Replace("Alpha", "");
                    _test += tmp;
                    //Debug.Log(test);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.RightControl)) _test = "";

        if (_test == _dV.DEBUGPASS && !_dV.DEBUGFRAG) {
            Debug.Log("立ったまま死ね!");
            _dV.DEBUGFRAG = true;
        }
    }
}