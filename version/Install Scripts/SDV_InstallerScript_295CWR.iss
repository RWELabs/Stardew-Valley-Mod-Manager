; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Stardew Valley Mod Manager"
#define MyAppVersion "220601"
#define MyAppPublisher "RWE Labs"
#define MyAppURL "https://rwe.app/labs/sdvmm"
#define RWELabsURL "https://rwelabs.github.io/"
#define SDVMMDocs "https://rwe.app/labs/sdvmm/docs"
#define MyAppExeName "Stardew Mod Manager.exe"
#define MyAppAssocName "Stardew Valley Modpack File"
#define MyAppAssocExt ".sdvmp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{60098568-4606-4E93-BFB2-CBE2B893DBE5}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#RWELabsURL}
AppSupportURL={#SDVMMDocs}
AppUpdatesURL={#MyAppURL}
DefaultDirName=C:\Program Files (x86)\RWE Labs\Stardew Valley Mod Manager\
ChangesAssociations=yes
DisableDirPage=yes
LicenseFile=C:\Users\rwalpole\Documents\GitHub\Stardew-Valley-Mod-Framework\web\license.rtf
DefaultGroupName=Stardew Valley Mod Manager
DisableProgramGroupPage=yes
OutputDir=C:\Users\rwalpole\Documents\GitHub\Stardew-Valley-Mod-Framework\version\Latest\
OutputBaseFilename=StardewModManagerSetup
SetupIconFile=C:\Users\rwalpole\Documents\GitHub\Stardew-Valley-Mod-Framework\source-code\Mod Manager\Stardew Mod Manager\Resources\defaultsdvicon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
UninstallDisplayIcon={app}\{#MyAppExeName}
UninstallDisplayName=Stardew Valley Mod Manager

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "C:\Users\rwalpole\Documents\GitHub\Stardew-Valley-Mod-Framework\source-code\Mod Manager (Facelift Development)\Stardew Mod Manager\bin\Release\Stardew Mod Manager.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\rwalpole\Documents\GitHub\Stardew-Valley-Mod-Framework\source-code\Mod Manager (Facelift Development)\Stardew Mod Manager\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\SDVMPFile.ico,0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

