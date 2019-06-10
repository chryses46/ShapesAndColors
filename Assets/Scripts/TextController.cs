using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityEngine.UI;
using System;

namespace ShapesAndColors{
    public class TextController : MonoBehaviour
    {
        GameController gameController;
        
        public Font font;
        
        public Transform mainCanvas;
        public List<GameObject> mainMenuObjects = new List<GameObject>();
        public List<GameObject> playObjects = new List<GameObject>();
        Button startButton;
        Button stickersButton;
        public GameObject mainMenuButtonGO;
        public Button mainMenuButton;
        public GameObject pauseScreenButtonGO;
        public Button pauseScreenButton;
        
        public GameObject pauseScreenGO;
        void Awake()
        {
            gameController = FindObjectOfType<GameController>();

            var welcomeFont = font;
            var welcomeFontSize = 100;

            //Create the UI Canvas
            GameObject canvasGO = new GameObject();
            
            canvasGO.name = "MainCanvas";
            canvasGO.AddComponent<Canvas>();
            canvasGO.AddComponent<CanvasScaler>();
            canvasGO.AddComponent<GraphicRaycaster>();
            
            //Allow MainCanvas to be accessible outside of class.
            mainCanvas = canvasGO.transform;

            Canvas canvas;
            canvas = canvasGO.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            //Create the 'Welcome to' text
            GameObject welcomeTextGO = new GameObject();
            welcomeTextGO.name = "WelcomeText";
            welcomeTextGO.transform.parent = canvasGO.transform;
            welcomeTextGO.AddComponent<Text>();

            mainMenuObjects.Add(welcomeTextGO);

            Text welcomeText;
            welcomeText = welcomeTextGO.GetComponent<Text>();
            welcomeText.text = "Welcome to";
            welcomeText.font = welcomeFont;
            welcomeText.fontSize = welcomeFontSize;
            welcomeText.color = new Color(255, 0, 0);
            welcomeText.alignment = TextAnchor.UpperCenter;

            RectTransform welcomeRectTransform;
            welcomeRectTransform = welcomeText.GetComponent<RectTransform>();
            welcomeRectTransform.localPosition = new Vector3(0, 300, 0);
            welcomeRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the 'Shapes' text
            GameObject shapesTextGO = new GameObject();
            shapesTextGO.name = "ShapesText";
            shapesTextGO.transform.parent = canvasGO.transform;
            shapesTextGO.AddComponent<Text>();

            mainMenuObjects.Add(shapesTextGO);

            Text shapesText;
            shapesText = shapesTextGO.GetComponent<Text>();
            shapesText.text = "Shapes";
            shapesText.font = welcomeFont;
            shapesText.fontSize = welcomeFontSize + 5;
            shapesText.color = new Color(0, 255, 0);
            shapesText.alignment = TextAnchor.UpperLeft;

            RectTransform shapesRectTransform;
            shapesRectTransform = shapesText.GetComponent<RectTransform>();
            shapesRectTransform.localPosition = new Vector3(-183.5f, 200f, 0f);
            shapesRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the '&' text
            GameObject ampTextGO = new GameObject();
            ampTextGO.name = "AmpersandText";
            ampTextGO.transform.parent = canvasGO.transform;
            ampTextGO.AddComponent<Text>();

            mainMenuObjects.Add(ampTextGO);

            Text ampText;
            ampText = ampTextGO.GetComponent<Text>();
            ampText.text = "&";
            ampText.font = welcomeFont;
            ampText.fontSize = welcomeFontSize + 5;
            ampText.color = new Color(0, 0, 255);
            ampText.alignment = TextAnchor.UpperCenter;

            RectTransform ampRectTransform;
            ampRectTransform = ampText.GetComponent<RectTransform>();
            ampRectTransform.localPosition = new Vector3(0, 200, 0);
            ampRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the 'Colors!' text
            GameObject colorsTextGO = new GameObject();
            colorsTextGO.name = "ColorsText";
            colorsTextGO.transform.parent = canvasGO.transform;
            colorsTextGO.AddComponent<Text>();

            mainMenuObjects.Add(colorsTextGO);

            Text colorsText;
            colorsText = colorsTextGO.GetComponent<Text>();
            colorsText.text = "Colors!";
            colorsText.font = welcomeFont;
            colorsText.fontSize = welcomeFontSize + 5;
            colorsText.color = new Color(255, 255, 0);
            colorsText.alignment = TextAnchor.UpperRight;

            RectTransform colorsRectTransform;
            colorsRectTransform = colorsText.GetComponent<RectTransform>();
            colorsRectTransform.localPosition = new Vector3(172, 200, 1);
            colorsRectTransform.sizeDelta = new Vector2(600, 200);

            //Create the 'Start!' button
            GameObject startButtonGO = new GameObject();
            startButtonGO.name = "StartButton";
            startButtonGO.transform.parent = canvasGO.transform;
            startButtonGO.AddComponent<RectTransform>();
            startButtonGO.AddComponent<Image>();
            startButtonGO.AddComponent<Button>();

            mainMenuObjects.Add(startButtonGO);
            startButton = startButtonGO.GetComponent<Button>();

            RectTransform startButtonRectTransform;
            startButtonRectTransform = startButtonGO.GetComponent<RectTransform>();
            startButtonRectTransform.localPosition = new Vector3(0, -1, 0);
            startButtonRectTransform.sizeDelta = new Vector2(300, 100);

            ColorBlock startButtonColors;
            startButtonColors = startButtonGO.GetComponent<Button>().colors;
            startButtonColors.normalColor = new Color(255, 0, 0);
            startButtonColors.highlightedColor = new Color(0, 255, 0);
            startButtonColors.pressedColor = new Color(0, 0, 255);

            startButton.targetGraphic = startButtonGO.GetComponent<Image>();
            startButton.colors = startButtonColors;

            //Create the 'Start!' text in the 'Start!' button
            GameObject startButtonTextGO = new GameObject();
            startButtonTextGO.name = "StartButtonText";
            startButtonTextGO.transform.parent = startButtonGO.transform;
            startButtonTextGO.AddComponent<RectTransform>();
            startButtonTextGO.AddComponent<Text>();

            RectTransform startButtonTextRectTransform;
            startButtonTextRectTransform = startButtonTextGO.GetComponent<RectTransform>();
            startButtonTextRectTransform.anchorMin = new Vector2(0, 0);
            startButtonTextRectTransform.anchorMax = new Vector2(1, 1);
            startButtonTextRectTransform.pivot = new Vector2(0.5f, 0.5f);
            startButtonTextRectTransform.anchoredPosition = new Vector2(0, 0);

            Text startButtonText;
            startButtonText = startButtonTextGO.GetComponent<Text>();
            startButtonText.text = "Start!";
            startButtonText.font = welcomeFont;
            startButtonText.fontSize = welcomeFontSize;
            startButtonText.alignment = TextAnchor.MiddleCenter;
            startButtonText.color = new Color(0, 0, 0);

            //Create the 'Stickers!' button
            GameObject stickersButtonGO = new GameObject();
            stickersButtonGO.name = "StickersButton";
            stickersButtonGO.transform.parent = canvasGO.transform;
            stickersButtonGO.AddComponent<RectTransform>();
            stickersButtonGO.AddComponent<Image>();
            stickersButtonGO.AddComponent<Button>();

            mainMenuObjects.Add(stickersButtonGO);
            stickersButton = stickersButtonGO.GetComponent<Button>();

            RectTransform stickersButtonRectTransform;
            stickersButtonRectTransform = stickersButtonGO.GetComponent<RectTransform>();
            stickersButtonRectTransform.localPosition = new Vector3(0, -170, 0);
            stickersButtonRectTransform.sizeDelta = new Vector2(450, 100);

            ColorBlock stickersButtonColors;
            stickersButtonColors = stickersButtonGO.GetComponent<Button>().colors;
            stickersButtonColors.normalColor = new Color(0, 0, 255);
            stickersButtonColors.highlightedColor = new Color(0, 255, 0);
            stickersButtonColors.pressedColor = new Color(255, 0, 0);

            stickersButton.targetGraphic = stickersButtonGO.GetComponent<Image>();
            stickersButton.colors = stickersButtonColors;

            //Create the 'Stickers!' text in the 'Stickers!' button
            GameObject stickersButtonTextGO = new GameObject();
            stickersButtonTextGO.name = "StickersButtonText";
            stickersButtonTextGO.transform.parent = stickersButtonGO.transform;
            stickersButtonTextGO.AddComponent<RectTransform>();
            stickersButtonTextGO.AddComponent<Text>();

            RectTransform stickersButtonTextRectTransform;
            stickersButtonTextRectTransform = stickersButtonTextGO.GetComponent<RectTransform>();
            stickersButtonTextRectTransform.anchorMin = new Vector2(0, 0);
            stickersButtonTextRectTransform.anchorMax = new Vector2(1, 1);
            stickersButtonTextRectTransform.pivot = new Vector2(0.5f, 0.5f);
            stickersButtonTextRectTransform.anchoredPosition = new Vector2(0, 0);

            Text stickersButtonText;
            stickersButtonText = stickersButtonTextGO.GetComponent<Text>();
            stickersButtonText.text = "Stickers!";
            stickersButtonText.font = welcomeFont;
            stickersButtonText.fontSize = welcomeFontSize;
            stickersButtonText.alignment = TextAnchor.MiddleCenter;
            stickersButtonText.color = new Color(0, 0, 0);

            //Create the 'MainMenu' button
            mainMenuButtonGO = new GameObject();
            mainMenuButtonGO.name = "MainMenuButton";
            mainMenuButtonGO.transform.parent = canvasGO.transform;
            mainMenuButtonGO.AddComponent<RectTransform>();
            mainMenuButtonGO.AddComponent<Image>();
            mainMenuButtonGO.AddComponent<Button>();

            mainMenuButtonGO.SetActive(false);

            mainMenuButton = mainMenuButtonGO.GetComponent<Button>();

            RectTransform mainMenuButtonRectTransform;
            mainMenuButtonRectTransform = mainMenuButtonGO.GetComponent<RectTransform>();
            mainMenuButtonRectTransform.localPosition = new Vector3(0, -170, 0);
            mainMenuButtonRectTransform.sizeDelta = new Vector2(450, 100);

            ColorBlock mainMenuButtonColors;
            mainMenuButtonColors = mainMenuButtonGO.GetComponent<Button>().colors;
            mainMenuButtonColors.normalColor = new Color(0, 0, 255);
            mainMenuButtonColors.highlightedColor = new Color(0, 255, 0);
            mainMenuButtonColors.pressedColor = new Color(255, 0, 0);

            mainMenuButton.targetGraphic = mainMenuButtonGO.GetComponent<Image>();
            mainMenuButton.colors = mainMenuButtonColors;

            //Create the 'mainMenu!' text in the 'mainMenu!' button
            GameObject mainMenuButtonTextGO = new GameObject();
            mainMenuButtonTextGO.name = "MainMenuButtonText";
            mainMenuButtonTextGO.transform.parent = mainMenuButtonGO.transform;
            mainMenuButtonTextGO.AddComponent<RectTransform>();
            mainMenuButtonTextGO.AddComponent<Text>();

            RectTransform mainMenuButtonTextRectTransform;
            mainMenuButtonTextRectTransform = mainMenuButtonTextGO.GetComponent<RectTransform>();
            mainMenuButtonTextRectTransform.anchorMin = new Vector2(0, 0);
            mainMenuButtonTextRectTransform.anchorMax = new Vector2(1, 1);
            mainMenuButtonTextRectTransform.pivot = new Vector2(0.5f, 0.5f);
            mainMenuButtonTextRectTransform.anchoredPosition = new Vector2(0, 0);

            Text mainMenuButtonText;
            mainMenuButtonText = mainMenuButtonTextGO.GetComponent<Text>();
            mainMenuButtonText.text = "Main Menu";
            mainMenuButtonText.font = welcomeFont;
            mainMenuButtonText.fontSize = welcomeFontSize;
            mainMenuButtonText.alignment = TextAnchor.MiddleCenter;
            mainMenuButtonText.color = new Color(0, 0, 0);

            //Create the 'PauseScreen' button
            pauseScreenButtonGO = new GameObject();
            pauseScreenButtonGO.name = "PauseScreenButton";
            pauseScreenButtonGO.transform.parent = canvasGO.transform;
            pauseScreenButtonGO.AddComponent<RectTransform>();
            pauseScreenButtonGO.AddComponent<Image>();
            pauseScreenButtonGO.AddComponent<Button>();

            pauseScreenButtonGO.SetActive(false);

            //pauseScreenObjects.Add(pauseScreenButtonGO);
            pauseScreenButton = pauseScreenButtonGO.GetComponent<Button>();

            RectTransform pauseScreenButtonRectTransform;
            pauseScreenButtonRectTransform = pauseScreenButtonGO.GetComponent<RectTransform>();
            float pauseOffsetMinX = pauseScreenButtonRectTransform.offsetMin.x;
            pauseOffsetMinX = 1673.32f;
            float pauseOffsetMaxX = pauseScreenButtonRectTransform.offsetMax.x;
            pauseOffsetMaxX = 0;
            float pauseOffsetMinY = pauseScreenButtonRectTransform.offsetMin.y;
            pauseOffsetMinY  = 948f;
            float pauseOffsetMaxY = pauseScreenButtonRectTransform.offsetMax.y;
            pauseOffsetMaxY  = 0;

            ColorBlock pauseScreenButtonColors;
            pauseScreenButtonColors = pauseScreenButtonGO.GetComponent<Button>().colors;
            pauseScreenButtonColors.normalColor = new Color(0, 0, 255);
            pauseScreenButtonColors.highlightedColor = new Color(0, 255, 0);
            pauseScreenButtonColors.pressedColor = new Color(255, 0, 0);

            pauseScreenButton.targetGraphic = pauseScreenButtonGO.GetComponent<Image>();
            pauseScreenButton.colors = pauseScreenButtonColors;

            //Create the 'pauseScreen!' text in the 'pauseScreen!' button
            GameObject pauseScreenButtonTextGO = new GameObject();
            pauseScreenButtonTextGO.name = "PauseScreenButtonText";
            pauseScreenButtonTextGO.transform.parent = pauseScreenButtonGO.transform;
            pauseScreenButtonTextGO.AddComponent<RectTransform>();
            pauseScreenButtonTextGO.AddComponent<Text>();

            RectTransform pauseScreenButtonTextRectTransform;
            pauseScreenButtonTextRectTransform = pauseScreenButtonTextGO.GetComponent<RectTransform>();
            pauseScreenButtonTextRectTransform.anchorMin = new Vector2(0, 0);
            pauseScreenButtonTextRectTransform.anchorMax = new Vector2(1, 1);
            pauseScreenButtonTextRectTransform.pivot = new Vector2(0.5f, 0.5f);
            pauseScreenButtonTextRectTransform.anchoredPosition = new Vector2(0, 0);

            Text pauseScreenButtonText;
            pauseScreenButtonText = pauseScreenButtonTextGO.GetComponent<Text>();
            pauseScreenButtonText.text = "||";
            pauseScreenButtonText.font = welcomeFont;
            pauseScreenButtonText.fontSize = welcomeFontSize;
            pauseScreenButtonText.alignment = TextAnchor.MiddleCenter;
            pauseScreenButtonText.color = new Color(0, 0, 0);

            //Create text boxes for colors and shapes
            for(int i = 0; i < 3; i++)
            {
                GameObject textHolderGO = new GameObject();
                textHolderGO.name = "TextHolder_" + i;
                textHolderGO.transform.parent = canvasGO.transform;
                textHolderGO.AddComponent<RectTransform>();
                textHolderGO.AddComponent<Text>();
                textHolderGO.SetActive(false);

                playObjects.Add(textHolderGO);
            }

            pauseScreenGO = new GameObject();
            pauseScreenGO.name = "PauseScreen";
            pauseScreenGO.transform.parent = canvasGO.transform;
            pauseScreenGO.SetActive(false);

            //Create the 'PauseScreen' text
            GameObject pauseScreenTextGO = new GameObject();
            pauseScreenTextGO.name = "PauseScreenText";
            pauseScreenTextGO.transform.parent = pauseScreenGO.transform;
            pauseScreenTextGO.AddComponent<RectTransform>();
            pauseScreenTextGO.AddComponent<Text>();

            Text pauseScreenText;
            pauseScreenText = pauseScreenTextGO.GetComponent<Text>();
            pauseScreenText.text = "Game Paused";
            pauseScreenText.font = welcomeFont;
            pauseScreenText.fontSize = welcomeFontSize + 5;
            pauseScreenText.color = new Color(255, 255, 0);
            pauseScreenText.alignment = TextAnchor.MiddleCenter;


            Debug.Log("Welcome to Shapes & Colors!");
        }

        
        void Start()
        {
            startButton.onClick.AddListener(StartGame);
            stickersButton.onClick.AddListener(GoToStickers);
            mainMenuButton.onClick.AddListener(MainMenu);
            pauseScreenButton.onClick.AddListener(Pause);

        }

        

        void StartGame()
        {
            Debug.Log("Game Started!");
            gameController.PlayGame();
        }
        void GoToStickers()
        {
            Debug.Log("Moving to sticker book.");
            gameController.StickerBook();
        }
        void MainMenu()
        {
            Debug.Log("Moving to main menu.");
            gameController.MainMenu();
        }
        private void Pause()
        {
            Debug.Log("Game is paused.");
            gameController.Pause(GameController._GameState.Paused);
        }
    }
}