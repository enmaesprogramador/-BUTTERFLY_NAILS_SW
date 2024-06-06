using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUTTERFLYNAILSCENTERSw.DataAccess
{
    public static class UserSession
    {
        public static string? UserName {  get; set; }
        public static string? UserRol {  get; set; }
    }
}
