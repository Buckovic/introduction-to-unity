using UnityEngine;
using Kino;

public class ViewSwitch : MonoBehaviour {

    public Isoline isoline;
    bool state = true;

    public void SwitchCameraEffect(){
        state = !state;
        isoline.enabled = state;
    }

}
