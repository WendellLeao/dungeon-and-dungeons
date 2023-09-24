using Leaosoft;
using UnityEngine;

namespace Dungeon.Gameplay.Characters
{
    public sealed class CharactersManager : Manager
    {
        [SerializeField] 
        private Character _characterPrefab;

        private Character _currentCharacter;
        
        protected override void OnInitialize()
        {
            base.OnInitialize();

            _currentCharacter = Instantiate(_characterPrefab, Vector3.zero, Quaternion.identity);
        }

        protected override void OnDispose()
        {
            base.OnDispose();
            
            _currentCharacter.Stop();
        }

        protected override void OnTick(float deltaTime)
        {
            base.OnTick(deltaTime);
            
            _currentCharacter.Tick(deltaTime);
        }

        protected override void OnFixedTick(float fixedDeltaTime)
        {
            base.OnFixedTick(fixedDeltaTime);
            
            _currentCharacter.FixedTick(fixedDeltaTime);
        }
    }
}
