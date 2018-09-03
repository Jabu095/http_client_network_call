http_client_network_call - a simple object mapper for .NetCore 2.0

Example usage:

```csharp
Get request

Students[] students = new NetWorkCall<Students[]>().GET("http://example.com?id=2");

Post request

StudentRequestViewModel model = new StudentRequestViewModel { name = "jabu" };
Students[] students = new NetWorkCall<Students[]>().POST("http://example.com",JsonConvert.SerializeObject(model));


Put request

StudentRequestViewModel model = new StudentRequestViewModel {id = 1, name = "jabu" };
Students[] students = new NetWorkCall<Students[]>().PUT("http://example.com",JsonConvert.SerializeObject(model));


Delete request

Students[] students = new NetWorkCall<Students[]>().PUT("http://example.com?id=4");
