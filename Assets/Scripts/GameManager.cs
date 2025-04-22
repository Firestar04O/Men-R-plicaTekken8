using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public AudioSource Kazuyamusic;
    public AudioSource Kingmusic;
    public AudioSource Jinmusic;
    public Material Eye;
    public GameObject AllCameras;
    public CinemachineVirtualCamera camerastart;
    public CinemachineVirtualCamera camerahead;
    public CinemachineVirtualCamera camerachest;
    public CinemachineVirtualCamera cameraback;
    public CinemachineVirtualCamera cameraarm;
    public CinemachineVirtualCamera camerarighthead;
    public CinemachineVirtualCamera cameratotalfront;
    public GameObject StartPanel;
    public GameObject SummaryPanel;
    public GameObject StoryPanel;
    public GameObject OfflinePanel;
    public GameObject OnlinePanel;
    public GameObject CustomizationPanel;
    public GameObject ReplayPanel;
    private void Start()
    {
        ActivateCamera(camerastart);
        ShowStartPanel();
    }
    public void ActivateCamera(CinemachineVirtualCamera camera)
    {
        camera.Priority = 30;
        if (camerastart == camera)
        {
            camerahead.Priority = 10;
            camerachest.Priority = 10;
            cameraarm.Priority = 10;
            cameraback.Priority = 10;
            camerarighthead.Priority = 10;
            cameratotalfront.Priority = 10;
        }
        else if (camerahead == camera)
        {
            camerastart.Priority = 10;
            camerachest.Priority = 10;
            cameraarm.Priority = 10;
            cameraback.Priority = 10;
            camerarighthead.Priority = 10;
            cameratotalfront.Priority = 10;
        }
        else if (camerachest == camera)
        {
            camerastart.Priority = 10;
            camerahead.Priority = 10;
            cameraarm.Priority = 10;
            cameraback.Priority = 10;
            camerarighthead.Priority = 10;
            cameratotalfront.Priority = 10;
        }
        else if (cameraarm == camera)
        {
            camerastart.Priority = 10;
            camerahead.Priority = 10;
            camerachest.Priority = 10;
            cameraback.Priority = 10;
            camerarighthead.Priority = 10;
            cameratotalfront.Priority = 10;
        }
        else if (cameraback == camera)
        {
            camerastart.Priority = 10;
            camerahead.Priority = 10;
            camerachest.Priority = 10;
            cameraarm.Priority = 10;
            camerarighthead.Priority = 10;
            cameratotalfront.Priority = 10;
        }
        else if (camerarighthead == camera)
        {
            camerastart.Priority = 10;
            camerahead.Priority = 10;
            camerachest.Priority = 10;
            cameraarm.Priority = 10;
            cameraback.Priority = 10;
            cameratotalfront.Priority = 10;
        }
        else if (cameratotalfront == camera)
        {
            camerastart.Priority = 10;
            camerahead.Priority = 10;
            camerachest.Priority = 10;
            cameraarm.Priority = 10;
            cameraback.Priority = 10;
            camerarighthead.Priority = 10;
        }
    }
    public void ShowStartPanel()
    {
        StartPanel.SetActive(true);
        SummaryPanel.SetActive(false);
        StoryPanel.SetActive(false);
        OfflinePanel.SetActive(false);
        OnlinePanel.SetActive(false);
        CustomizationPanel.SetActive(false);
        ReplayPanel.SetActive(false);

        ActivateCamera(camerastart);
    }
    public void ShowSummaryPanel()
    {
        StartPanel.SetActive(false);
        SummaryPanel.SetActive(true);
        StoryPanel.SetActive(false);
        OfflinePanel.SetActive(false);
        OnlinePanel.SetActive(false);
        CustomizationPanel.SetActive(false);
        ReplayPanel.SetActive(false);

        ActivateCamera(camerahead);
    }
    public void ShowStoryPanel()
    {
        StartPanel.SetActive(false);
        SummaryPanel.SetActive(false);
        StoryPanel.SetActive(true);
        OfflinePanel.SetActive(false);
        OnlinePanel.SetActive(false);
        CustomizationPanel.SetActive(false);
        ReplayPanel.SetActive(false);

        ActivateCamera(camerachest);
    }
    public void ShowOfflinePanel()
    {
        StartPanel.SetActive(false);
        SummaryPanel.SetActive(false);
        StoryPanel.SetActive(false);
        OfflinePanel.SetActive(true);
        OnlinePanel.SetActive(false);
        CustomizationPanel.SetActive(false);
        ReplayPanel.SetActive(false);

        ActivateCamera(cameraback);
    }
    public void ShowOnlinePanel()
    {
        StartPanel.SetActive(false);
        SummaryPanel.SetActive(false);
        StoryPanel.SetActive(false);
        OfflinePanel.SetActive(false);
        OnlinePanel.SetActive(true);
        CustomizationPanel.SetActive(false);
        ReplayPanel.SetActive(false);

        ActivateCamera(cameraarm);
    }
    public void ShowCustomizationPanel()
    {
        StartPanel.SetActive(false);
        SummaryPanel.SetActive(false);
        StoryPanel.SetActive(false);
        OfflinePanel.SetActive(false);
        OnlinePanel.SetActive(false);
        CustomizationPanel.SetActive(true);
        ReplayPanel.SetActive(false);

        ActivateCamera(camerarighthead);
    }
    public void ShowReplayPanel()
    {
        StartPanel.SetActive(false);
        SummaryPanel.SetActive(false);
        StoryPanel.SetActive(false);
        OfflinePanel.SetActive(false);
        OnlinePanel.SetActive(false);
        CustomizationPanel.SetActive(false);
        ReplayPanel.SetActive(true);

        ActivateCamera(cameratotalfront);
    }
    public void QuitOfMyGame()
    {
        Debug.Log("Ha salido del programa");
        Application.Quit();
    }
    public void Tocharacter1()
    {
        AllCameras.transform.position = new Vector3(0, 0, 0);
        Kazuyamusic.Stop();
        Kingmusic.Stop();
        Jinmusic.Stop();
        Kazuyamusic.Play();
    }
    public void Tocharacter2()
    {
        AllCameras.transform.position = new Vector3(-240, 0, 0);
        Kazuyamusic.Stop();
        Kingmusic.Stop();
        Jinmusic.Stop();
        Kingmusic.Play();
    }
    public void Tocharacter3()
    {
        AllCameras.transform.position = new Vector3(-480, 0, 0);
        Kazuyamusic.Stop();
        Kingmusic.Stop();
        Jinmusic.Stop();
        Jinmusic.Play();
    }
}

