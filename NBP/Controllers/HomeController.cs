using Microsoft.AspNetCore.Mvc;
using NBP.Models;
using NBP.Models.Exchange;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;

namespace NBP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("NBPClient");
        }


        [Route("CalculateAverageExchangeRate/{date}/{code}")]
        public IActionResult CalculateAverageExchangeRate(string date, string code)
        {
            //query to the server
            var response = _httpClient.GetAsync($"a/{code}/{date}/?format=json").Result;
            var contentJson = response.Content.ReadAsStringAsync().Result;
            var series = JsonConvert.DeserializeObject<ExchangeRateTable>(contentJson);


            return View(series);
        }


        [Route("MaxMinAverageExchangeRate/{code}/{count}")]
        public IActionResult MaxMinAverageExchangeRate(string code, int count)
        {
            //query to the server
            var response = _httpClient.GetAsync($"a/{code}/last/{count}/?format=json").Result;
            var contentJson = response.Content.ReadAsStringAsync().Result;
            var series = JsonConvert.DeserializeObject<ExchangeRateTable>(contentJson);

            // Sorted by Mid
            var seriesSorted = series.Rates.OrderBy(x => x.Mid);


            return View(seriesSorted);
        }

        [Route("BidAskRate/{code}/{count}")]
        public IActionResult BidAskRate(string code, int count)
        {
            //query to the server
            var response = _httpClient.GetAsync($"c/{code}/last/{count}/?format=json").Result;
            var contentJson = response.Content.ReadAsStringAsync().Result;
            var series = JsonConvert.DeserializeObject<ExchangeRateTable>(contentJson);

            //new list
            List<decimal> differenceList = new List<decimal>();

            // adding new differences to list
            foreach (var item in series.Rates)
            {
                differenceList.Add(item.Bid - item.Ask);
            }

            decimal average = differenceList.Average();

            // adding average to list
            differenceList.Add(average);


            return View(differenceList);
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}