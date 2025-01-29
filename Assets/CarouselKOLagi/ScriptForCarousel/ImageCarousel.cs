using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lahai : MonoBehaviour
{
    public Image carouselPanel;
    public Image[] images;
    private int currentIndex = 0;

    private void Start()
    {
        UpdateCarouselImage();
    }

    public void ShowNextImage()
    {
        currentIndex = (currentIndex + 1) % images.Length;
        UpdateCarouselImage();
    }

    public void ShowPreviousImage()
    {
        currentIndex = (currentIndex - 1 + images.Length) % images.Length;
        UpdateCarouselImage();
    }

    private void UpdateCarouselImage()
    {
        carouselPanel = images[currentIndex];
    }
}
