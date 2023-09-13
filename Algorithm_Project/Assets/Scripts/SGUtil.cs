using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SGUtil
{
    public static readonly Vector3 VECTOR3_ZERO = Vector3.zero;
    public static readonly Vector3 VECTOR3_ONE = Vector3.one;
    public static readonly Vector3 VECTOR3_HALF = new Vector3(0.5f, 0.5f, 0.5f);

    public static readonly Vector2 VECTOR2_ZERO = Vector2.zero;
    public static readonly Vector2 VECTOR2_ONE = Vector2.one;
    public static readonly Vector2 VECTOR2_HALF = new Vector2(0.5f, 0.5f);

    public static readonly Quaternion QUATERNION_IDENTITY = Quaternion.identity;

    public enum AXIS
    {
        X_AXIS_Y,
        X_AXIS_Z,
    }

    public enum TIME
    {
        DELTA_TIME,
        UNSCALED_DELTA_TIME,
        FIXED_DELTA_TIME,
    }

    public static float GetAngleFromTwoPosition(Transform fromTrans, Transform toTrnas, AXIS axisMove)
    {
        switch (axisMove)
        {
            case AXIS.X_AXIS_Y:
                return 0;//GetZangleFromTwoPosition(fornmTrans,toTrans);
            case AXIS.X_AXIS_Z:
                return 0;//GetYangleFromTwoPosition(fornmTrans,toTrans);
            default:
                return 0;
        }
    }

    private static float GetZangleFromTwoPosition(Transform fromTrans, Transform toTrans)
    {
        if(fromTrans == null || toTrans == null)
        {
            return 0f;
        }

        float xDIstance = toTrans.position.x - fromTrans.position.x;
        float yDistance = toTrans.position.y - fromTrans.position.y;
        float angle = (Mathf.Atan2(yDistance, xDIstance) * Mathf.Rad2Deg) - 90.0f;

        return angle;
    }

    private static float GetYangleFromTwoPosition(Transform fromTrans, Transform toTrans)
    {
        if (fromTrans == null || toTrans == null)
        {
            return 0f;
        }

        float xDIstance = toTrans.position.x - fromTrans.position.x;
        float zDistance = toTrans.position.z - fromTrans.position.z;
        float angle = (Mathf.Atan2(zDistance, xDIstance) * Mathf.Rad2Deg) - 90.0f;

        return angle;
    }

    public static float GetNormalizedAngle(float angle)
    {
        while (angle < 0f)
        {
            angle += 360f;
        }
        while (360f < angle)
        {
            angle -= 360f;
        }
        return angle;
    }
}
