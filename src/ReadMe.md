## JToken Documentation

Documentation on how to query json with [Newtonsoft JSON JPath](https://www.newtonsoft.com/json/help/html/QueryJsonSelectToken.htm)

### C# example of querying json

```csharp

private static JToken? GetToken(string jpath, string json)
    {       var jToken = JToken.Parse(json);
            return  jToken.Any() ? jToken.SelectToken(jpath) :  null;

    }

    private static IEnumerable<JToken>? GetTokens(string jpath, string json)
    {       var jToken = JToken.Parse(json);
            return  jToken.Any() ? jToken.SelectTokens(jpath) :  null;

    }



```