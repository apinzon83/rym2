//using Newtonsoft.Json;
using rym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Text.Json;

namespace rym.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(string id)
        {
            string _url = "https://rickandmortyapi.com/api/character";
            if (id!=null) { _url += "?page=" + id;}

            HttpClient httpclient = new HttpClient();
            var json = await httpclient.GetStringAsync(_url);
            Console.WriteLine("obtengo "+json.Length+" personajes");
            try
            {
                var personajes = JsonSerializer.Deserialize<c_resultado>(json);
                var nomPagNext = personajes.info.next;
                int pagAct = 0;
                var idPS = nomPagNext.Split('=')[1];
                int.TryParse(idPS, out pagAct);
                pagAct--;
                ViewBag.pagAct = pagAct;
                ViewBag.pagAnt = pagAct-1;
                ViewBag.pagSig = pagAct+1;
                return View(personajes);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            return View("");
        }

        public async Task<ActionResult> consulta_personaje(int id, int pagAct)
        {
            HttpClient httpclient = new HttpClient();
            var json = await httpclient.GetStringAsync("https://rickandmortyapi.com/api/character/"+id.ToString());
            Console.WriteLine("obtengo los detalles del personaje "+id);
            try
            {
                ViewBag.pagAct = pagAct;
                var personaje = JsonSerializer.Deserialize<c_results>(json);
                return View(personaje);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            return View("");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}