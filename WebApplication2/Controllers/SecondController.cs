﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class SecondController : Controller
    {
        public string Index()
        {
            return "Funky skunky";
        }
    }
}