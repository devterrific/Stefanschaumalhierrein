using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { inGame, inMenu }
public class GameManger : MonoBehaviour

{
    public GameState gameState;
    float kamal = 0 ;

    public static GameManger Kamal;

    // Start is called before the first frame update
    void Start()
    {
        Kamal = this;
    }

    // Update is called once per frame
    void Update()
    {
        exitafter5sec();

        Input.GetKeyDown(KeyCode.Escape);
        //gameObject.activeSelf 
    }

    public void loadlevel(String level1){
        SceneManager.LoadScene(level1);

    }
        public void Quitgame(){
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void exitafter5sec(){

        
        kamal = kamal + Time.deltaTime;
        
        if(kamal >= 5 && gameState == GameState.inGame){
            SceneManager.LoadScene("kamal");
            kamal = 0;

        }

        
    }
}
