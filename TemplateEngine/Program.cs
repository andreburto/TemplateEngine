using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TemplateEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load template
            string templateFile = Directory.GetCurrentDirectory().ToString() + "\\template.htm";
            string templateHtml = File.ReadAllText(templateFile);

            // Load variables
            Hashtable vars = new Hashtable();
            vars.Add("title", "TEST");
            vars.Add("body", "HELLO, WORLD!");
            vars.Add("today", DateTime.Now.ToString("MM/dd/yy H:mm:ss"));

            // Create rendering object
            HtmlRender hr = new HtmlRender(vars);

            // Display results
            Console.Write(hr.Render(templateHtml));
            Console.Read();
        }
    }
}
