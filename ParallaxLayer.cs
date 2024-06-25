using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

/// <summary>
/// Texture Settings:
/// Type - Sprite;
/// Wrap Mode - Repeat;
/// Filter Mode - Bilinear;
/// </summary>
public class ParallaxLayer : MonoBehaviour
{
    private RawImage _img;
    private float _offset;
    private float _position;

    public bool IsStop = false;

    /// <summary>
    /// Смещение в FixedUpdate
    /// </summary>
    public float Offset
    {
        get => _offset;
        set => _offset = value;
    }

    private void Start()
    {
        _img = GetComponent<RawImage>();
        if (_img == null)
            Debug.LogError("--> ParallaxLayer.Start: Img Is NULL");
    }

    public void FixedUpdate() 
    {
        if (IsStop)
            return;

        _position += _offset;

        if(_position > 1f)
            _position -= 1f;

        _img.uvRect = new Rect(_position, 0, 1, 1);
    }
}
