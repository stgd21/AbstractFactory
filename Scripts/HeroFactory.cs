using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFactory : ICharacterFactory
{
    public ICharacter Create(Requirements requirements)
    {
        switch(requirements.range)
        {
            case 1:
            case 2:
            case 3:
                return new Tank(Color.white);
            default:
                return new Archer(Color.white);
        }
    }
}
