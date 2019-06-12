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

                textController.mainMenuButtonGO.SetActive(false);

                for(int i = 0; i < textController.mainMenuObjects.Count; i++)
                {
                    GameObject menuObject = textController.mainMenuObjects[i];
                    menuObject.SetActive(true);
                }

            }else{

                textController.mainMenuButtonGO.SetActive(true);
                
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
                textController.pauseScreenButtonGO.SetActive(true);

                for(int i = 0; i < textController.playObjects.Count; i++)
                {
                    TextController.PlayTitleBox playObject = textController.playObjects[i];
                    playObject.TitleBoxEnabled(true);
                }
            }else if(gameState == _GameState.MainMenu)
            {
                textController.pauseScreenButtonGO.SetActive(false);

                for(int i = 0; i < textController.playObjects.Count; i++)
                {
                    TextController.PlayTitleBox playObject = textController.playObjects[i];
                    playObject.TitleBoxEnabled(false);
                }
            }else{

                for(int i = 0; i < textController.playObjects.Count; i++)
                {
                    TextController.PlayTitleBox playObject = textController.playObjects[i];
                    playObject.TitleBoxEnabled(false);
                }
            }
        }

        public void PlayGame()
        {
            Debug.Log("GameState now in Play.");
            gameState = _GameState.Play;

            EnableDiableMainMenuObjects(gameState);
            EnableDisablePlayObjects(gameState);

        }

        public void StickerBook()
        {
            Debug.Log("GameState now in Stickers.");
            gameState = _GameState.Stickers;

            EnableDiableMainMenuObjects(gameState);
            EnableDisablePlayObjects(gameState);
        }

        public void MainMenu()
        {
            Debug.Log("GameState is now MainMenu.");
            gameState = _GameState.MainMenu;

            EnableDisablePlayObjects(gameState);
            EnableDiableMainMenuObjects(gameState);

        }

        public void Pause()
        {
            if(gameState == _GameState.Paused)
            {
                Debug.Log("GameState is now Play.");
                gameState = _GameState.Play;

                EnableDisablePlayObjects(gameState);
                textController.pauseScreenGO.SetActive(false);
            }else{
                Debug.Log("GameState is now Paused.");
                gameState = _GameState.Paused;

                EnableDisablePlayObjects(gameState);
                textController.pauseScreenGO.SetActive(true);
            }
            

        }


    }
}
