using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UsersApp.Model;

namespace UsersApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext applicationDbContext;

        public IndexModel(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IList<User> Users;
        public void OnGet()
        {
            Users =applicationDbContext.Users.ToList();
        }
    }
}
