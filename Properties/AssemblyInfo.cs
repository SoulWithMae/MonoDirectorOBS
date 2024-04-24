﻿[assembly: AssemblyTitle(WeatherElectric.MonoDirectorOBS.Main.Description)]
[assembly: AssemblyDescription(WeatherElectric.MonoDirectorOBS.Main.Description)]
[assembly: AssemblyCompany(WeatherElectric.MonoDirectorOBS.Main.Company)]
[assembly: AssemblyProduct(WeatherElectric.MonoDirectorOBS.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + WeatherElectric.MonoDirectorOBS.Main.Author)]
[assembly: AssemblyTrademark(WeatherElectric.MonoDirectorOBS.Main.Company)]
[assembly: AssemblyVersion(WeatherElectric.MonoDirectorOBS.Main.Version)]
[assembly: AssemblyFileVersion(WeatherElectric.MonoDirectorOBS.Main.Version)]
[assembly:
    MelonInfo(typeof(WeatherElectric.MonoDirectorOBS.Main), WeatherElectric.MonoDirectorOBS.Main.Name,
        WeatherElectric.MonoDirectorOBS.Main.Version,
        WeatherElectric.MonoDirectorOBS.Main.Author, WeatherElectric.MonoDirectorOBS.Main.DownloadLink)]
[assembly: MelonColor(ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]