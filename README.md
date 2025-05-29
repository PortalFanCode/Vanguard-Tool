# Vanguard Tool

I made this tool to help me control when Vanguard is running on my system. I did this to test WinForms. It was made with the help of AI.



# What each button does

It uses the commands shared by [@AndrewMast](https://gist.github.com/AndrewMast): [Commands to temporarily stop Riot Vanguard](https://gist.github.com/AndrewMast/742ac7e07c37096017e907b0fd8ec7bb).

- **Disable start**: `sc config vgc start= demand & sc config vgk start= system`
- **Kill**: `net stop vgc & net stop vgk & taskkill /IM vgtray.exe`
- **Disable start and kill**: `sc config vgc start= disabled & sc config vgk start= disabled & net stop vgc & net stop vgk & taskkill /IM vgtray.exe`
- **Enable start**: `sc config vgc start= demand & sc config vgk start= system`
- **Restart computer**: `shutdown /r /f /t 00`

## In layman's terms

- **Disable start**: Prevents Vanguard from starting automatically when you boot your computer.
- **Kill**: Stops Vanguard immediately and closes its tray icon.
- **Disable start and kill**: Prevents Vanguard from starting automatically and stops it immediately.
- **Enable start**: Allows Vanguard to start automatically when you boot your computer.
- **Restart computer**: Restarts your computer to apply any changes made.

# Credits

- [@AndrewMast](https://gist.github.com/AndrewMast) for the commands to stop Vanguard.
- [@Simon-12](https://github.com/Simon-12) & [Pesqoo](https://github.com/Pesqoo) for the original idea and the icon.