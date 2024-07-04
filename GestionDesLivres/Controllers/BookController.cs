using GestionDesLivres.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionDesLivres.Controllers
{
    public class BookController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly GestionDesLivreDbContext _dbContext;
        private List<Livre> lstLivre = null;
        public BookController(HttpClient httpClient, GestionDesLivreDbContext dbContext)
        {
            _httpClient = httpClient;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> ListeBookAsync()
        {
            try
            {
                var getApiResult = await getAllBook();
                if (getApiResult != null)
                {
                    lstLivre = new List<Livre>();
                    Doc[] livres = getApiResult.Docs;
                    int i = 1;
                    foreach (var obj in livres)
                    {
                       
                        Livre lv = new Livre();
                        lv.Id = i;
                        lv.title = obj.Title.ToString();
                        lv.author_key = obj.AuthorKey?[0].ToString();
                        lv.author_name =  obj.AuthorName?[0].ToString();
                        lv.first_publish_year  = obj.FirstPublishYear?.ToString();
                        lv.publisher = obj.Publisher?[0].ToString();
                        lv.contributor = obj.Contributor?[0].ToString();
                        i++;
                        lstLivre.Add(lv);
                    }

                    // Livre[] lstLivre = listLivre != null ? new Livre[] { (Livre)listLivre } : null;
                    return View(lstLivre);
                }
                
                return View();
            }
            catch (Exception e)
            {
                return new JsonResult(e);

                throw;
            }
        }
        // Ajouter un livre à la base de données
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] Livre livre)
        {

            try
            {
                if (livre == null)
                {
                    return BadRequest("Invalid data received");
                }
                //Livre lvr = new Livre();
                //lvr.author_key =livre.author_key;
                //lvr.title =livre.title;
                //lvr.author_name =livre.author_name;
                //lvr.first_publish_year =livre.first_publish_year;
                //lvr.publisher =livre.publisher;
                //lvr.contributor =livre.contributor;
                _dbContext.Add(livre);
                await _dbContext.SaveChangesAsync();
                //lvr = lstLivre?.Find(x => x.Id == livre.Id);
                // Exemple de traitement avec les données reçues
                var result = new
                {
                    Message = $"Données récues: Id={livre.Id}, Name={livre}",
                    Success = true
                };

                // Retourner une réponse JSON
                return Json(result);
            }
            catch (Exception ex)
            {

                var result = new
                {

                    //Message = $"Data received: Id={data.title}, Name={data.author_name}",
                    Message = $"Data received: Id={ex.InnerException?.Message}, Name={ex.Message}",
                    Success = true
                };
                return Json(result);
            }
            // await _dbContext.SaveChangesAsync();

            //return Json(new { success = true, livre });

            
        }
        public async Task<BookListe> getAllBook()
        {
            var _htttpResponseMsg = new HttpRequestMessage();
            BookListe? returnValue = null; 
            try
            {
                //Url du post
                var Url = "https://openlibrary.org/search.json?q=the+lord+of+the+rings";
                // Envoyer la requêtte HTT Get
                HttpResponseMessage res = await _httpClient.GetAsync(Url);

                // Je vérifie si la requête est reusiie
                if (res.IsSuccessStatusCode)
                {
                    string resBody = await res.Content.ReadAsStringAsync();

                    BookListe data = JsonConvert.DeserializeObject<BookListe>(resBody);
                    // JObject data = JObject.Parse(resBody);
                    // returnValue =  new BookListe();

                    return  data;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erreur de requête HTTP: {e.Message}");
                // Ajoutez ici des actions spécifiques à effectuer en cas d'erreur de requête HTTP
            }
            catch (JsonException e)
            {
                Console.WriteLine($"Erreur de désérialisation JSON: {e.Message}");
                // Ajoutez ici des actions spécifiques à effectuer en cas d'erreur de désérialisation JSON
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur: {e.Message}");
                // Ajoutez ici des actions spécifiques à effectuer en cas d'autres types d'erreurs
            }
            return null;
        }
    }
}
