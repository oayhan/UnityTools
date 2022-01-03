using UnityEngine;

namespace OTools.Extensions
{
    public static class VectorExtensions
    {
        #region Vector2 to Vector3
        
        public static Vector3 GetVector3WithX(this Vector2 v, float x)
        {
            return new Vector3(x, v.x, v.y);
        }
        
        public static Vector3 GetVector3WithY(this Vector2 v, float y)
        {
            return new Vector3(v.x, y, v.y);
        }
        
        public static Vector3 GetVector3WithZ(this Vector2 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        #endregion

        #region Vector3 Modifiers
        
        public static Vector3 WithX(this Vector3 v, float x)
        {
            return new Vector3(x, v.y, v.z);
        }
        
        public static Vector3 WithY(this Vector3 v, float y)
        {
            return new Vector3(v.x, y, v.z);
        }
        
        public static Vector3 WithZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        #endregion
        
        #region Closest Point on Line
        
        public static Vector3 ClosestPointOnFiniteLine(this Vector3 originPoint, Vector3 lineStart, Vector3 lineEnd)
        {
            Vector3 line = lineEnd - lineStart;
            float lineLength = line.magnitude;
            Vector3 normalizedLine = line.normalized;

            Vector3 vectorFromOriginToStart = originPoint - lineStart;
            float projection = Vector3.Dot(vectorFromOriginToStart, normalizedLine);
            float distanceOnLine = Mathf.Clamp(projection, 0, lineLength);
            
            return lineStart + distanceOnLine * normalizedLine;
        }
        
        public static Vector3 ClosestPointOnInfiniteLine(this Vector3 originPoint, Vector3 pointOnLine, Vector3 lineDirection)
        {
            Vector3 normalizedLineDir = lineDirection.normalized;
            Vector3 vectorFromPointToOrigin = originPoint - pointOnLine;

            float projection = Vector3.Dot(vectorFromPointToOrigin, normalizedLineDir);
            
            return pointOnLine + projection * normalizedLineDir;
        }

        #endregion
    }
}