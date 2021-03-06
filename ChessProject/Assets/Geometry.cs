using UnityEngine;

public class Geometry
{
    static public Vector3 PointFromGrid(Vector2Int gridPoint)
    {
        float x = -3f + -2f * gridPoint.x;
        float z = 2f + -2f * gridPoint.y;
        return new Vector3(x, 0, z);
    }

    static public Vector2Int GridPoint(int col, int row)
    {
        return new Vector2Int(col, row);
    }

    static public Vector2Int GridFromPoint(Vector3 point)
    {
        int col = Mathf.FloorToInt(4f + point.x);
        int row = Mathf.FloorToInt(4f + point.z);
        return new Vector2Int(col, row);
    }
}
