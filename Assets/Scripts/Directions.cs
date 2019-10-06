
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class Directions : MonoBehaviour
{
    public direction select;
    public static string selectedDirection;
    
   
    public enum direction
    {
        right, left, up, down,none
    }

    public void AssigDirection()
    {
        selectedDirection = select.ToString();
        ManageScreen.Instance.movementTarget--;
        if(ManageScreen.Instance.movementTarget==0)
        {
            ManageScreen.Instance.LoseScreen();
        }
    }
   
   

    
}
