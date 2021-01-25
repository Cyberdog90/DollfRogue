﻿using UnityEngine;

public class TitleMenu_Start : MonoBehaviour {
    private Renderer _renderer;
    private Color _color;

    public Color Color {
        get => _color;
        set => _color = value;
    }

    void Start() {
        _renderer = GetComponent<SpriteRenderer>();
        _color = _renderer.material.color;
    }

    void Update() {
        _renderer.material.color = _color;
    }
}