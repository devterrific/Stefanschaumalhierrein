using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour{


public void GotoTitle(){

    GameManger.loadlevel(!level1);

}

public void Deactive(){

    gameObject.SetActive(false);
}


}
