using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Raimunda Manuela Lorena Almada", "059.044.473-53", "raimunda.manuela.almada@jci.com", "Iguana");
        Cliente cliente2 = new Cliente(02, "Rosângela Tatiane Gomes", "598.382.922-06", "rosangela_tatiane_gomes@cartovale.com.br", "Cachorro");
        Cliente cliente3 = new Cliente(03, "Severino Daniel Drumond", "273.949.878-09", "severino-drumond72@ambiente.sp.gov.br", "Girafa");
        Cliente cliente4 = new Cliente(04, "Isabel Stefany Gomes", "343.628.106-92", "isabel-gomes72@budsoncorporation.com", "Gato");
        Cliente cliente5 = new Cliente(05, "Pedro Breno da Paz", "726.572.979-00", "pedro-dapaz91@lencise.com", "Papagio");


        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedor1 = new Fornecedor(01, "ACME Corporation", "12.345.678/0001-90", "acme@exemplo.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Globex Corporation", "98.765.432/0001-21", "globex@exemplo.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Initech", "11.223.334/0001-54", "initech@exemplo.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Wayne Enterprises", "99.888.777/0001-33", "wayne@exemplo.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Stark Industries", "66.777.888/0001-22", "stark@exemplo.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
