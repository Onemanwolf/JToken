using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Bson;

namespace JTokenExist;
class Program
{
    static void Main(string[] args)
    {

        var jpath = @"$.MemeberId";
        var getName = @"$.Name";
        var json = @"{""MemeberId"":""123""}";
        var memeber = @"{'MemeberId':'123', 'Name':'John'}";
        var memeberToken = JToken.Parse(memeber);

        JToken jToken = JToken.Parse(json);
        var patintName = GetPatientId(getName, memeber);
        Console.WriteLine(patintName);

        JToken? patientId = GetPatientId(jpath, json);
        //  var value = jToken.Value<object>(); // "b"
        if((string)patientId != ""){
          Console.WriteLine(patientId);
        }
        else{
            Console.WriteLine("Not found");
        }




    }

    private static JToken? GetPatientId(string jpath, string json)
    {       var jToken = JToken.Parse(json);
            return  jToken.Any() ? jToken.SelectToken(jpath) :  null; // true

    }
}
