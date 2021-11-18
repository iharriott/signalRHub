using System;
using Newtonsoft.Json;


public class Event {
  [JsonProperty(PropertyName = "Id")]
   public int Id {get; set;}
[JsonProperty(PropertyName = "Subject")]
   public string Subject {get; set;}

   [JsonProperty(PropertyName = "Location")]
   public string Location {get; set;}

   [JsonProperty(PropertyName = "StartTime")]
  
   public DateTime StartTime {get; set;}
    [JsonProperty(PropertyName = "EndTime")]
   public DateTime EndTime {get; set;}

  [JsonProperty(PropertyName = "IsAllday")]
   public Boolean IsAllday  {get; set;}

    [JsonProperty(PropertyName = "CategoryColor")]
   public string CategoryColor {get; set;}
}