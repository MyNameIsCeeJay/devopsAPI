using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]"];
[ApiController];
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpsGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] {"value1","value2"};
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "Uncle Ceej";
    }
}