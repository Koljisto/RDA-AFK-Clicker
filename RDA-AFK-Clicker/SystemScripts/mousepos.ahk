#NoEnv
SetWorkingDir %mydir%
CoordMode, mouse, Screen
SendMode Input
#SingleInstance Force
SetTitleMatchMode 2
#WinActivateForce
SetControlDelay 1
SetWinDelay 0
SetKeyDelay -1
SetMouseDelay -1
SetBatchLines -1

CustomColor = FFFFFF  ; Can be any RGB color (it will be made transparent below).
Gui +LastFound +AlwaysOnTop -Caption +ToolWindow  ; +ToolWindow avoids a taskbar button and an alt-tab menu item.
Gui, Color, %CustomColor%
Gui, Font, s32  ; Set a large font size (32-point).
Gui, Add, Text, vMyText cLime, Позиция курсора включена...Ctrl+D для ОСТАНОВКИ  ; XX & YY serve to auto-size the window.
WinSet, TransColor, %CustomColor% 150
Gui, Show, x100 y400 NoActivate

#Persistent
CoordMode, ToolTip, Screen
SetTimer, WatchCursor, 100
return

WatchCursor:
CoordMode, mouse, Screen ; Coordinates are relative to the desktop (entire screen).
MouseGetPos, x_1, y_1, id_1, control_1
ToolTip, X:%x_1% Y:%y_1%
return

^d:: ExitApp
ExitApp
return