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
            string templateFile = Directory.GetCurrentDirectory().ToString() + "\\template.htm";
            string templateHtml = File.ReadAllText(templateFile);
            Hashtable vars = new Hashtable();

            vars.Add("title", "TEST");
            vars.Add("body", "HELLO, WORLD!");

            HtmlRender hr = new HtmlRender(vars);

            Console.Write(templateHtml);
            Console.Write(hr.Render(templateHtml));
            Console.Read();
        }
    }
}
