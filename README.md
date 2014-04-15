VirusTotal.VB.NET
=================

VB.NET port of GenBox's excellent VirusTotal C# interface, with testbed application.

This project was originally just a way to explore VirusTotal's API for inclusion in one
of our software applications. Since it seems that VB.NET code for this is a bit hard to
come by, we figured why not fill that niche?

We removed the URL scanning features, as they weren't relevant to our purposes, but they
should be easy enough to add back in. We also modified the interface to return a List(Of T)
rather than the more advanced (but probably not necessary) IEnumerable.

Comments are severely lacking, but again, most of the code should be pretty easy to follow.
