using AutoMapper;
using starcontrol.Entities;
using StarControl.Business;
using StarControl.Presentation.Models;
using StarControl.Presentation.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarControl.Presentation.Controllers
{
    public class ClienteController : Controller
    {

        private readonly ClienteBusiness business;

       
        public ClienteController()
        {
            business = new ClienteBusiness();
        }


        // GET: Cliente
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Cliente
        public ActionResult Consulta()
        {
            return View();
        }

        public JsonResult ConsultarClientes()
        {
            try
            {
                var clientes = business.Obter();

                var model = Mapper.Map<List<ClienteConsultaViewModel>>(clientes);

                Response.StatusCode = 200;

                return Json(model);

            }
            catch (Exception erro)
            {
                Response.StatusCode = 500;
                return Json(erro.Message);
            }
        }

        public JsonResult CadastrarCliente(ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cliente = Mapper.Map<Cliente>(model);

                    business.Cadastrar(cliente);

                    return Json($"Cliente {cliente.Nome} cadastrado com sucesso.");
                }
                catch (Exception erro)
                {
                    Response.StatusCode = 500;
                    return Json(erro.Message);
                }
            }
            else
            {
                Response.StatusCode = 400;
                return Json(ModelStateValidation.GetErrors(ModelState));

            }
        }
    }
}