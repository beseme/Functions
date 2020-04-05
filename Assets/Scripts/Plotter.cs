using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Plotter : MonoBehaviour {
    private LineRenderer _renderer;
    [SerializeField] private int steps = 16;

    private void Awake() {
        _renderer = GetComponent<LineRenderer>();
    }

    private void Build(Function function) {
        _renderer.positionCount = steps;
        _renderer.SetPositions(Generate(function, steps).ToArray());
    }

    [ContextMenu("Load Test")]
    void LoadTest() {
        Build(x => x * x);
    }

    static List<Vector3> Generate(Function function, int steps) {
        List<Vector3> positions = new List<Vector3>();
        for (int i = -steps / 2; i < steps / 2; i++) {
            float x = (float) i / steps;
            float y = function.Invoke(x);

            y = Mathf.Clamp(y, -1f, 1f);

            positions.Add(new Vector2(x, y));
        }

        return positions;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.gray;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(2f, 2f, 0f));
    }
}