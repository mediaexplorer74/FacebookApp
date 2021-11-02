# Facebook (UWP version for Windows 10 Mobile)


##About
Facebook is a Universal Windows Platform (UWP ) unoffical app that lets you **access Facebook on Windows 10 Mobile phones**.

![Shot1](/Images/shot1.png)
![Shot2](/Images/shot2.png)

This app is based on the Facebook website ([www.facebook.com](https://www.facebook.com)) by using a WebView and injecting some JavaScript and CSS code.


## Features

All the following features are adapted to run on Windows 10 Mobile. Other features can also works but aren't fully tested.

- Send and receive text messages, voice messages, attachments, stickers, reactions and GIFs
- Group and bot conversations
- Take photos
- See who is online and which messages have been read
- Customize chat colors and nicknames
- Native back button support
- Acrylic effect (part of Fluent Design)
- Continuum support


## Roadmap ("dream on")))

- Dark theme
- Notifications + Live Tiles + Badges
- Record videos (doesn't seem to work)
- Play games with friends (to test)
- Add filters, masks and effects to your video chats (complicated)
- Watch Stories and add your own (complicated)
- Contact anyone without Facebook account
- Send payments
- Share your location
- Workplace Chat support
- XBox support


## Known issues

- Reactions, reply and forward to messages are not touch-friendly.
- In a thread, when a picture is too large, its preview isn't clipped away nicely.
- When the informations panel of a thread is opened, keyboard navigation can cause problems.


## Installation

For all users, simply install the appx package with the link above:
https://github.com/mediaexplorer74/FacebookApp/releases/tag/v1.0

For developers:
- Install [Visual Studio 2019](https://developer.microsoft.com/en-us/windows/downloads).

- Install the "Universal Windows Platform Development" workload.

- Install the Windows 10 SDK build 15063.

- Clone the code repository.

- Open [FacebookUWP.sln](/FacebookUWP.sln) with Visual Studio.


## Changelog

- Version 1.0.0 (public):
  - Fix UserAgent (Facebook compatibility). 
  - Fix view background on Lumia 950. 
  - Add an acrylic effect for the master view background.
  - Improve the loading screen and add a retry button.
  - Allow taking photos and recording audio messages.
  - Add zoom support when viewing pictures (using a touchpad or a touchscreen).
  - Improve the picture album and the settings dialog for small screens.
  - Fix an issue where the app crashed due to [an internal change in React](https://github.com/facebook/react/pull/18377)
  - Improve dialogs, settings and chatbot cards for small screens.
  - Improve navigation between the master and detail view: navigation should work in all cases.
  

 # Contribute!
There's still a TON of things missing from this proof-of-concept (MVP) and areas of improvement 
which I just haven't had the time to get to yet.
- UI Improvements (for GTK, for example, or for each one of supported mutli-platforms)))
- Additional Language Packages
- Media Transferring Support: screenshots, etc. (for the brave)


With best wishes,

  [m][e] 2021


## Thanks!
I wanted to put down some thank you's here for folks/projects/websites that were invaluable 
for helping me get this project into a functional state:
- [Dustin Hendriks](https://github.com/jetspiking/) - Great C# developer
- [WebWhatsApp](https://github.com/jetspiking/WindowsPhone_WebWhatsApp/) - WebWhatsapp project / solution


## License & Copyright

FacebookApp 1.0.0.0 is RnD project only. AS-IS. No support. Distributed under the MIT License.  

