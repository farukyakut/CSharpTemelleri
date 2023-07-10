using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun6Odev4
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt başarısız");
            }
            
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("oyuncu Güncellendi");
        }
    }
}
