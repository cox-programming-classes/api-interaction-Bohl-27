global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Services;

var apiService = new ApiService();

var loginSuccess = true;

await apiService.Login("jcox@winsor.edu", "not my password",
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    });
    
if(!loginSuccess)
    return;

var myFreeBlocks = await apiService.SendAsync<FreeBlockCollection>(HttpMethod.Get, "api/schedule/free-blocks/for/voEV6yMD6RW0", 
    err =>
    {
        Console.WriteLine(err);
    });