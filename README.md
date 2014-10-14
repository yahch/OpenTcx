
##Garmin Tck for .net

---

Used for analyze Garmin tck file.

###sample:

```cpp
string xml = "2014-09-15-21-33-08.tcx";
OpenTcx.Tcx tcx = new OpenTcx.Tcx();
tcx.AnalyzeTckFile(xml, (OpenTcx.Entities.TrainingCenterDatabase_t tcd, System.Exception exp) =>
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