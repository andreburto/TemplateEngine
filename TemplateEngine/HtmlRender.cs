using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateEngine
{
    class HtmlRender
    {
        public void AddVariable(string key, string val)
        {
        }

        public void RemoveVariable(string key)
        {
        }

        public HtmlRender() { }

        public HtmlRender(Hashtable pre_var)
        {
        }

        // PRIVATE
        private string Lz(string n)
        {
            int i = int.Parse(n);
            if (i < 10) { return "0" + n; }
            return n;
        }
    }
}
