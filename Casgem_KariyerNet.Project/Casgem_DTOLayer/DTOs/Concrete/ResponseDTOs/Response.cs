﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DTOLayer.DTOs.Concrete.ResponseDTOs
{
    public class Response<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccessful { get; set; }
        public List<string> Errors { get; set; }

        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { StatusCode = statusCode, Data = default(T), IsSuccessful = true };
        }

        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T> { IsSuccessful = false, Errors = errors, StatusCode = statusCode };
        }

        public static Response<T> Fail(string errorMessage, int statusCode)
        {
            return new Response<T> { IsSuccessful = false, Errors = new List<string> { errorMessage }, StatusCode = statusCode };
        }
    }
}