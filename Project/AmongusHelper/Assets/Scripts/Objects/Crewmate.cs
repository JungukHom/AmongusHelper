namespace Marucorp.AmongusHelper
{
    // C#
    using System.Collections;
    using System.Collections.Generic;

    // Unity
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.EventSystems;

    // Project
    // Alias

    public class Crewmate : MonoBehaviour, IPointerDownHandler, IDragHandler
    {
        // UI Instance
        [Header("UI Instance")]
        public Button crewerButton;
        public Image identifierImage;

        // Private Variables
        public Vector3 defaultPosition;

        private void Awake()
        {
            defaultPosition = transform.position;
        }

        public void ResetPosition()
        {
            transform.position = defaultPosition;
        }

        public void ResetIdentifier()
        {
            identifierImage.sprite = ImageHolder.instance.GetQuestionImage();
        }

        public Sprite GetCrewmateSprite()
        {
            return crewerButton.image.sprite;
        }

        public void SetIdentifierImage(Sprite sprite)
        {
            identifierImage.sprite = sprite;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            UIController._instance.SetCurrentCrewmate(this);
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }
    }
}