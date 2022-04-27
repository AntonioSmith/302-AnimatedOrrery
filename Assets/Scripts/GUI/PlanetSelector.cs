using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlanetSelector : MonoBehaviour
{
    #region variables
    public Camera cam;
    public bool isFollowing = false;
    public bool isVisible = false;
    public Transform target;
    public Image panel;
    public Vector3 cameraStartPosition;
    //public Transform cameraStartRotation;

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Pop;
    public TextMeshProUGUI Habit;
    public TextMeshProUGUI Description;

    public GameObject Solos;
    public GameObject Terros;
    public GameObject Lymphos;
    public GameObject Tempos;
    public GameObject Glados;
    public GameObject Luminos;
    public GameObject Phyros;
    #endregion

    private void Start()
    {
        panel.gameObject.SetActive(false);
        cam.transform.position = cameraStartPosition;
    }

    private void Update()
    {
        cam.transform.LookAt(target);
        if (isFollowing)
        {
            cam.transform.position = AnimMath.Slide(cam.transform.position, target.position, .50f);
        }
    }

    public void FollowSolos()
    {
        target = Solos.transform;
        isFollowing = false;
        panel.gameObject.SetActive(true);
        Name.text = "Planet Name: Solos";
        Pop.text = "Population: 0";
        Habit.text = "Habitability: UNINHABITABLE";
        Description.text = "Description: The Sun";
    }
    public void FollowTerros()
    {
        target = Terros.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Planet Name: Terros";
        Pop.text = "Population: Unknown";
        Habit.text = "Habitability: 65%";
        Description.text = "Description: The Rocky Giant";
    }
    public void FollowPhyros()
    {
        target = Phyros.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Planet Name: Phyros";
        Pop.text = "Population: 0";
        Habit.text = "Habitability: UNINHABITABLE";
        Description.text = "Description: The Molten Planet";
    }
    public void FollowLymphos()
    {
        target = Lymphos.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Planet Name: Lymphos";
        Pop.text = "Population: Billions~";
        Habit.text = "Habitability: 50% - Inhabitants Hostile";
        Description.text = "Description: The Warring Water World";
    }
    public void FollowTempos()
    {
        target = Tempos.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Planet Name: Tempos";
        Pop.text = "Population: Millions~";
        Habit.text = "Habitability: 30%";
        Description.text = "Description: The Raging Stormbringer";
    }
    public void FollowGlados()
    {
        target = Glados.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Planet Name: Glados";
        Pop.text = "Population: 0";
        Habit.text = "Habitability: UNINHABITABLE";
        Description.text = "Description: The Frozen Wasteland";
    }
    public void FollowLuminos()
    {
        target = Luminos.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Planet Name: Luminos";
        Pop.text = "Population: Millions~";
        Habit.text = "Habitability: 100%";
        Description.text = "Description: The Galactic Mana Hub";
    }
    public void FollowNone()
    {
        isFollowing = false;
        cam.transform.position = cameraStartPosition;
        panel.gameObject.SetActive(false);
    }
}
