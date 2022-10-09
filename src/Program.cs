using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Bson;

namespace JTokenExist;
class Program
{
    static void Main(string[] args)
    {
        var selectNames =@"$.[?(@.Name != null)].Name";
        var jpath = @"$.MemeberId";
        var getName = @"$.Name";
        var json = @"{""MemeberId"":""123""}";
        var memeber = @"{'MemeberId':'123', 'Name':'John'}";
        var memebers = @"[{'MemeberId':'123', 'Name':'John'},{'MemeberId':'456', 'Name':'Mary'}]";
        var getMemebers = GetTokens(selectNames, memebers);

        foreach(var item in getMemebers)
        {

            Console.WriteLine(item);
        }
        var memeberToken = JToken.Parse(memeber);

        JToken jToken = JToken.Parse(json);
        var patintName = GetToken(getName, memeber);
        Console.WriteLine(patintName);

        JToken? patientId = GetToken(jpath, json);
        //  var value = jToken.Value<object>(); // "b"
        if((string)patientId != ""){
          Console.WriteLine(patientId);
        }
        else{
            Console.WriteLine("Not found");
        }

    }

    private static JToken? GetToken(string jpath, string json)
    {       var jToken = JToken.Parse(json);
            return  jToken.Any() ? jToken.SelectToken(jpath) :  null; // true

    }

    private static IEnumerable<JToken>? GetTokens(string jpath, string json)
    {       var jToken = JToken.Parse(json);
            return  jToken.Any() ? jToken.SelectTokens(jpath) :  null; // true

    }
}
