using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            var program = "class DynaCore{    static public void Main(string[] args)    {     Console.WriteLine(\"hello, this is good\");    }}";

            using (Microsoft.CSharp.CSharpCodeProvider foo = new Microsoft.CSharp.CSharpCodeProvider())
            {
                var res = foo.CompileAssemblyFromSource(
                    new System.CodeDom.Compiler.CompilerParameters()
                    {
                        GenerateInMemory = true
                    },
                    program
                );

                //var type = res.CompiledAssembly.GetType("FooClass");

                //var obj = Activator.CreateInstance(type);

                //var output = type.GetMethod("Execute").Invoke(obj, new object[] { });
            }


            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}