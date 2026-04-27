using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class GridDebugObject : MonoBehaviour
{
   private object gridObject;

   public virtual void SetGridObject(object gridObject)
    {
        this.gridObject = gridObject;

    }

    protected virtual void Update ()
    {
        
    }
}
