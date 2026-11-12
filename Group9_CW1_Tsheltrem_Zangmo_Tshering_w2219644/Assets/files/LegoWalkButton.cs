
using UnityEngine;

public class LegoWalkButton : MonoBehaviour
{
    public Animator legoAnimator;

    public void StartWalking()
    {
        legoAnimator.SetTrigger("StartWalk");
    }
}

