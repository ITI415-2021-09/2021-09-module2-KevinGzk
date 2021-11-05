using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum State
{
    drawpile,
    tableau,
    target,
    discard

    
}

public class CardClock : Card
{
    [Header("Set Dynamically: ClockCard")]
    public State state = State.drawpile;
    public int layoutID;
    public SlotDef slotDef;
    
    override public void OnMouseUpAsButton()
    {
        base.OnMouseUpAsButton();
    }
}
