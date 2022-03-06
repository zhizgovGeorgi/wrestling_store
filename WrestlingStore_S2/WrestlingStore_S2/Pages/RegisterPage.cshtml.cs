using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using LogicLayer.Models;

namespace MyWebStore.Pages
{
    public class RegisterPageModel : PageModel
    {
        
        public Register register { get; set; }

        public void OnGet()
        {
           
        }
       

        
    }
}
