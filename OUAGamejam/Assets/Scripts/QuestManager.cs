using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
   [SerializeField] private GameObject QuestCanvas;
   private bool isOpen=false;
   private void Update()
   {
      OpenPanel();
   }

   private void OpenPanel()
   {
      if (Input.GetKeyDown(KeyCode.Tab)&&!isOpen)
      {
         QuestCanvas.SetActive(true);
         isOpen = true;
      }
      else if (Input.GetKeyDown(KeyCode.Tab)&&isOpen)
      {
         QuestCanvas.SetActive(false);
         isOpen = false;
      }
   }
}
