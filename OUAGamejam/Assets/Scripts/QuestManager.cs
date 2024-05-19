using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuestManager : MonoBehaviour
{
   [SerializeField] private GameObject questCanvas;
   [SerializeField] private TextMeshProUGUI hourGlassesText;
   [SerializeField] private TextMeshProUGUI taskText;
   private bool isOpen=false;

   private static QuestManager instance;

   public static QuestManager Instance
   {
      get
      {
         if (instance==null)
         {
            instance = FindObjectOfType<QuestManager>(true);
         }

         return instance;
      }
   }

   private void Awake()
   {
      instance = this;
   }

   private void Update()
   {
      OpenPanel();
   }

   private void OpenPanel()
   {
      if (Input.GetKeyDown(KeyCode.Tab)&&!isOpen)
      {
         questCanvas.SetActive(true);
         isOpen = true;
      }
      else if (Input.GetKeyDown(KeyCode.Tab)&&isOpen)
      {
         questCanvas.SetActive(false);
         isOpen = false;
      }
   }

   public string HourGlassesText
   {
      get
      {
         return hourGlassesText.text;
      }
      set
      {
         hourGlassesText.text = value;
      }
   }

   public string TaskText
   {
      get
      {
         return taskText.text;
      }
      set
      {
         taskText.text = value;
      }
   }
   
}
