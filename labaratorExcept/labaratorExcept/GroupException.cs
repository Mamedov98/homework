using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{

    public class GroupException : ApplicationException
    {

    }

    class StudentException : GroupException
    {

    }

    class TeacherException : GroupException
    {

    }
}
