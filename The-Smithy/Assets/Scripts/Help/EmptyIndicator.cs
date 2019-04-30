using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyIndicator : MonoBehaviour {

    public float size = 0.01f;

    private void OnDrawGizmos() {
        Gizmos.color = Color.white;
        Gizmos.DrawCube(transform.position + (Vector3.up * size * 0.5f), new Vector3(size, size, size));
    }
}
