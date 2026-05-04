using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Palindromo : ControllerBase
    {

        [HttpGet]
        public bool VerificaPalindromo(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            input = input.Trim().Replace(" ", "").ToLower();
            int indices = input.Length - 1;
            for(int i=0; i < input.Length / 2; i++)
            {
                if(input[i] != input[indices - i])
                {
                    return false;
                }
            }
            return true;
        }
            
    }
}
