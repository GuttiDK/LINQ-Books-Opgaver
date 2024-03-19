## Opgave 3
 
Lav et program , som benytter __LINQ query expressions__ til at vise en liste af aktive processer på pc´en.

> Programmet skal udskrive `Id` og `ProcessName` på alle processer, der bruger mere end __20 MB__ og sortere dem faldende.

---

### Hvis du sidder fast:
<details>
  <summary>Hent en liste af alle processer på pc´en</summary>

> Du henter processene ved at bruge `Process.GetProcesses();`
> ```C#
> 	Process[] processCollection = Process.GetProcesses();
> ```
  
  
</details>


