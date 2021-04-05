# ADOFAI Mod Template

## IMPORTANT

The project assumes that the game's installation directory is at
`C:\Program Files (x86)\Steam\steamapps\common\A Dance of Fire and Ice`. Please
update the references in the `.csproj` if you have the game installed in a
different location.

## How to use this template

1. Download/clone this repository.
2. Find all occurrences of `MyAdofaiMod` and replace it with your mod's name.
   You will need to update these locations:
    - `MyAdofaiMod.sln`
    - `MyAdofaiMod\MyAdofaiMod.csproj`
    - `Info.json`
    - `Repository.json`
    - `make_release.bat`
    - The `namespace` in all `.cs` files
3. Open the project in Visual Studio 2019 (VS2019).
4. Update `Author`, `HomePage`, and `Repository` in `Info.json` with your
   information.
    - `Author` - Your name/username.
    - `DisplayName` - The displayed name in the in-game UMM settings window.
    - `HomePage` - Link to your GitHub repo. Users can click the WWW icon in the
      UMM settings window to go to the mod's GitHub page. Delete this if you do
      not plan on making the source code available.
    - `Repository` - Follow the **Updating the mod** section below for how to
      fill this in.
5. Change the Solution Configuration to `Release` by clicking the drop-down menu
   that says `Debug` at the top of the window.
6. Press `Ctrl+Shift+B` to build the whole project.
7. Run the `make_release.bat` script to create a mod release.
8. Upload the newly created `XXXXXXXX-1.0.0.zip` file online and share it!

## Updating the mod

The `make_release.bat` script will create a new version based on the version in
`VERSION.txt` and the last code built using `Ctrl+Shift+B` in VS2019. **Please
be sure to build the project with `Ctrl+Shift+B` before making the release!**

UnityModManager has the ability to update a mod through the manager tool.
In-game, this appears as a download icon to let the user know there's an update.

To provide this info UnityModManager, you need to update an online
`Repository.json` file that your mod's `Info.json` will link to through the
`Repository` field. For example, AdofaiTweaks has
"https://raw.githubusercontent.com/PizzaLovers007/AdofaiTweaks/master/Repository.json"
in this field. This `Repository.json` file can be uploaded anywhere but must
have a way to view the raw text context on the hosting site.

You'll only need to change `Info.json` **once**, but be sure the link is
correct or users won't be able to download the newest version. The `DownloadUrl`
in `Repository.json` should be set to the `.zip` file uploaded, and `Version`
should be updated to the new version.

## Helpful tips

### Automatically update the mod when developing

When developing your mod, it's helpful to update the mod currently installed in
ADOFAI automatically. You can setup a **Post-build Build Event** in the mod's
project to do this (be sure to replace `MyAdofaiMod` with whatever your mod's
name is):

1. Right click the `MyAdofaiMod` project (with the C# icon) and select
   `Properties`.
2. Go to the `Build Events` section on the left.
3. In the `Post-build event command line:` section add the following line:
    - `cp "$(TargetPath)" "C:\Program Files (x86)\Steam\steamapps\common\A Dance of Fire and Ice\Mods\MyAdofaiMod"`

This will automatically copy the newly built `MyAdofaiMod.dll` file to the
game's installed mod directory every time you use `Ctrl+Shift+B`.

### Keep the methods short

Debugging mods is very tricky as logs do not have line numbers. However, the
logs do contain function names, so be sure to keep the methods short to reduce
the number of lines you need to guess where things went wrong. You can view the
logs by opening the UMM settings in-game, going to the `Logs` tab, and clicking
on the `View detailed logs` button at the bottom.

### Join the ADOFAI modding discord!

https://discord.gg/YfVKH4WtvP

If you ever get stuck, feel free to ask in the ADOFAI modding discord! There are
several English and Korean speaking developers that can help you out in the
**#모드-개발-mod-development** channel.

## Further reading

* [dnSpy](https://github.com/dnSpy/dnSpy) - A C# code decompiler used to look at
  the ADOFAI game code. This (or some other decompiler) is **required** to be
  able to mod as you need to know which methods to patch.
* [Harmony](https://harmony.pardeike.net/articles/intro.html) - The patching
  framework used by UnityModManager to run code before/after methods.
  * [Prefixing](https://harmony.pardeike.net/articles/patching-prefix.html),
    [Postfixing](https://harmony.pardeike.net/articles/patching-postfix.html),
    and [Injections](https://harmony.pardeike.net/articles/patching-injections.html)
    are docs that I constantly reference.
* [UnityModManager how-to guides](https://wiki.nexusmods.com/index.php/Category:Unity_Mod_Manager) -
  How-to guides provided by UnityModManager.
* [Unity docs](https://docs.unity3d.com/2019.3/Documentation/Manual/index.html) -
  Unity is the game engine that ADOFAI is built on, so it's very helpful to have
  a good understanding of how the engine works.