using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
    public GameObject StartPanel,WinPanel,LoosePanel;
    public GameObject CyclePrefab, SwimPrefab, WeightPrefab, ShootPrefab;

    public Text ChangeText;
    private void Update()
    {
        GameObject[] Obs = GameObject.FindGameObjectsWithTag("ObsO");
        GameObject[] Ocircle = GameObject.FindGameObjectsWithTag("Ocircle");

        if(Obs.Length==0 && Ocircle.Length == 5)
        {
            Debug.Log("You WIn");
            WinPanel.SetActive(true);
        }
        if (FireScript.GameOver)
        {
            LoosePanel.SetActive(true);
        }
    }

    public void Cycle()
    {
        StartPanel.SetActive(false);
        Instantiate(CyclePrefab, transform.position, Quaternion.identity);
        ChangeText.text = "You Enlighted Cycling Proceed to another games";
    }
    public void Swim()
    {
        StartPanel.SetActive(false);
        Instantiate(SwimPrefab, transform.position, Quaternion.identity);
        ChangeText.text = "You Enlighted Swimming Proceed to another games";
    }

    public void Weight()
    {
        StartPanel.SetActive(false);
        Instantiate(WeightPrefab, transform.position, Quaternion.identity);
        ChangeText.text = "You Enlighted Weight Lifting Proceed to another games";
    }
    public void Shoot()
    {
        StartPanel.SetActive(false);
        Instantiate(ShootPrefab, transform.position, Quaternion.identity);
        ChangeText.text = "You Enlighted Shooting Proceed to another games";
    }

   public void MainMenu()
    {
        WinPanel.SetActive(false);
        LoosePanel.SetActive(false);
        StartPanel.SetActive(true);
        FireScript.GameOver = false;
        //  GameObject.FindGameObjectWithTag("Cycle").SetActive(false);
        Destroy(GameObject.FindGameObjectWithTag("Cycle"));
        Destroy(GameObject.FindGameObjectWithTag("Swim"));
        Destroy(GameObject.FindGameObjectWithTag("Shoot"));
        Destroy(GameObject.FindGameObjectWithTag("Weight"));
    }
}
