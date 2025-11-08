hello there, this is a MAUI Blazor Hybrid application that lets to fetch the data from a free online API(i.e. JSONPlaceholder). it then saves that data locally on our device using sqlite and later we cans ee the saved data in a list on the screen. Thdere is also a "Fetch and save data" button please click it ot get the data from the internet and store it locally.
i have used JSONPlaceholder API. it gives fake post data in JSON format.
there are few project files i have made 
-FetchPage.razor - The main page with the button and posts list.
-ApiService.cs - it helps to get the data from the API
-SqliteRepository.cs - it helps to save and read data from SQlite
-post.cs - This is like a model fro each post.
-MauiProgram.cs - ithelps to set up the service
