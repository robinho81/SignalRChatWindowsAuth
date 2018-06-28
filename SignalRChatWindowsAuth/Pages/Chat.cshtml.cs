using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SignalRChatWindowsAuth.Pages
{
  public class ChatModel : PageModel
  {
    public string Username { get; set; }

    public void OnGet()
    {
      Username = HttpContext.User.Identity.Name;
    }
  }
}