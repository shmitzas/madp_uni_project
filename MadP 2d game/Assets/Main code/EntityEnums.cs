using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace RushNDestroy
{
    public class EntityEnums : MonoBehaviour
    {
        [HideInInspector] public Faction faction;
        [HideInInspector] public TargetType targetType;
        public Type entityType;
        [HideInInspector] public ExtraType extraType;

        public UnityAction<EntityEnums> OnDie;

        public enum Type
        {
            Unit,
            Structure,
            Castle
        }

        public enum TargetType
        {
            OnlyBuildings,
            All,
            Ground,
            None
        }

        public enum ExtraType{
            None,
            Airborne
        }

        public enum Faction
        {
            Player,
            Enemy
        }
    }
}
