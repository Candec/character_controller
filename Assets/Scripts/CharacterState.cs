using Animancer.FSM;
using UnityEngine;

public abstract class CharacterState : StateBehaviour
{
    [SerializeField] private Character character;
    public Character Character { get => character; }
}
