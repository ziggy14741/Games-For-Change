using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Menu;

   public void Menuturnon()
    {
        Menu.SetActive(!Menu.activeSelf);
    }
}
