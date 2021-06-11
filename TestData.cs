using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Test
{
    public static class TestData
    {
        public static readonly object User = new
        {
            randomFirstName = "randomFirstName",
            randomLastName = "",
            password = "12345678",
            phone = "+90000002111",
            email = "email@ddd.com"
        };
    }
}
