using _Project.Develop.Runtime.Entities;
using _Project.Develop.Runtime.Utilities;
using _Project.Develop.Runtime.Utils.ReactiveManagement;

namespace _Project.Develop.Runtime.Logic.Gameplay.Features.Sensors.Systems
{
    public class AnotherTeamTouchDetectorSystem : IInitializableSystem, IUpdatableSystem
    {
        private Buffer<Entity> _contacts;
        private ReactiveVariable<bool> _isTouchAnotherTeam;
        private ReactiveVariable<Teams.Teams> _sourceTeam;

        public void OnInit(Entity entity)
        {
            _contacts = entity.ContactEntitiesBuffer;
            _isTouchAnotherTeam = entity.IsTouchAnotherTeam;
            _sourceTeam = entity.Team;
        }

        public void OnUpdate(float deltaTime)
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                Entity contact = _contacts.Items[i];

                if (contact.TryGetTeam(out ReactiveVariable<Teams.Teams> anotherTeam))
                {
                    if (_sourceTeam.Value != anotherTeam.Value)
                    {
                        _isTouchAnotherTeam.Value = true;
                        return;
                    }
                }
            }

            _isTouchAnotherTeam.Value = false;
        }
    }
}