using Microsoft.AspNetCore.Mvc;

namespace Expert.WebAPI.uvod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrviController : ControllerBase
    {
        public PrviController()  //Konstruktor
        {

        }
        [HttpGet("prvi")]
        public async Task<ActionResult<string>> Ping()
        {
            return "pong";
        }
        [HttpGet("drugi")]
        public async Task<ActionResult<string>> Pong()
        {
            return "ping";
        }
        [HttpGet("zbroji/prviBroj/{prviBroj}/drugiBroj/{drugiBroj}")]
        public async Task<ActionResult<int>> Zbroj(int prviBroj, int drugiBroj)
        {
            return prviBroj + drugiBroj;
        }

        [HttpGet("zbroji1/prviBroj/{prviBroj}/drugiBroj/{drugiBroj}")]
        public async Task<ActionResult<string>> Zbroj1(int prviBroj, int? drugiBroj)
        {
            if (drugiBroj == null)
            {
                return "Niste unjeli drugi broj!";
            }else
            return (prviBroj + drugiBroj).ToString();
        }
        [HttpGet("zbrojiStringove/prvi/{prvi}/drugi/{drugi}/tipConcat/{tipConcat}")]
        public async Task<ActionResult<string>> ZbrojiString(string prvi, string drugi, int tipConcat)
        {
            //0 - klasično zbrajanje stringova
            //1 - upotrijebi concat
            //2- upotrijebi interpolacija
            if (tipConcat == 0)
            {
                return prvi + " " + drugi;
            }   
            else if (tipConcat == 1)
            {
                return string.Concat(prvi, " ", drugi);
            }
            else if(tipConcat == 2)
            {
                return $"Prvi poslani string je: {prvi}, a drugi poslani string je: {drugi}";
            }
            else
            return "Niste odabrali ispravan tip! Možete birati 0,1,2!";
        }

        
    }
}
