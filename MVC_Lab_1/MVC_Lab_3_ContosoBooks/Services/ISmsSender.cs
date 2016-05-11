using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab_3_ContosoBooks.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
