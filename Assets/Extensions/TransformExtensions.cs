using UnityEngine;

namespace OTools.Extensions
{
    public static class TransformExtensions
    {
        #region Set Position X-Y-Z

        public static void SetPositionX(this Transform transform, float xPos)
        {
            Vector3 tempPos = transform.position;
            tempPos.x = xPos;
            transform.position = tempPos;
        }
        
        public static void SetPositionY(this Transform transform, float yPos)
        {
            Vector3 tempPos = transform.position;
            tempPos.y = yPos;
            transform.position = tempPos;
        }
        
        public static void SetPositionZ(this Transform transform, float zPos)
        {
            Vector3 tempPos = transform.position;
            tempPos.z = zPos;
            transform.position = tempPos;
        }

        #endregion
        
        #region Shift Position X-Y-Z
        
        public static void ShiftPositionX(this Transform transform, float offsetX)
        {
            Vector3 tempPos = transform.position;
            tempPos.x += offsetX;
            transform.position = tempPos;
        }
        
        public static void ShiftPositionY(this Transform transform, float offsetY)
        {
            Vector3 tempPos = transform.position;
            tempPos.y += offsetY;
            transform.position = tempPos;
        }
        
        public static void ShiftPositionZ(this Transform transform, float offsetZ)
        {
            Vector3 tempPos = transform.position;
            tempPos.z += offsetZ;
            transform.position = tempPos;
        }

        #endregion
        
        #region Set Local Position X-Y-Z

        public static void SetLocalPositionX(this Transform transform, float xPos)
        {
            Vector3 tempPos = transform.localPosition;
            tempPos.x = xPos;
            transform.localPosition = tempPos;
        }
        
        public static void SetLocalPositionY(this Transform transform, float yPos)
        {
            Vector3 tempPos = transform.localPosition;
            tempPos.y = yPos;
            transform.localPosition = tempPos;
        }
        
        public static void SetLocalPositionZ(this Transform transform, float zPos)
        {
            Vector3 tempPos = transform.localPosition;
            tempPos.z = zPos;
            transform.localPosition = tempPos;
        }

        #endregion
        
        #region Shift Local Position X-Y-Z
        
        public static void ShiftLocalPositionX(this Transform transform, float offsetX)
        {
            Vector3 tempPos = transform.localPosition;
            tempPos.x += offsetX;
            transform.localPosition = tempPos;
        }
        
        public static void ShiftLocalPositionY(this Transform transform, float offsetY)
        {
            Vector3 tempPos = transform.localPosition;
            tempPos.y += offsetY;
            transform.localPosition = tempPos;
        }
        
        public static void ShiftLocalPositionZ(this Transform transform, float offsetZ)
        {
            Vector3 tempPos = transform.localPosition;
            tempPos.z += offsetZ;
            transform.localPosition = tempPos;
        }

        #endregion
        
        #region Set World Rotation X-Y-Z
        
        public static void SetRotationX(this Transform transform, float xRot)
        {
            Vector3 tempRot = transform.eulerAngles;
            tempRot.x = xRot;
            transform.rotation = Quaternion.Euler(tempRot);
        }
        
        public static void SetRotationY(this Transform transform, float yRot)
        {
            Vector3 tempRot = transform.eulerAngles;
            tempRot.y = yRot;
            transform.rotation = Quaternion.Euler(tempRot);
        }
        
        public static void SetRotationZ(this Transform transform, float zRot)
        {
            Vector3 tempRot = transform.eulerAngles;
            tempRot.z = zRot;
            transform.rotation = Quaternion.Euler(tempRot);
        }

        #endregion

        #region Set Local Rotation X-Y-Z
        
        public static void SetLocalRotationX(this Transform transform, float xRot)
        {
            Vector3 tempRot = transform.localRotation.eulerAngles;
            tempRot.x = xRot;
            transform.localRotation = Quaternion.Euler(tempRot);
        }
        
        public static void SetLocalRotationY(this Transform transform, float yRot)
        {
            Vector3 tempRot = transform.localRotation.eulerAngles;
            tempRot.y = yRot;
            transform.localRotation = Quaternion.Euler(tempRot);
        }
        
        public static void SetLocalRotationZ(this Transform transform, float zRot)
        {
            Vector3 tempRot = transform.localRotation.eulerAngles;
            tempRot.z = zRot;
            transform.localRotation = Quaternion.Euler(tempRot);
        }
        
        #endregion
        
        #region Set Local Scale X-Y-Z

        public static void SetLocalScaleX(this Transform transform, float xScale)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x = xScale;
            transform.localScale = tempScale;
        }
        
        public static void SetLocalScaleY(this Transform transform, float yScale)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.y = yScale;
            transform.localScale = tempScale;
        }
        
        public static void SetLocalScaleZ(this Transform transform, float zScale)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.z = zScale;
            transform.localScale = tempScale;
        }

        #endregion

    }
}
