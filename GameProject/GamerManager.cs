using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;
        
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer is added.");
            }
            else
            {
                Console.WriteLine("Gamer can not be validated.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated.");
        }
    }
}
