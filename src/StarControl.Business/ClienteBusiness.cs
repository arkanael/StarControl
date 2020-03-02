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

        public ClienteBusiness(ClienteRepository repository)
        {
            this.repository = repository;
        }

        public void Cadastrar(Cliente cliente)
        {
            repository.Insert(cliente);
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
