
##Garmin Tcx for .net

---

Used for analyze and generate Garmin tcx file.

###sample:

```cpp
string xml = "2014-09-15-21-33-08.tcx";
OpenTcx.Tcx tcx = new OpenTcx.Tcx();
tcx.AnalyzeTcxFile(xml, (OpenTcx.Entities.TrainingCenterDatabase_t tcd, System.Exception exp) =>
{
    if (exp != null)
    {
        Console.WriteLine(exp.Message);
    }
    else
    {
        if (tcd != null)
        {
            Console.WriteLine("ok");
        }
    }
});
```
