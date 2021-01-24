using UnityEngine;

public class DEBUG_VARIABLE : MonoBehaviour
{
    private const string DEBUG_PASS = "457700";
    private bool DEBUG_FRAG;

    public string DEBUGPASS {
        get => DEBUG_PASS;
    }

    public bool DEBUGFRAG {
        get => DEBUG_FRAG;
        set => DEBUG_FRAG = value;
    }
}
