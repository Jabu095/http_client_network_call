using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NetworkCalls
{
    public class NetWorkCall<T>
    {
        /// <summary>
        /// Gets the list of objects.
        /// </summary>
        /// <param name="urlParam">The URL parameter.</param>
        /// <returns></returns>
        public T GET(string urlParam)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(urlParam).Result;
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(responseBody);
                    }
                    throw new ResponseErrorData(responseBody,response.StatusCode);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Posts the specified object.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="jsonData">The json data.</param>
        /// <returns></returns>
        public T POST(string url, string jsonData)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.PostAsync(url, new StringContent(jsonData, Encoding.UTF8, "application/json")).Result;
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(responseBody);
                    }
                    throw new ResponseErrorData(responseBody, response.StatusCode);
                }
            }catch(Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Updating
        /// </summary>
        /// <param name="url">the url</param>
        /// <param name="jsonData">string jsonData</param>
        /// <returns></returns>
        public T PUT(string url, string jsonData)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.PutAsync(url, new StringContent(jsonData, Encoding.UTF8, "application/json")).Result;
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(responseBody);
                    }
                    throw new ResponseErrorData(responseBody, response.StatusCode);
                }
            }catch(Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Delete rest call
        /// </summary>
        /// <param name="url">url</param>
        /// <returns></returns>
        public T DELETE(string urlParams)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    //client.Timeout = TimeSpan.FromSeconds(35);
                    var response = client.DeleteAsync(urlParams).Result;
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(responseBody);
                    }
                    throw new ResponseErrorData(responseBody, response.StatusCode);
                }
            }catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
