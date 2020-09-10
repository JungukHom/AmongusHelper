namespace Marucorp.AmongusHelper
{
    // C#
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    // Unity
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;

    // Project
    // Alias

    public class UIController : MonoBehaviour
    {
        // Class instance
        public static UIController _instance;

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        // Images
        [Header("Images")]
        public Image mapImage;
        public Image selectedCrewmateImage;

        // Buttons
        [Header("Buttons")]
        public Button questionButton;
        public Button safeButton;
        public Button deadButton;

        public Button resetButton;
        public Button quitButton;

        // Map Change Buttons
        [Header("Map Change Buttons")]
        public Button skeldButotn;
        public Button miraHqButton;
        public Button polusButton;

        // Selected Crewmate
        public Crewmate currentCrewmate;

        private void Awake()
        {
            _instance = this;
        }

        private void Start()
        {
            questionButton.onClick.AddListener(delegate { OnQuestionButtonClicked(); });
            safeButton.onClick.AddListener(delegate { OnSafeButtonClicked(); });
            deadButton.onClick.AddListener(delegate { OnDeadButtonClicked(); });

            resetButton.onClick.AddListener(delegate { OnResetButtonClicked(); });
            quitButton.onClick.AddListener(delegate { OnQuitButtonClicked(); });

            skeldButotn.onClick.AddListener(delegate { OnMapButtonClicked(MapName.THE_SKELD); });
            miraHqButton.onClick.AddListener(delegate { OnMapButtonClicked(MapName.MIRA_HQ); });
            polusButton.onClick.AddListener(delegate { OnMapButtonClicked(MapName.POLUS); });
        }

        public void SetCurrentCrewmate(Crewmate crewmate)
        {
            this.currentCrewmate = crewmate;
            selectedCrewmateImage.sprite = crewmate.GetCrewmateSprite();
        }

        public void OnQuestionButtonClicked()
        {
            if (!currentCrewmate)
            {
                return;
            }
            currentCrewmate.SetIdentifierImage(ImageHolder.instance.GetQuestionImage());
        }

        public void OnSafeButtonClicked()
        {
            if (!currentCrewmate)
            {
                return;
            }
            currentCrewmate.SetIdentifierImage(ImageHolder.instance.GetSafeImage());
        }

        public void OnDeadButtonClicked()
        {
            if (!currentCrewmate)
            {
                return;
            }
            currentCrewmate.SetIdentifierImage(ImageHolder.instance.GetDeadImage());
        }

        public void OnResetButtonClicked()
        {
            currentCrewmate = null;

            Crewmate[] crewmates = FindObjectsOfType<Crewmate>();
            foreach (Crewmate crewmate in crewmates)
            {
                crewmate.ResetPosition();
                crewmate.ResetIdentifier();
            }

            //SceneManager.LoadScene(0);
        }

        public void OnQuitButtonClicked()
        {
            Application.Quit();
        }

        public void OnMapButtonClicked(MapName name)
        {
            

            mapImage.sprite = ImageHolder.instance.GetMapImageWithEnum(name);
        }

        public void ResetCrewmates()
        {
            currentCrewmate = null;

            Crewmate[] crewmates = FindObjectsOfType<Crewmate>();
            foreach (Crewmate crewmate in crewmates)
            {
                crewmate.ResetPosition();
                crewmate.ResetIdentifier();
            }
        }
    }
}