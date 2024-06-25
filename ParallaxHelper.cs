using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxHelper : MonoBehaviour
{
    [SerializeField] private ParallaxLayer[] _layersImg;
    [SerializeField] private float[] _offsetStep;

    private void Start()
    {
        if (_layersImg.Length != _offsetStep.Length)
            Debug.LogError("--> ParallaxHelper.Start: _layersImg.Length != _offsetStep.Length");

        for(int i = 0; i < _layersImg.Length; i++)
        {
            _layersImg[i].Offset = _offsetStep[i] / 10000f;
        }
    }

    public void SetSpeed(float speed)
    {
        for (int i = 0; i < _layersImg.Length; i++)
        {
            _layersImg[i].Offset *= speed;
        }
    }

}
