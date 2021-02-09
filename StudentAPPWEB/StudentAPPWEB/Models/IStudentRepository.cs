using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPPWEB.Models
{
    public interface IStudentRepository
    {
        Student Get(int id);
    }
        
}
