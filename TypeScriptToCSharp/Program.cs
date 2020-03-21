using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeScriptToCSharp.CSharp;
using TypeScriptToCSharp.TypeScript;

namespace TypeScriptToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            string location = "";
            //if (args.Length > 0)
            //    location = args[0];
            //else
            {
                Console.WriteLine("Enter Typescript file path\r\n>");
                location = Console.ReadLine();
            }
            //const string argStart = "--converter:";
            //string converterV = args.FirstOrDefault(v => v.StartsWith(argStart));
            //if (converterV == null)
            //    Console.WriteLine(@"What software would you like to convert for?
            //    Currently Supported:
            //    Bridge,
            //    DuoCode");
            //string converterValue = converterV == null ? Console.ReadLine() : converterV.Substring(argStart.Length);
            //ConversionSoftware conversionSoftware = (ConversionSoftware)Enum.Parse(typeof(ConversionSoftware), converterValue);
            string file;
            Console.WriteLine("Reading file...");
            try
            {
                file = File.ReadAllText(location);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            CSharpProcessor context = new CSharpProcessor();
            TypeScriptParserSettings settings = new TypeScriptParserSettings()
            {
                PublicAll = true,
                Using = new string[] {
                    //"static Retyped.leaflet"
                },
                RenameType = new Dictionary<string, string>()
                {
                    //{ "Icon", "Icon<object>" },
                    //{ "leaflet", "leafletDraw" },
                    //{ "FeatureGroup", "FeatureGroup<object>" },
                    ////{ "Circle", "Circle<object>" },
                    ////{ "CircleMarker", "CircleMarker<object>" },
                    ////{ "Marker", "Marker<object>" },
                    ////{ "Polygon", "Polygon<object>" },
                    ////{ "Polyline", "Polyline<object>" },
                    ////{ "Rectangle", "Rectangle<object>" },
                    //{ "LayerGroup", "LayerGroup<object>" },
                    //{ "L", "leaflet" },
                }
            };
            var parser = new TypeScriptParser(file, context, settings);
            Console.WriteLine("Parsing Typescript...");
            var @object = parser.Parse(Path.GetFileNameWithoutExtension(location));
            @object.PreConvert();
            Console.WriteLine("Building References...");
            context.BuildReference();
            //Console.WriteLine("Implemeting Interfaces...");
            //context.ImplementInterfaces();
            //Console.WriteLine("Creating POCO Classes...");
            //context.CreatePOCOClasses();
            Console.WriteLine("Resolving name conflicts...");
            if (settings.ResolveConflictingNames)
            {
                context.ResolveNameConfilict();
            }
            Console.WriteLine("Transpiling...");
            string cSharp = context.Transpile($@"
using System;
using TSCS;
using Date = System.DateTime;
{string.Join("\r\n", settings.Using.Select(u=> $"using {u};"))}
#pragma warning disable CS0626
#pragma warning disable CS0824
#pragma warning disable CS0108
#pragma warning disable IDE1006
            ", null, false);
            Console.WriteLine("Writing...");
            File.WriteAllText($"{Path.GetFileNameWithoutExtension(location)}.cs", cSharp);
            Console.WriteLine("Exiting...");
        }
    }
}
