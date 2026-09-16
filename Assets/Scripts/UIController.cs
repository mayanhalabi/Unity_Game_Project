using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Image

            heart1,
            heart2,
            heart3;

    public Sprite

            heratFull,
            heartEmpty;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
    }

    void Update()
    {
    }

    public void UpdateHealthDisplay()
    {
        switch (PlayerHealthController.instance.currentHealth)
        {
            case 3:
                heart1.sprite = heratFull;
                heart2.sprite = heratFull;
                heart3.sprite = heratFull;
                break;
            case 2:
                heart1.sprite = heratFull;
                heart2.sprite = heratFull;
                heart3.sprite = heartEmpty;
                break;
            case 1:
                heart1.sprite = heratFull;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                break;
            case 0:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                break;
        }
    }
}
