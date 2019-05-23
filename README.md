# FolderMonitor
Simple .Net Core 3 application for monitoring sets of folders.

A lot of Enterprise and internal applications still use "hot folders" to exchange information between on-premise systems.
This application loads a number of "profiles", each as a tab, to monitor activity in groups of folders.

## Usage
Create Profiles folder at 
```
%PROGRAMDATA%\FolderMonitor\Profiles
```

and one or more json files with the following structure

```json
{
  "Name": "BusinessLink",
  "Folders": [
    {
      "Name": "Watch",
      "Path": "C:\\BusinessLink\\Watch",
      "ErrorState": 2
    },
    {
      "Name": "Error",
      "Path": "C:\\BusinessLink\\Error",
      "ErrorState": 0
    },
    {
      "Name": "Processed",
      "Path": "C:\\BusinessLink\\Processed",
      "ErrorState": 2
    }
  ]
}
```

## Roadmap:
* Implement ErrorState - Notify user if ErrorState is met. For instance, when monitoring a folder that should normally be empty, highlight as in error.
* Allow customisation of Profiles location.
* Installer
* CI/CD
