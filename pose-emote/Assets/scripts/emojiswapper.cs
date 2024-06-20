using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Emojiswapper : MonoBehaviour
{
    public GameObject rController;
    public GameObject lController;
    public GameObject head;
    public Image uiImage;
    public Sprite defImage;
    public Sprite xArmsPose;
    public Sprite facepalmPose;
    public Sprite wavePose;
    private bool isFacePalmActive = false;
    // Update is called once per frame
    void Update()
    {
        if (!isFacePalmActive)
        {
            Vector3 rControllerPosition = rController.transform.position;
            Vector3 lControllerPosition = lController.transform.position;
            Vector3 headPos = head.transform.position;
            if (Mathf.Abs(rControllerPosition.y - lControllerPosition.y) < 0.1f)
            {
                if (rControllerPosition.x < headPos.x && lControllerPosition.x > headPos.x)
                {
                    uiImage.sprite = xArmsPose;
                }
                else
                {
                    uiImage.sprite = defImage;
                }
            }
            else
            {
                uiImage.sprite = defImage;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == rController || other.gameObject == lController)
        {
            if (!isFacePalmActive)
            {
                StartCoroutine(ShowFacePalmImage());
            }
        }
    }
    IEnumerator ShowFacePalmImage()
    {
        isFacePalmActive = true;
        uiImage.sprite = facepalmPose;
        yield return new WaitForSeconds(3);
        isFacePalmActive = false;
    }
}