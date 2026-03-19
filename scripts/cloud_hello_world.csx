// ==========================================
// Dynamic Revit Tool: Cloud Hello World
// Context: C# 10 / .NET Context / Revit API
// ==========================================
using System;
using Autodesk.Revit.DB;

public class CloudCommand 
{
    public static string Execute(Document doc)
    {
        return $"Hello from the Cloud API! Your current document is: {doc.Title}";
    }
}
