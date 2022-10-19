# Echo

A simple .NET 6 Web API used for testing communications between servers.

## Endpoints
The endpoints will return the following information:

GET /self
1. IP address of the caller
2. DNS name of the server

GET /ping?url=https://www.google.com/
1. IP address of the caller
2. Content on the URL

GET /pingbase?url=BASE64-ENCODED-URL
1. IP address of the caller
2. Content on the URL

## Use Case

Find the host names and IP addresses of the servers can clients. This is useful to understand if a public or private IP address is used for API to API communication.

For example:

Website 1 (Hosted on Azure App Service)
https://website1.azurewebsites.net

Website 2 (Hosted on Azure App Service)
https://website2.azurewebsites.net

Use Website 1 to call Website 2 and discover the IP address and DNS name used:
GET https://website1.azurewebsites.net/ping?url=https://website2.azurewebsites.net/self

