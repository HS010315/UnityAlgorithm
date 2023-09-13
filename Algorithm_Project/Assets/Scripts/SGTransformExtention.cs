using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class SGTransformExtention
{
    public static void ResetTransform(this Transform self, bool worldSpace = false)
    {
        self.ResetPosition(worldSpace);
        self.ResetRotation(worldSpace);
        self.ResetLocalScale();
    }

    public static void ResetPosition(this Transform self, bool worldSpace = false)
    {
        if(worldSpace)
        {
            self.position = SGUtil.VECTOR3_ZERO;
        }
        else
        {
            self.localPosition = SGUtil.VECTOR3_ZERO;
        }
    }

    public static void ResetRotation(this Transform self, bool worldSpace = false)
    {
        if (worldSpace)
        {
            self.rotation = Quaternion.identity;
        }
        else
        {
            self.localRotation = Quaternion.identity;
        }
    }

    public static void ResetLocalScale(this Transform self)
    {
        self.localScale = SGUtil.VECTOR3_ONE;
    }

    public static void setEulerAnlesX(this Transform self, float x)
    {
        Vector3 selfAngles = self.eulerAngles;
        self.rotation = Quaternion.Euler(x, selfAngles.y, selfAngles.z);
    }
    public static void setEulerAnlesY(this Transform self, float y)
    {
        Vector3 selfAngles = self.eulerAngles;
        self.rotation = Quaternion.Euler(selfAngles.x, y , selfAngles.z);
    }
    public static void setEulerAnlesZ(this Transform self, float z)
    {
        Vector3 selfAngles = self.eulerAngles;
        self.rotation = Quaternion.Euler(selfAngles.x, selfAngles.y, z);
    }

}
