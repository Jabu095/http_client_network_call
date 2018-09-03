http_client_network_call - a simple object mapper for .NetCore 2.0

Example usage:

```csharp
Get request

Student[] students = new NetWorkCall<Students[]>().GET("http://example.com/api/getstudent?id=2");

Post request

StudentRequestViewModel model = new StudentRequestViewModel { name = "jabu" };
Students students = new NetWorkCall<Students[]>().POST("http://example.com/api/addstudent",JsonConvert.SerializeObject(model));


Put request

StudentRequestViewModel model = new StudentRequestViewModel {id = 1, name = "jabu" };
Students students = new NetWorkCall<Students[]>().PUT("http://example.com/api/updatestudent",JsonConvert.SerializeObject(model));


Delete request

bool students = new NetWorkCall<bool>().PUT("http://example.com/api/removestudent?id=4");
