using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApp.Shared.Responses
{
    public class ApiResponse
    {
        public string Message { get; set; }
        public bool IsSucess { get; set; }

    }

    public class ApiResponse<T> : ApiResponse
    {
        public T Value { get; set; }
    }
}

public class ApiErrorResponse
{
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
    public string[] Errors { get; set; }
    public Userinfo UserInfo { get; set; }
    public DateTime ExpireDate { get; set; }
}

public class Userinfo
{
    public string AdditionalProp1 { get; set; }
    public string AdditionalProp2 { get; set; }
    public string AdditionalProp3 { get; set; }
}
