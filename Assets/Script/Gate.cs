using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate
{
    // Include buffer?
    public enum GateType { AND, CLOCK, DISPLAY, OR, LEVER, NOT, SPLIT, XOR }

    public GateType type;

    public bool[] input, output;

    private bool activationCondition;

    public Gate(GateType type)
    {
        this.type = type;

        switch(type)
        {
            case GateType.AND:

            case GateType.DISPLAY:

            case GateType.OR:
        }
    }
}