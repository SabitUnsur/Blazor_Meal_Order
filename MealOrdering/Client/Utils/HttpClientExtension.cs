using MealOrdering.Shared.CustomExceptions;
using MealOrdering.Shared.ResponseModels;
using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
=======
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mail;
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
using System.Threading.Tasks;

namespace MealOrdering.Client.Utils
{
    public static class HttpClientExtension
    {
        public async static Task<TResult> PostGetServiceResponseAsync<TResult, TValue>(this HttpClient Client, String Url, TValue Value, bool ThrowSuccessException = false)
        {
            var httpRes = await Client.PostAsJsonAsync(Url, Value);

            if (httpRes.IsSuccessStatusCode)
            {
                var res = await httpRes.Content.ReadFromJsonAsync<ServiceResponse<TResult>>();

                return !res.Success && ThrowSuccessException ? throw new ApiException(res.Message) : res.Value;
            }

            throw new HttpException(httpRes.StatusCode.ToString());
        }

        public async static Task<BaseResponse> PostGetBaseResponseAsync<TValue>(this HttpClient Client, String Url, TValue Value, bool ThrowSuccessException = false)
        {
            var httpRes = await Client.PostAsJsonAsync(Url, Value);

            if (httpRes.IsSuccessStatusCode)
            {
                var res = await httpRes.Content.ReadFromJsonAsync<BaseResponse>();

                return !res.Success && ThrowSuccessException ? throw new ApiException(res.Message) : res;
            }

            throw new HttpException(httpRes.StatusCode.ToString());
        }


        public async static Task<T> GetServiceResponseAsync<T>(this HttpClient Client, String Url, bool ThrowSuccessException = false)
        {
            var httpRes = await Client.GetFromJsonAsync<ServiceResponse<T>>(Url);

            return !httpRes.Success && ThrowSuccessException ? throw new ApiException(httpRes.Message) : httpRes.Value;
        }
    }
}
<<<<<<< HEAD
=======

>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
