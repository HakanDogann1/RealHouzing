using Microsoft.AspNetCore.Identity;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.Consume.Models
{
    public class RegisterErrorDescriber:IdentityErrorDescriber
    {

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError{
                Code= "PasswordRequiresLower",
                Description="Şifrenizde En az 1 karakter büyük olmalıdır."
            };
           
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifrenizde en az 1 karakter küçük olmalıdır."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifreniz en az 1 adet numerik değer içermelidir."
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = "Parolanız en az 6 karakter olmalıdır."
            };
        }
    }
}
