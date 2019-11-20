using System;
 using UnityEngine;
 using System.Collections.Generic;
 using UnityEngine.EventSystems;
 
 //I used IL2 to copy out the Physicsraycaster code and fix where the ray eminates from (in this case, always the center of the screen)
 public class InteractionRaycaster : PhysicsRaycaster {
 
     [Range(0.0f, 0.5f)]
     public float RayRadius;
 
     private readonly Vector2 _viewPos = new Vector2(0.5f, 0.5f);
   
     public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
     {
         if (!(this.eventCamera == null))
         {
             Ray ray = this.eventCamera.ViewportPointToRay(_viewPos);//this used to be the event position, but when the cursor is locked, that becomes -1,-1 so i fixed it
             float distance = this.eventCamera.farClipPlane - this.eventCamera.nearClipPlane;
             RaycastHit[] array = Physics.SphereCastAll(ray, RayRadius, distance, this.finalEventMask);
             if (array.Length > 1)
             {
                 Array.Sort<RaycastHit>(array, (RaycastHit r1, RaycastHit r2) => r1.distance.CompareTo(r2.distance));
             }
             if (array.Length != 0)
             {
                 int i = 0;
                 int num = array.Length;
                 while (i < num)
                 {
                     RaycastResult item = new RaycastResult
                     {
                         gameObject = array[i].collider.gameObject,
                         module = this,
                         distance = array[i].distance,
                         worldPosition = array[i].point,
                         worldNormal = array[i].normal,
                         screenPosition = _viewPos,
                         index = (float)resultAppendList.Count,//dunno why this is a float
                         sortingLayer = 0,
                         sortingOrder = 0
                     };
                         
                     resultAppendList.Add(item);
                     i++;
                 }
             }
         }
     }
 }