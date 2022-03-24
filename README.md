Hello, welcome to tech test done in WeatherBit IO
Using the following extensions

-SpecFlow for Visual Studio 2022
-Newtonsoft Json
-RestSharp

The following tech test contains the following APIs

-Get Current Weather Data

-Get Current Air Quality Data

================= FRAMEWORK =======================

APIHelper ->> Data Objects Model, Helper Classes, UserActions(Rest Actions)

SpecFlowProject2 ->> Features, Step Bindings/Definitions, Appsettings.Json (BaseURL/Endpoint)


================= DOCUMENTATION ===================

Weatherbit.io - Swagger UI Weather API documentation ---> https://www.weatherbit.io/api/swaggerui/weather-api-v2#!/Current32Weather32Data/

=============== TEST EXECUTION ====================

To execute the tests, 
1. Build/Rebuild the solution
2. In Menu, you need to access View, and click Test Explorer
3. Select and Expand until SpecFlowProject.Features
4. To run all, click "SpecFlowProject2" or "SpecFlowProject2.Features"
5. Press ">"


=============== TEST REPORT =======================

To view execution report / Test Detail Summary
1. After running, select test with marked as "X" or "v"
2. Double click, and view Test Detail Summary Report

============== ADDITIONAL NOTES ====================

BASEURL and ENDPOINTS are found in Project SpecFlowPorject2 -> Appsettings.json

Current Version only runs the following scenario due to limitation of Licence Key/API Key used.

-Get Current Weather Data by City

-Get Current Weather Data by Latitude Longitude
