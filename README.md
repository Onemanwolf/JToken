# JToken Query JSON with Json Path

Documentation on how to query json with [Newtonsoft JSON JPath](https://www.newtonsoft.com/json/help/html/QueryJsonSelectToken.htm)

### C# example of querying json

```csharp

        var selectNames =@"$.[?(@.Name != null)].Name";
        var jpath = @"$.MemeberId";
        var getName = @"$.Name";
        var json = @"{""MemeberId"":""123""}";
        var memeber = @"{'MemeberId':'123', 'Name':'John'}";
        var memebers = @"[{'MemeberId':'123', 'Name':'John'},{'MemeberId':'456', 'Name':'Mary'}]";

        // get patientId from json
        JToken? patientId = GetToken(jpath, json);

        // get name from memeber json
        var getMemebers = GetTokens(selectNames, memebers);

        private static JToken? GetToken(string jpath, string json)
         {       var jToken = JToken.Parse(json);
            return  jToken.Any() ? jToken.SelectToken(jpath) :  null;

        }

        private static IEnumerable<JToken>? GetTokens(string jpath, string json)
        {       var jToken = JToken.Parse(json);
            return  jToken.Any() ? jToken.SelectTokens(jpath) :  null;

         }



```
