# WordSearchPuzzle

- I made a solution called: WordSearchPuzzle which consists of 4 projects:
  -   WordSearchPuzzle.ApiService  
  -   WordSearchPuzzle.AppHost
  -   WordSearchPuzzle.ServiceDefaults
  -   WordSearchPuzzle.Web
- The WordSearchPuzzle.ApiService application is the project that creates the array, looks up the words sent in the array and returns the coordinates.

- The application WordSearchPuzzle.Web is the one that draws the matrix in a friendly web interface to make it easier to test and visualize the work done, the same consumes an api of: WordSearchPuzzle.ApiService and with this data the words found in the matrix are drawn and placed in a list with the words that made coincidence.

- The other projects serve as crutches to orchestrate the instances of the application (frontend and backend) and to visualize the logs and the performance of the application in a friendly interface using .NET Aspire. 

- This solution is realized using .NET 8.
