; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Software Demo"    
#define MyAppVersion "Demo"
#define MyAppPublisher "rck software"
#define MyAppURL "http://www.rcksoftware.com.br/"
#define MyAppExeName "RckSoftware_Demo.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{BAE9DB8C-492E-4E41-8F9E-381475ADF9C8}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\RCK Software\{#MyAppName}
DefaultGroupName=RCK Software\{#MyAppName}        
OutputBaseFilename=Install_RckSoftware-Demo
Compression=lzma
SolidCompression=yes                  

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; 

[Dirs]
Name: "{localappdata}\SoftwareDemo";
Name: "{localappdata}\SoftwareDemo\Reports";

[Files]
;RCK Installer
Source: "D:\Projects\RCK_Projects_SVN\Customers\Financeiro_MagiaTrigo\DATABASE\SCRIPT_SQLITE.SQL"; DestDir: {localappdata}\SoftwareDemo; Flags: ignoreversion
;App Magia Trigo
Source: "D:\PROJECTS\RCK_Projects_SVN\Customers\Financeiro_MagiaTrigo\bin\Debug\SoftwareDemo.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\PROJECTS\RCK_Projects_SVN\Customers\Financeiro_MagiaTrigo\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\PROJECTS\RCK_Projects_SVN\Customers\Financeiro_MagiaTrigo\Reports\*"; DestDir: "{localappdata}\SoftwareDemo\Reports"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: {app}\SoftwareDemo.exe; WorkingDir: {app}; IconFilename: {app}\SoftwareDemo.exe; IconIndex: 0
Name: "{commondesktop}\{#MyAppName}"; Filename: {app}\SoftwareDemo.exe; WorkingDir: {app}; IconFilename: {app}\SoftwareDemo.exe; IconIndex: 0; Tasks: desktopicon

[Run]
Filename: {app}\SoftwareDemo.exe; WorkingDir: {app}; Description: {cm:LaunchProgram,Software de Demonstra��o}; Flags: nowait postinstall skipifsilent