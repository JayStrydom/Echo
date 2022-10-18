# Echo

A simple .NET 6 Web API used for testing

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
