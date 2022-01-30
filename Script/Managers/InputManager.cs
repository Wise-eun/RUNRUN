using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoSingleton<InputManager>

{
    protected bool _isJump = false;
    protected bool _isSlide= false;
    protected bool _isFirst = false;
    protected bool _isSecond = false;

    protected bool _isVibration = true;

    public int jumpCount = 0;

    public bool IsJump()
    {
        return _isJump;
    }

    public bool IsSlide()
    {
        return _isSlide;
    }

    public bool IsFirst()
    {

        if (_isFirst)
        {
            _isFirst = false;
            return true;
        }
        return false;

    }

    public bool IsSecond()
    {

        if (_isSecond)
        {
            _isSecond = false;

            return true;
        }
        return false;

    }
    public void StartSlide()
    {
        _isSlide = true;
    }
    public void StartJump()
    {
        EffectMusic.instance.PlayMusic(); //점프할때 소리남
        jumpCount++;
        _isJump = true;


        if (jumpCount == 1)
        {
            _isFirst = true;
            _isSecond = false;
        }


        if (jumpCount == 2)
        {
            _isSecond = true;
            _isFirst = false;


        }
        else
        {
            return;
        }
    }




    public void ClearJumpFlag()
    {

        if (!_isJump)
        {

            return;

        }

        jumpCount = 0;
        _isJump = false;
    }

    public void ClearSlideFlag()
    {

        if (!_isSlide)
        {

            return;

        }


        _isSlide = false;
    }

    public void OnVibrate()
    {
        _isVibration = true;
    }

    public void OffVibrate()
    {
        _isVibration = false;
    }

    public bool IsVibrate()
    {
        return _isVibration;
    }


}
