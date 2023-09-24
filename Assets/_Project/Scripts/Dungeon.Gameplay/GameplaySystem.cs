using Dungeon.Gameplay.Characters;
using UnityEngine;

namespace Dungeon.Gameplay
{
    public sealed class GameplaySystem : Leaosoft.System
    {
        [SerializeField]
        private CharactersManager _charactersManager;

        protected override void OnInitialize()
        {
            base.OnInitialize();
            
            _charactersManager.Initialize();
        }

        protected override void OnDispose()
        {
            base.OnDispose();
            
            _charactersManager.Dispose();
        }

        protected override void OnTick(float deltaTime)
        {
            base.OnTick(deltaTime);
            
            _charactersManager.Tick(deltaTime);
        }

        protected override void OnFixedTick(float fixedDeltaTime)
        {
            base.OnFixedTick(fixedDeltaTime);
            
            _charactersManager.FixedTick(fixedDeltaTime);
        }
    }
}
