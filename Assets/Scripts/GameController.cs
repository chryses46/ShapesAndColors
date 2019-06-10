using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShapesAndColors{

    public class GameController : MonoBehaviour
    {
        TextController textController;
        public enum _GameState
        {
            MainMenu,
            Play,
            Stickers,
            Paused

        }
        _GameState gameState = _GameState.MainMenu;

        // Start is called before the first frame update
        void Awake()
        {
            
            
        }

        // Update is called once per frame
        void Start()
        {
            textController = FindObjectOfType<TextController>();
        }

        private void EnableDiableMainMenuObjects(_GameState gameState)
        {

            if( textController.mainMenuObjects == null){

                Debug.Log("Menu objects not loaded yet.");

            }else if(gameState == _GameState.MainMenu)
            {
                for(int i = 0; i < textController.mainMenuObjects.Count; i++)
                {
                    GameObject menuObject = textController.mainMenuObjects[i];
                    menuObject.SetActive(true);
                }

            }else{
                
                for(int i = 0; i < textController.mainMenuObjects.Count; i++)
                {
                    GameObject menuObject = textController.mainMenuObjects[i];
                    menuObject.SetActive(false);
                }
            }
        }


        private void EnableDisablePlayObjects(_GameState gameState)
        {
            if(gameState == _GameState.Play)
            {
                textController.mainMenuButtonGO.SetActive(true);
                textController.pauseScreenButtonGO.SetActive(true);

                for(int i = 0; i < textController.playObjects.Count; i++)
                {
                    GameObject playObject = textController.playObjects[i];
                    playObject.SetActive(true);
                }
            }else{
                for(int i = 0; i < textController.playObjects.Count; i++)
                {
                    GameObject playObject = textController.playObjects[i];
                    playObject.SetActive(false);
                }

            }
        }

        public void PlayGame()
        {
            Debug.Log("GameState now in Play.");
            gameState = _GameState.Play;
            Debug.Log(gameState);

            EnableDiableMainMenuObjects(gameState);
            EnableDisablePlayObjects(gameState);

        }

        public void StickerBook()
        {
            Debug.Log("GameState now in Stickers.");
            gameState = _GameState.Stickers;
            Debug.Log(gameState);

            EnableDiableMainMenuObjects(gameState);
            EnableDisablePlayObjects(gameState);
        }

        public void MainMenu()
        {
            Debug.Log("GameState is now MainMenu.");
            gameState = _GameState.MainMenu;
            Debug.Log(gameState);

            EnableDisablePlayObjects(gameState);
            EnableDiableMainMenuObjects(gameState);

        }

        public void Pause(_GameState gamestate)
        {
            if(gameState == _GameState.Paused)
            {
                Debug.Log("GameState is now Paused.");
                gameState = _GameState.Paused;
                Debug.Log(gameState);

                EnableDisablePlayObjects(gameState);
                textController.pauseScreenGO.SetActive(true);
            }
            

        }


    }
}
