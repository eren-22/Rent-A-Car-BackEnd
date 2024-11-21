using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        // Bir hashing işlemi yapacağız.
        // Anahtar ve şifreeme olarak kullanacağımız parametreleri veririz.
        /* HashingHelper' da biz kendimiz bir şeyleri hashlerken ve doğrularken orda ne kullanması
        gerektiğini belirttik. API'ye de belirtmek için kullanıyoruz. */
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
