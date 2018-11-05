using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Base
{
    public class BaseController: Controller
    {
        protected DataContext _context;
    }
}
