using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeScriptToCSharp.CSharp.Formatter;

namespace TypeScriptToCSharp.CSharp.Lexicon
{
    public class EnumValue
    {
        public EnumValue(object value)
        {
            Value = value;
        }

        public object Value { get; private set; }
        public Comment Comment { get; set; }

        public override string ToString()
        {
            return $"{Value}";
        }
    }

    public class EnumType : Type
    {
        public EnumType(ICSharpClosure context, string name, AccessSpecifier access = AccessSpecifier.Private) : base(context, name)
        {
            Access = access;
            Values = new Dictionary<string, EnumValue>();
        }

        public AccessSpecifier Access { get; private set; }
        public Dictionary<string, EnumValue> Values { get; private set; }
        public Comment Comment { get; set; }

        public override void Write(ICSharpFormatter formatter, bool comment = true)
        {
            if (comment)
            {
                Comment?.Write(formatter);
            }
            string @enum = string.Join(",\r\n", Values.Select(v => $"{v.Key} = {v.Value}"));
            formatter.WriteLine($"{(Access != AccessSpecifier.Private ? Access.ToString().ToLower() + " " : "")} enum {Name}{{");
            formatter.WriteLine(@enum);
            formatter.WriteLine($"}}");
        }
    }
}
