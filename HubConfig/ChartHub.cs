using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

public class ChartHub : Hub {

  public async Task BroadcastChartData(List<ChartModel> data) =>
   await Clients.All.SendAsync("broadcastchartdata", data);

   public async Task BroadcastEventData(List<Event> data) =>
   await Clients.All.SendAsync("broadcasteventdata", data);

    // public async Task BroadcastEvent(Event data) =>
    // await Clients.All.SendAsync("broadcastevent", data);
    public async Task BroadcastEvent(Event data) =>
       await Clients.All.SendAsync("broadcastevent", data);

    public async Task JoinGroup(string groupName){
      await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
      //await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
      await Clients.Group(groupName).SendAsync("Send", groupName);
    }
      

    public async Task SendtoGroup(string groupName, List<Event> data){
     Console.WriteLine("group" + groupName);
     await Clients.Group(groupName).SendAsync("triggerGroup", data); 
    }
     
}