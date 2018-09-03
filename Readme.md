http_client_network_call - a simple object mapper for .NetCore 2.0

Example usage:

```csharp
Get request

Student[] students = new NetWorkCall<Students[]>().GET("http://example.com/api/getstudent?id=2");

Post request

StudentRequestViewModel model = new StudentRequestViewModel { name = "jabu" };
Student students = new NetWorkCall<Student>().POST("http://example.com/api/addstudent",model);


Put request

StudentRequestViewModel model = new StudentRequestViewModel {id = 1, name = "jabu" };
Student students = new NetWorkCall<Student>().PUT("http://example.com/api/updatestudent",model);


Delete request

bool students = new NetWorkCall<bool>().PUT("http://example.com/api/removestudent?id=4");
