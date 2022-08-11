using PartGuesterLibrary.Models;



List<GuestLibararyClass> guests = new();

GetInformationFromUser(guests);

PrintInformations(guests);


static void PrintInformations(List<GuestLibararyClass> guests)
{
    foreach (GuestLibararyClass guest in guests)
    {
        Console.WriteLine(guest.FullStuff);
    }
}
static void GetInformationFromUser(List<GuestLibararyClass> guests)
{
    string StillCounting = "";

    do
    {
        GuestLibararyClass guest = new GuestLibararyClass();
        guest.FirstName = Messages("What's your first name: ");
        guest.LastName = Messages("What's your last name:  ");
        guest.MessageToHost = Messages("What's your message to the host: ");
        StillCounting = Messages("Contiue Yes/No: ");
        guests.Add(guest);
        Console.Clear();
    } while (StillCounting.ToLower() == "yes");

}
static string Messages(string message)
{
    Console.WriteLine(message);
    string output = Console.ReadLine();
    return output;
}





