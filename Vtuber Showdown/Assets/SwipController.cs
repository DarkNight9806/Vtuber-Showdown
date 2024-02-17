using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipController : MonoBehaviour
{
   [SerializeField] int maxPage;
   int currentPage;
   Vector3 targetPos;
   [SerializeField] Vector3 pageStep;
   [SerializeField] RectTransform levelPagesReact;
   [SerializeField] float tweenTime;
   [SerializeField] LeanTweenType tweenType;

 private void Awake() {
    currentPage = 1;
    targetPos = levelPagesReact.localPosition;
   }
   public void Next(){
        if (currentPage < maxPage) {
            currentPage++;
            targetPos += pageStep;
            MovePage();
        }
   }

   public void Previous(){
    if (currentPage > 1) {
        currentPage--;
        targetPos -= pageStep;
        MovePage();
    }
   } 

   void MovePage(){
     levelPagesReact.LeanMoveLocal(targetPos,tweenTime).setEase(tweenType);
   }
}
