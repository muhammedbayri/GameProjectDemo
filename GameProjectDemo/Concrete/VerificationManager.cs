using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool Verify(Gamer gamer)
        {
            if (gamer.NationalIdentity.Length!=11)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
