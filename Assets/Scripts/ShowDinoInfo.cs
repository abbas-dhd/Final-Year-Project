using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDinoInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public  GameObject Info;
    private bool active = false;
    void Start()
    {
        Info.SetActive(active);    
    }

    public void ToggleInfo(){
        // active = !active;
        // Info.SetActive(active);
        if(active == false){
            active = true;
            Info.SetActive(active);
        }
        else if(active == true){
            active = false;
            Info.SetActive(active);
        }
    }
}
