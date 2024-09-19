using UnityEngine;

public class GalleryImages : MonoBehaviour
{
    public GameObject nextBtn;
    public GameObject prevBtn;

    public string[] mImg;   // Initialise empty array

    private int counter = 0;    // Counter for image position in gallery

    // Initialise array with image names
    void Start()
    {
        mImg = new string[] { "galleryImage1", "galleryImage2", "galleryImage3", "galleryImage4"}; 
    }

    // Function to display next image in gallery
    public void next()
    {
        counter++;
        checkBtns();
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(mImg[counter]);
    }

    // Function to display previous image in gallery
    public void prev()
    {
        counter--;
        checkBtns();
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(mImg[counter]);
    }

    // Function to toggle navigation buttons based on position in gallery
    private void checkBtns()
    {
        if (counter < 1) {
            prevBtn.SetActive(false);
        }
        else
        {
            prevBtn.SetActive(true);
        }
        if (counter > mImg.Length - 2)
        {
            nextBtn.SetActive(false);
        }
        else
        {
            nextBtn.SetActive(true);
        }
    }
}
