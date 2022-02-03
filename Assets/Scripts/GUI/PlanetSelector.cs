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
    }

    private void Update()
    {
        cam.transform.LookAt(target);
        if (isFollowing)
        {
            cam.transform.position = AnimMath.Slide(cam.transform.position, target.position, .01f);
        }
    }

    public void FollowSolos()
    {
        target = Solos.transform;
        isFollowing = false;
        panel.gameObject.SetActive(true);
        Name.text = "Solos";
        Pop.text = "0";
        Habit.text = "UNINHABITABLE";
        Description.text = "The Sun";
    }
    public void FollowTerros()
    {
        target = Terros.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Terros";
        Pop.text = "Unknown";
        Habit.text = "65%";
        Description.text = "The Rocky Giant";
    }
    public void FollowPhyros()
    {
        target = Phyros.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Phyros";
        Pop.text = "0";
        Habit.text = "UNINHABITABLE";
        Description.text = "The Molten Planet";
    }
    public void FollowLymphos()
    {
        target = Lymphos.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Lymphos";
        Pop.text = "Billions~";
        Habit.text = "50% - Inhabitants Hostile";
        Description.text = "The Warring Water World";
    }
    public void FollowTempos()
    {
        target = Tempos.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Tempos";
        Pop.text = "Millions~";
        Habit.text = "30%";
        Description.text = "The Raging Stormbringer";
    }
    public void FollowGlados()
    {
        target = Glados.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Glados";
        Pop.text = "0";
        Habit.text = "UNINHABITABLE";
        Description.text = "The Frozen Wasteland";
    }
    public void FollowLuminos()
    {
        target = Luminos.transform;
        isFollowing = true;
        panel.gameObject.SetActive(true);
        Name.text = "Luminos";
        Pop.text = "Millions~";
        Habit.text = "100%";
        Description.text = "The Galactic Mana Hub";
    }
    public void FollowNone()
    {
        target = Solos.transform;
        isFollowing = false;
        panel.gameObject.SetActive(false);
    }
}
