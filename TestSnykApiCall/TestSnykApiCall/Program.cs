using TestSnykApiCall;

Console.WriteLine("Hello, World!");

// Main class
MainClass mainClass = new MainClass();




// Get a list of all orgs
Console.WriteLine("Get a list of all orgs:");
var response = await mainClass.GetOrganisations();
Console.WriteLine(response + "\n");





// Get integration id for org
/*Console.WriteLine("Get integration id for org:");
var orgId = "a7c25de3-cb98-4ac0-8ddf-6dce47b56c7a";
response = await mainClass.GetIntegrations(orgId);
Console.WriteLine(response + "\n");*/





// Get a list of all users
/*var groupId = "e97960f4-4b9d-4870-a11d-92fae93b7497";
Console.WriteLine("Get a list of all users:");
response = await mainClass.ListGroupMembers(groupId);
Console.WriteLine(response + "\n");*/



// Add a user to the org
/*var orgId = "a7c25de3-cb98-4ac0-8ddf-6dce47b56c7a";
var groupId = "e97960f4-4b9d-4870-a11d-92fae93b7497";
var userId = "bd5f4230-757c-4e89-bfdb-cb49c78ec2f4";
var userRole = "collaborator";
Console.WriteLine("Add a user to the org:");
response = await mainClass.AddUser(orgId, groupId, userId, userRole);
Console.WriteLine(response + "\n");*/