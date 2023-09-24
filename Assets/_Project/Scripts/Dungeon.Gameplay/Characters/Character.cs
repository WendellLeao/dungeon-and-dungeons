using Leaosoft;
using UnityEngine;

namespace Dungeon.Gameplay.Characters
{
    public sealed class Character : Entity
    {
        [SerializeField] 
        private CharacterMovement _characterMovement;

        protected override void OnBegin()
        {
            base.OnBegin();
            
            _characterMovement.Begin();
        }

        protected override void OnStop()
        {
            base.OnStop();
            
            _characterMovement.Stop();
        }

        protected override void OnTick(float deltaTime)
        {
            base.OnTick(deltaTime);
            
            _characterMovement.Tick(deltaTime);
        }

        protected override void OnFixedTick(float fixedDeltaTime)
        {
            base.OnFixedTick(fixedDeltaTime);
            
            _characterMovement.FixedTick(fixedDeltaTime);
        }
    }
}
