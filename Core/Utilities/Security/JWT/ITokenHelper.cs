using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        /* Örneğin email ve şifre girdik ve API'ye gönderdik. Eğer doğruysa ilgili kullanıcı için
        DB' ye gidecek ve o kullanıcının OperationClaim'larını bulacak orada bir JWT oluşturacak ve
        onları clienta gönderecek. */
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
