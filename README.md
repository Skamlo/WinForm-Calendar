# Calendar
This is a WinForm aplication that I create to learn C# Windows Forms and handle .json files.

## Contents
* [General Information](#general-information)
* [Technologies](#technologies)
* [Features](#features)
* [Setup](#setup)
* [Usage](#usage)
* [Project Status](#project-status)
* [Future Improvements](#future-improvements)
* [Contact](#contact)

## General Information
Aplication own 3 pages, in turn - Settings, Calendar and Events.

## Technologies
- .NET - version 5.0
- Newtsoft.Json - version 13.0.1

## Features

#### Settings
Can be set:

* Aplication language - currently added languages is English and Polish
* Style - aplication colors, currently they are 3 defalut styles na custom color that is set with slider (some like slider from color picker in google search engine)
* First day of week - monday or sunday
* Date writing method - defalut writing method is day.month.year (e.g. 1.05.2022), but can also be set to diffrent combinations of this record e.g. month.day.year, year.month.day etc.
* Clock system - 12 hours system or 24 hours

#### Calendar
* Shifting months to months earlier or later
* Date selection using a diffrent form

#### Events
* Creating new events
* Deleting existing events (by clicking on it and seelcted delete option)
* Editing events (by clicking on it and seelcted edit option)

## Setup
To run aplication you need .NET 5.0 or later.

## Usage
To open this aplication you have to run `Calendar.exe` file from `Calendar/bin/Release/net5.0-windows` folder or turn on .sln file and run it with that.

## Project Status
Currently this aplication is usable, but I have plans to add some changes and new features.

## Future Improvements
#### Changes
* Currently this program using .json files to saving events. It is not the best solution, because when user would like sort events by add date or sort titles alphabetically it is imposible. So it is better to replace the .json files with the database.

#### New Features
* I have plan to add new clearer interface on events page (similar to that of Microsoft Teams or windows Calendar).

## Contact
Email: maksymiliannorkiewicz@gmail.com