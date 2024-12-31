# CompuMaster.PGK.Extension (aka .NET-Extensions)

## .NET Extensions Methods Library for C# and VB.NET (ASP.NET, MVC, SL, WPF, EF) for .NET Standard 2.0

Supports .NET Standard 2.0, .NET Framework 4.8, .NET Core/5/6/7/8/9/... 

The .NET Extensions project provides the missing piece that you always expected to be part of the Framework Class Library.

## History of project development

### dnpextensions

Copy from http://dnpextensions.codeplex.com/

The project literally contains hundreds of extension methods for well known FCL data types. You can just add a reference and start using them today.

### Kochen.mit.Patrick

Follow me on Facebook @ http://facebook.com/Kochen.mit.Patrick
Or follow me on Twitter (expect less updates here) @ http://twitter.com/PatrickLorenz   kick it on dotnet-kicks.de

Visit our team page.

### CompuMaster GmbH

* Added support for .NET Standard 2.0, .NET Framework 4.8, .NET Core/5/6/7/8/9/... (for most of the PGK projects)
* Therefore redesigned technology stack (dependency projects) to add support for .NET Standard 2.0
* Re-publishing at NuGet gallery for common use (most of the PGK projects)

## What users are saying:

* "This library was immediately useful. I began using methods that I didn't even realize were implemented in it because it covers methods that naturally feel like they should be there."
* "It just work!, i don't have to add any using statement"
* "Where have you been all my life..."
* Get this library from NuGet and you can immediately start using it without any "using" statements or anything. Starts to feel like they are actually part of the framework. Excellent library!

## PGK.Extensions (Core)

System.Array
System.Byte[]
System.Collections.Generic.ICollection<T>
System.Collections.Generic.IEnumerable<T>
System.Collections.Generic.IList<T>
System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>
System.ComponentModel.IComponent
System.Data.DataRow
System.Data.DataRowView
System.Data.IDataReader
System.DateTime
System.DateTimeOffset
System.Dictionary
System.Double
System.Drawing.Bitmap
System.Exception
System.Float
System.IComparable<T>
System.IO.DirectoryInfo
System.IO.FileInfo
System.IO.FileInfo[] (batch operations on array)
System.IO.Stream
System.IO.TextReader
System.Int32
System.Int64
System.Net.Sockets
System.Object
System.String
System.String[]
System.TimeSpan
System.Type
System.ValueType (all structs)
System.Xml.XmlNode
System.Xml.Serialization (Xml serialization operations on objects)

## PGK.Extensions.Web (ASP.NET)

System.Web.UI.Control
System.Web.UI.StateBag
System.Web.SessionState.HttpSessionState
System.Web.HttpResponse
System.Net.HttpListenerContext

## PGK.Extensions.Windows (WPF)

System.Windows.UIElement
System.Windows.Media.Imaging.BitmapSource

## PGK.Extensions.Windows.Forms (Windows Forms)

System.Windows.Forms.Control

## PGK.Extensions.MVC (ASP.NET MVC) .NET Framework 4.8

System.Web.Mvc.HtmlHelper
System.Web.HttpSessionStateBase
System.Web.Routing

## Requirements

Some sub projects (eg. ASP.NET MVC) require .NET Framework 4.8.

## License

The project is licensed under the Apache 2.0 license. This basically means that you can freely use it in non-commercial and as well commercial projects.
