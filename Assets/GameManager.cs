using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject leftIndexFingerTip;
    [SerializeField] private GameObject rightIndexFingerTip;

    [SerializeField] private GameObject rightMiniHeart;
    [SerializeField] private GameObject leftMiniHeart;
    [SerializeField] private GameObject mediumHeart;
    [SerializeField] private GameObject mediumDevilHeart;
    [SerializeField] private GameObject mediumBelowHeart;
    [SerializeField] private GameObject largeHeart;
    
    private float MediumHeardHandDistance;
    private bool MediumHeartHandActivated = false;
    private bool MediumPinkyHeartHandActivated = false;
    private bool MediumBelowHeartHandActivated = false;

    private void Start()
    {
        rightMiniHeart.SetActive(false);
        leftMiniHeart.SetActive(false);
        mediumHeart.SetActive(false);
        mediumDevilHeart.SetActive(false);
        mediumBelowHeart.SetActive(false);
        largeHeart.SetActive(false);
    }

    void Update()
    {
        Vector3 leftHandPosition = leftIndexFingerTip.transform.position;
        Vector3 rightHandPosition = rightIndexFingerTip.transform.position;

        MediumHeardHandDistance = Vector3.Distance(leftHandPosition, rightHandPosition);

        if (MediumHeardHandDistance < 0.05f && MediumHeartHandActivated == true)
        {
            mediumHeart.SetActive(true);
        }
        
        if (MediumHeardHandDistance < 0.05f && MediumPinkyHeartHandActivated == true)
        {
            mediumDevilHeart.SetActive(true);
        }
        
        if (MediumHeardHandDistance < 0.05f && MediumBelowHeartHandActivated == true)
        {
            mediumBelowHeart.SetActive(true);
        }
        
        if(MediumHeardHandDistance > 0.05f)
        {
            mediumHeart.SetActive(false);
            mediumDevilHeart.SetActive(false);
            mediumBelowHeart.SetActive(false);
        }
    }

    public void MediumHeartHandActivatedCheckHandProximity()
    {
        MediumHeartHandActivated = true;
    }
    
    public void MediumHeartHandDeactivated()
    {
        MediumHeartHandActivated = false;
    }

    public void MediumPinkyHeartHandActivatedCheckHandProximity()
    {
        MediumPinkyHeartHandActivated = true;
        mediumHeart.SetActive(false);
    }
    
    public void MediumPinkyHeartHandDeactivated()
    {
        MediumPinkyHeartHandActivated = false;
    }
    
    public void MediumBelowHeartHandActivatedCheckHandProximity()
    {
        MediumBelowHeartHandActivated = true;
    }
    
    public void MediumBelowHeartHandDeactivated()
    {
        MediumBelowHeartHandActivated = false;
    }
    
    public void LeftMiniHeartActivated()
    {
        leftMiniHeart.SetActive(true);
    }
    
    public void RightMiniHeartActivated()
    {
        rightMiniHeart.SetActive(true);
    }
    
    public void LeftMiniHeartDeactivated()
    {
        leftMiniHeart.SetActive(false);
    }
    
    public void RightMiniHeartDeactivated()
    {
        rightMiniHeart.SetActive(false);
    }
    
    public void LargeHeartActivated()
    {
        largeHeart.SetActive(true);
    }
    
    public void LargeHeartDeactivated()
    {
        largeHeart.SetActive(false);
    }

}
