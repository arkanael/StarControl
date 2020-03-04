using starcontrol.Entities;
using StarControl.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarControl.Business
{
    public class ClienteBusiness
    {
        private readonly ClienteRepository repository;

        public ClienteBusiness()
        {
            repository = new ClienteRepository();
        }

        public void Cadastrar(Cliente cliente)
        {
            if (repository.HasEmail(cliente.Email))
            {
                throw new Exception($"O email {cliente.Email} já encontra-se cadastrado no sistema, tente outro.");
            }
            else
            {
                repository.Insert(cliente);
            }
        }

        public void Atualizar(Cliente cliente)
        {
            repository.Update(cliente);
        }

        public void Excluir(int id)
        {
            repository.Delete(id);
        }

        public void Obter()
        {
            repository.Find();
        }

        public void Obter(int id)
        {
            repository.Find(id);
        }
    }
}
