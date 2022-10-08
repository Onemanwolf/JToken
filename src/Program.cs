using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Bson;

namespace JTokenExist;
class Program
{
    static void Main(string[] args)
    {

        var jpath = @"$.MemeberId";
        var json = @"{""MemeberId"":""123""}";

        JToken jToken = JToken.Parse(json);

        JToken? patientId = GetPatientId(jpath, jToken);
        //  var value = jToken.Value<object>(); // "b"
        if((string)patientId != ""){
          Console.WriteLine(patientId);
        }
        else{
            Console.WriteLine("Not found");
        }



        
    }

    private static JToken? GetPatientId(string jpath, JToken jToken)
    {
            return  jToken.Any() ? jToken.SelectToken(jpath) :  null; // true

    }
}
