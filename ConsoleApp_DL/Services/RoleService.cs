using ConsoleApp_DL.Entities;
using ConsoleApp_DL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DL.Services
{
    internal class RoleService
    {
        private readonly RoleRepository _roleRepository;

        public RoleService(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }



        public RoleEntity CreateRole(string roleName)
        {
            var RoleEntity = _roleRepository.Get(x => x.RoleName == roleName);
            RoleEntity ??= _roleRepository.Create(new RoleEntity { RoleName = roleName });

            return RoleEntity;
        }

        public RoleEntity GetRoleByRoleName(string roleName)
        {
            var RoleEntity = _roleRepository.Get(x => x.RoleName == roleName);
            return RoleEntity;
        }

        public RoleEntity GetRoleById(int id)
        {
            var RoleEntity = _roleRepository.Get(x => x.Id == id);
            return RoleEntity;
        }

        public IEnumerable<RoleEntity> GetRoles()
        {
            var roles = _roleRepository.GetAll();
            return roles;
        }

        public RoleEntity UpdateRole(RoleEntity RoleEntity)
        {
            var updatedRoleEntity = _roleRepository.Update(x => x.Id == RoleEntity.Id, RoleEntity);
            return updatedRoleEntity;
        }

        public void DeleteRole(int id)
        {
            _roleRepository.Delete(x => x.Id == id);
        }
    }
}
