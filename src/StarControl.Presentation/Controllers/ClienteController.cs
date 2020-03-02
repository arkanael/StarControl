using AutoMapper;
using starcontrol.Entities;
using StarControl.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarControl.Presentation.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastro()
        {
            return View();
        }

        public JsonResult CadastrarCliente(ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return Json("OK");
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
                return Json("erro");

            }
        }
    }
}